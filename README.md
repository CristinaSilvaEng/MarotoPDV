```
 __  __                 _          _____  _______      __
 |  \/  |               | |        |  __ \|  __ \ \    / /
 | \  / | __ _ _ __ ___ | |_ ___   | |__) | |  | \ \  / / 
 | |\/| |/ _` | '__/ _ \| __/ _ \  |  ___/| |  | |\ \/ /  
 | |  | | (_| | | | (_) | || (_) | | |    | |__| | \  /   
 |_|  |_|\__,_|_|  \___/ \__\___/  |_|    |_____/   \/    
```

Laboratório de Programação (.NET I) - Professor André Barcelos

--


**O aluno deverá desenvolver um sistema simples de controle de estoque e vendas para um estabelecimento comercial**. **Um vídeo explicando o funcionamento e os trechos de código deve ser gravado, com duração máxima de 5min.** O link para acessar o vídeo (no google drive, mega, dropbox, etc) deve ser disponibilizado em um arquivo de texto, juntamente com o diretório da Solution e do projeto criado.


O sistema deve ser feito para atender o seguinte cenário:

Uma loja comercial estoca e vende *PRODUTOS*, essas *VENDAS* são realizadas por um *OPERADOR*. Uma venda pode conter uma coleção de *PRODUTOS* (*ITENS DE VENDA*), estes *ITENS DE VENDA* devem subtrair a quantidade em estoque somente quando a venda for finalizada. Toda *VENDA* será atrelada a um *OPERADOR* que por sua vez deve estar cadastrado para realizar login e poder operar as *VENDAS*. Os *PRODUTOS* poderão ser criados, editados ou excluídos por *OPERADORES* do tipo 0.

--


Os **OPERADORES** possuem as seguintes características:
ID
SENHA
TIPO (pode assumir 0, 1 ou 2)
NOME
ENDEREÇO
TELEFONE

Os **PRODUTOS** possuem as seguintes características:
CÓD (Código de Barras)
DESCRIÇÃO
FORNECEDOR
DATA DE VALIDADE
QUANTIDADE EM ESTOQUE (Pode assumir valores negativos, mas deve ser alertado ao OPERADOR quando fechar a compra)
PREÇO DE COMPRA (Preço que a loja compra do fornecedor)
PREÇO DE VENDA (Preço que o consumidor final paga)

As **VENDAS** possuem as seguintes características:
COD (Numero da nota)
PRODUTOS[] (Coleção de produtos)
PREÇO VENDA (Soma dos preços dos itens de venda (coleção de produtos))
COD OPERADOR
DATA
HORA

PS: Vocês deverão abstrair mais uma entidade implícita (para resolver o problema das VENDAS). Isso será natural ao longo do desenvolvimento do sistema, não se preocupem tão previamente. =]

--


O aluno ficará livre para abstrair o cenário, incluir ou modificar funções, assim e também realizar o design do formulário (arranjo dos controles gráficos). O sistema deve realizar no mínimo, as seguintes funções e ter os seguintes formulários:

--

**FORMULÁRIO 1**

LOGIN DE USUARIO (Simular um login, não precisa implementar segurança com sessão e etc. É só uma tela que verifica se o ID e a SENHA estão ok). A partir desse momento, as vendas que forem realizadas, levarão o ID do OPERADOR que estiver logado.



**FORMULÁRIO 2 (Principal)**

GERAR VENDA (Realizar a venda normalmente pela tela principal. Isso pode ser feito por um Button ou Evento de UP para teclas F1, F2...etc. No formulário principal)
CANCELAR VENDA EM ANDAMENTO (A venda que está na tela para ser fechada (gerada) poderá ser cancelada antes do fechamento. Isso também pode ser feito por um Button ou Evento de UP para teclas F1, F2...etc)
LOGOUT do OPERADOR (voltar para a tela de Login e esperar para um novo usuário. pode ser feito por um Button ou Evento de UP para teclas F1, F2...etc)



**FORMULÁRIO 3  (Pode ser dividido em mais de um Formulário)**

CADASTRAR, EDITAR, DELETAR OPERADOR



**FORMULÁRIO 4  (Pode ser dividido em mais de um Formulário)**

CADASTRAR, EDITAR, DELETAR PRODUTOS
