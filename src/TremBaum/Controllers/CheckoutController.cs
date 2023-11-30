using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TremBaum.Helpers;
using TremBaum.Models;
using Stripe;

namespace TremBaum.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        [TempData]
        public string TotalAmount { get; set; }
        public IActionResult Index()
        {
            var carrinho = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho");
            ViewBag.carrinho = carrinho;
            ViewBag.ReaisAmount = carrinho.Sum(item => item.Produto.Preco * item.Quantidade);
            ViewBag.total = Math.Round(ViewBag.ReaisAmount, 2)*100;
            ViewBag.total = Convert.ToInt64(ViewBag.total);
            long total = ViewBag.total;
            TotalAmount = total.ToString();
            return View();
        }
        [HttpPost]
        public IActionResult Processing(string stripeToken, string stripeEmail)
        {
            var optionsCust = new CustomerCreateOptions
            {
                Email = stripeEmail,
                Name = "Pedro",
                Phone = "04-234567"
            };
            var serviceCust = new CustomerService();
            Customer customer = serviceCust.Create(optionsCust);
            var optionsCharge = new ChargeCreateOptions
            {
                Amount = Convert.ToInt64(TempData["TotalAmount"]),
                Currency = "BRL",
                Description = "Venda de produtos",
                Source = stripeToken,
                ReceiptEmail = stripeEmail
            };
            var serviceCharge = new ChargeService();
            Charge charge = serviceCharge.Create(optionsCharge);
            if(charge.Status == "succeeded")
            {
                ViewBag.AmountPaid = Convert.ToDecimal(charge.Amount) % 100 / 100 + (charge.Amount) / 100;
                ViewBag.Customer = customer.Name;
            }
            return View();
        }
    }
}
