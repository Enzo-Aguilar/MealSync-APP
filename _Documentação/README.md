Hallo!!!

Yo, se vcs estão lendo isso é porque provalvemente eu pedi kkkk mas enfim, 
vamos ao que interessa, fiz este ficheiro markdown pra facilitar a nossa 
leitura e organização do projeto.Deixei um guia so pra dar aquela ajuda
(Tambem serve de desculpa se não quiser fazer nada)

1º - Cada ficheiro tem quatro grandes partes:

	- Load do Form
		Onde os metodos de limpeza normalmente são executados
	
	- Métodos dos componentes graficos
		Aqui temos o retorno dos métodos auxiliares,
		por norma evito ao máximo colocar código complexo aqui
		pois já esta muito perto do utilizador.

	- Métodos auxiliares
		Aqui é onde a maior parte do código complexo fica, 
		normalmente cada método faz apenas uma coisa, porem se perceberem 
		que um método tem mais de uma função, ou seja, tem mais de um motivo para ser chamado
		por favor me avisem.

	- Métodos de chamada para outros forms
		Por puro perfecionismo, prefiri criar métodos so pra chamar
		outros forms, assim reduz as linhas em métodos de componentes graficos, e também facilita a leitura,


2º - Padronização da nomenclatura:
	
	- Métodos de componentes graficos
		com a primeira letra pequena, por ex: btnSalvar_Click()

	- Métodos auxiliares
		com a primeira letra maiuscula, por ex: LimparCampos()
	
	- Variáveis
		com a primeira letra minúscula, por ex: string nomeCompleto

3º - Organização por ordem alfabética:
	
	- Por norma tudo esta organizado por ordem alfabética, ou seja, 
	os métodos estão organizados por ordem alfabética, as variáveis também, 
	isso facilita a leitura e a procura de métodos ou variáveis específicas,
	porem os ID's do que for sempre fica em primeiro.
	Por Exemplo:
		- ID
		- A
		- B
		.
		.
		.

4º - Atenção!!!

	- DAL 
		Não a necessidade de mexer aqui...
	
	-BLL 
		Como combinamos antes, provavelmente voces não vão precisar mexer aqui,
		porem se mexerem, reparem que a BLL e a DAL não contém logica alguma
		pois são apenas camadas de negocio e acesso a base de dados respectivamente
		dito isto, o que chega pra BLL deve já estar devidamente validado já pronto 
		pra enviar pra DAL e executar o que for pedido.



































Por fim, queria escrever que é um prazer trabalhar convosco, e que se eu for muito chato avisem kkk

//Métodos Auxiliares
        private void Is_Admin()
        {
            if (Globais.Utilizador.funcao != "administrador")
            {
                //Esconder opções de admin

                //Refeições
                adicionar_Refeicoes.Visible = false;
                editar_Refeicoes.Visible = false;
                remover_Refeicoes.Visible = false;

                //Aluno, Funcionário, Administrador
                Alunos.Visible = false;
                Funcionarios.Visible = false;
                Administradores.Visible = false;
            }
        }