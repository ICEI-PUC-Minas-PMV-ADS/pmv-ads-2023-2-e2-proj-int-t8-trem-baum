using Microsoft.AspNetCore.Mvc;
using TremBaum.Models;

namespace TremBaum.Controllers
{
	public class CadastroController : Controller
	{
		public IActionResult Index(CadastroModel cadastromodel)
		{
			String usuarioCadastro = cadastromodel.userNameCadastro;
			String senhaCadastro = cadastromodel.passwordCadastro;
			String emailCadastro = cadastromodel.emailCadastro;

			public static int ValidarUsuarioCadastro()
			{
				if (usuarioCadastro.Length > 15 && usuarioCadastro == null)
				{
					throw new ArgumentException("Usuario tem que ser maior do que 0 e menor ou igual a 15");
				}

				return ValidarUsuarioCadastro();
			}
			usuarioCadastro = "";
			usuarioCadastro.ValidarUsuarioCadastro();







			return View();
		}
	}
}