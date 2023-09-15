# Especificações do Projeto

A fim de definir de maneira minuciosa a especificação do problema e os pontos mais relevantes a serem tratados neste projeto, foram realizadas entrevistas com os funcionarios do Mercado Trem Baum.

## Personas

|<img src="https://unsplash.com/d3nKNw1ILdM" width="150" height="100">   | **Joana Oliveira** <br> 29 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Funcionária do supermercado Trem Baum.
|**Motivação** | Conseguir desempenhar suas funções de maneira mais fácil.
|**Frustrações** | Dificuldade para mexer no sistema do supermercado.|

|<img src="https://imagens.som13.com/332003/full.jpg"  width="150" height="100">  | **Sheila Furacão** <br> 49 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Fornecedora do supermercado Trem Baum.
|**Motivação** | Conseguir entregar mais facil seu produto com melhor checkout de vendas.
|**Frustrações** | Perda financeira por conta de erro no pagamento.|


|<img src="docs/img/joao gomes.png" width="150" height="100">   | **João Gomes** <br> 41 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Gerente de matéria prima dos produtos
|**Motivação** | Conseguir reduzir de forma efetiva o desperdicio de materia prima, cujo o armazenamento não é tao efetivo, pois diminui a qualidade do produto.
|**Frustrações** | Desperdicio e consequentemente percas financeiras gerados ao mercado.|

|<img src="" width="150" height="100">   | **Ellon Muska** <br> 43 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Atendente de lojinha de iguarias mineiras
|**Motivação** | Organizar a loja e ver os clientes satisfeito.
|**Frustrações** | Perder vendas por não ter uma plataforma digital da lojinha .|

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-trem-baum/blob/main/docs/img/abigailsilva.png" width="150" height="100">   | **Abiagail da silva** <br> 68 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Aposentada e fofoqueira numero 1 do bairro.
|**Motivação** | varrer a calçada todas as manhas enquanto pego as news fresquisnhas.
|**Frustrações** | o WhatsApp .|

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-trem-baum/blob/main/docs/img/Rogerio.png" width="150" height="150">   | **Rogério Menezes** <br> 58 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Ocupação** | Comerciante de uma cidade do interior.
|**Aplicativos** | Facebook, WhatsApp, Kwai.
|**Motivação** | Viajar para a capital em busca de produtos que serão revendidos em sua loja.
|**Frustrações** | Passar muito tempo indo em variadas lojas em busca de produtos típicos da região. |

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/DESEJO ... `O QUE` |PARA ... `PORQUE`                 |
|--------------------|------------------------------------|----------------------------------------|
|João Gomes (Gerente de matéria prima)|	Receber informações dos recursos necessarios para produção dos produtos artesanais de forma assertiva|	Evitar desperdicios e manter o mercado sempre abastecido.|
|Rogério Menezes (Consumidor)| Realizar pedidos de maneira eficiente e interativa | Economizar tempo em minha viagem e ver mais lojas.|
|Maria de Assis Pereira (administradora do sistema)|	Acessar todos os dados dos alunos, acessar todos os dados dos cursos|	Controlar os acessos e permissões dos alunos, montar a grade de programação dos cursos|
|Joaquim Lara (ponto focal da secretaria/órgão/entidade)| Acessar a grade de programação dos cursos, acessar as informações de todos cursos feitos pelos servidores da minha área de acompanhamento, concentrar os contatos com os servidores em um canal de comunicação específico na plataforma|	Programar a distribuição das vagas aos servidores da minha área de responsabilidade|
|Rosana Avelar (gestora da escola de governo)|	Acessar um painel de indicadores (de desempenho dashboard) dos alunos e dos cursos realizados|	Gerar relatórios aos superiores hierárquicos e auxilia-los na tomada de decisões|
## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    |Descrição do Requisito| Prioridade |
|------|----------------------|------------|
|RF-01| O supermercado deve permitir o cadastro de clientes e gerentes.	|ALTA|
|RF-02|	O supermercado deve permitir o login de clientes e gerentes. |ALTA|
|RF-03|	O supermercado deve apresentar uma lista com seus produtos. |ALTA|
|RF-04| O supermercado deve permitir que clientes realizem pedidos. |ALTA|
|RF-05|	O supermercado deve permitir que clientes verifiquem seus pedidos. |MÉDIA|
|RF-06| O supermercado deve permitir que gerentes verifiquem e atualizem o estoque. |ALTA|
|RF-07| O supermercado deve permitir a efetuação de pagamentos. |ALTA|
|RF-08| O supermercado deve permitir que gerentes atualizem clientes de seus pedidos.  |MÉDIA|
|RF-09| O supermercado deve permitir que gerentes verifiquem todos os pedidos. |BAIXA|


### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID  | Descrição do Requisito  |Prioridade |
|----|-------------------------|----|
|RNF-01|	A aplicação deve ser publicada em um ambiente acessível publicamente na Internet|ALTA|
|RNF-02|	A aplicação deverá ser responsiva permitindo a visualização em um celular de forma responsiva|ALTA|
|RNF-03|	A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade|MÉDIA|
|RNF-04| A aplicação deve estar disponível 24 horas por dia, todos os dias da semana  | ALTA |
|RNF-05| A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge, Safari ou Opera) | ALTA |
|RNF-06| A aplicação deve ter uma linguagem simples e de fácil entendimento | ALTA |
|RNF-07| A aplicação deve ter uma boa navegabilidade e usabilidade, facilitando a experiência do usuário | ALTA |
|RNF-08| Por se tratar de uma aplicação com abrangência nacional, a mesma deve comportar grandes acessos simultâneos | ALTA |


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01|	O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 06/12/2022|
|RE-02|	O aplicativo deve se restringir às tecnologias básicas da Web no back-end|

## Diagrama de Casos de Uso
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-trem-baum/assets/103541503/82de4322-ecaa-4645-9f32-045b1965e042)

