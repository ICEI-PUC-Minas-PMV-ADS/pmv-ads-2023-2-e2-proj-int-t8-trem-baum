# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Testes dos Requisitos Funcionais


Objetivo: Avaliar o atendimento dos requisitos funcionais

 
| **Caso de Teste** 	| **CT-01 – Cadastro de usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 -  O supermercado deve permitir o cadastro de clientes e gerentes. |
| Objetivo do Teste 	|Verificar se a função de cadastro de usuário está operando corretamente. |
| Passos 	| -Entrar no app e selecionar "Cadastrar-se"; <br> - Selecionar a opção "Cliente".<br> - Informar as informações solicitadas: Nome, CPF, data de nascimento e senha;<br> - Clicar no botão cadastrar. |
|Critério de Êxito | - O sistema será redirecionado para a página de login. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 - Cadastro de gerente**	|
|Requisito Associado | RF-01	- O supermercado deve permitir o cadastro de clientes e gerentes. |
| Objetivo do Teste 	| Verificar se a função de cadastro de gerente está operando corretamente. |
| Passos 	| - Entrar no app e selecionar "Cadastrar-se"; <br> - Selecionar a opção "Gerente"; <br> - Informar as informações solicitadas: Nome, CPF, data de nascimento e senha; <br> - Clicar no botão cadastrar. |
|Critério de Êxito | - O sistema será redirecionado para a página de login. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 - Efetuar login do usuário (cliente)**	|
|Requisito Associado | RF-02	- O supermercado deve permitir o login de clientes e gerentes. |
| Objetivo do Teste 	| Verificar se a função de login de usuário está operando corretamente. |
| Passos 	| - Entrar no app e selecionar "Login"; <br> - Informar email e senha; <br> - Clicar no botão de logar.|
|Critério de Êxito | - A tela principal do aplicativo será mostrada. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 - Efetuar login do gerente**	|
|Requisito Associado | RF-02	- O supermercado deve permitir o login de clientes e gerentes. |
| Objetivo do Teste 	| Verificar se a função de login de gerente está operando corretamente. |
| Passos 	| - Entrar no app e selecionar "Login"; <br> - Informar email e senha; <br> - Clicar no botão de logar.|
|Critério de Êxito | - A tela principal do aplicativo será mostrada. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 - Apresentar lista de produtos**	|
|Requisito Associado | RF-03	- O supermercado deve apresentar uma lista com seus produtos. |
| Objetivo do Teste 	| Verificar se a lista de produtos é apresentada da forma correta, disponibilizando apenas os produtos que forem vendidos pelo supermercado e estiverem disponíveis no estoque no momento do pedido. |
| Passos 	| - Logar no app; <br> - Entrar na página inicial (página dos produtos).|
|Critério de Êxito | - A tela principal (página dos produtos) será mostrada. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 - Realização de pedidos** |
|Requisito Associado | RF-04	- O supermercado deve permitir que clientes realizem pedidos. |
| Objetivo do Teste 	| Verificar a tentativa de realizar um pedido. |
| Passos 	| - Logar no app; <br> - Entrar na página inicial; <br> - Adicionar produtos ao carrinho de compras; <br> - Entrar no carrinho de compras; <br> - Clicar em realizar pedido. |
|Critério de Êxito | - A página de checkout deve ser mostrada. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 - Verificação e atualização do estoque**	|
|Requisito Associado | RF-06	- O supermercado deve permitir que gerentes verifiquem e atualizem o estoque. |
| Objetivo do Teste 	| Validar a verificação e atualização do estoque do supermercado. |
| Passos 	| - Logar no app; <br> - Entrar na página inicial; <br> - Entrar na aba de gerente; <br> - Entrar na página de estoque; <br> - Verificar informações do estoque; <br> - Atualizar informações do estoque. |
|Critério de Êxito | - Produtos que constem no estoque devem ser mostrados na área correta, tal como produtos que não estejam em estoque devem ser mostrados na devida área. Atualizações sobre produtos devem ser mostradas de maneira correta nas áreas corretas (produtos que entram em estoque e ou produtos que saem do estoque). |
|  	|  	|

