
using byteBnak_ADM.Funcionarios;
using byteBnak_ADM.SistemaInterno;
using byteBnak_ADM.utilitarios;

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao ()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao ();

    Designer pedro = new Designer("833.432.234-02");
    pedro.Nome = "Pedro";

    Desenvolverdor samya = new Desenvolverdor("213.453.234-21");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("432.543.134-09");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("324.543.212-73");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("123.421.234-82");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(samya);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de bonificação " + gerenciador.Bonificacao());

}

void UsarSistema ()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("123.532.423-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "223";

    GerenteDeContas ursula = new GerenteDeContas("342.321.345-64");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    sistemaInterno.Logar(roberta, "223");
    sistemaInterno.Logar(ursula, "321");

}