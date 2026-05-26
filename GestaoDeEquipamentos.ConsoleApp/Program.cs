using GestaoDeEquipamentos.ConsoleApp.Apresentacao;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;


DateTime dataAgora = DateTime.Now; // data de agora

RepositorioEquipamentos repositorioEquipamentos = new RepositorioEquipamentos();
RepostiorioChamados repostiorioChamados = new RepostiorioChamados();

TelaPrincipal telaPrincipal = new TelaPrincipal();

MenuEquipamento menuEquipamento = new MenuEquipamento();
menuEquipamento.repositorioEquipamentos = repositorioEquipamentos;

MenuChamado menuChamado = new MenuChamado();
menuChamado.repositorioChamados = repostiorioChamados;
menuChamado.repositorioEquipamentos = repositorioEquipamentos;

while (true)
{

    string? opcaoMenuPrincipal = telaPrincipal.MenuPrincipal();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenuPrincipal == "1")
    {
        while (true)
        {
            string? opcaoMenu = menuEquipamento.ObterMenuEquipamento();

            if (opcaoMenu == "S")
            {
                //Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
            {
                menuEquipamento.Cadastro();
            }
            else if (opcaoMenu == "2")
            {
                menuEquipamento.Editar();
            }
            else if (opcaoMenu == "3")
            {
                menuEquipamento.Excluir();
            }
            else if (opcaoMenu == "4")
            {
                menuEquipamento.Visualizar();
            }
        }
    }

    else if (opcaoMenuPrincipal == "2")
    {
        string opcaoMenuChamado = menuChamado.ObeterMenuChamado();

        if (opcaoMenuChamado == "S")
        {
            Console.Clear();
            break;
        }

        if (opcaoMenuChamado == "1")
        {
            menuChamado.Cadastro();
        }
        else if (opcaoMenuChamado == "2")
        {
            menuChamado.Editar();
        }
        else if (opcaoMenuChamado == "3")
        {
            menuChamado.Excluir();
        }
        else if (opcaoMenuChamado == "4")
        {
            menuChamado.Visualizar();
        }
    }
}