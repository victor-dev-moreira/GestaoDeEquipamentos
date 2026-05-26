namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class MenuChamado()
{
    public RepostiorioChamados repositorioChamados = new RepostiorioChamados();
    public RepositorioEquipamentos repositorioEquipamentos = new RepositorioEquipamentos();
    public string ObeterMenuChamado()
    {
        //Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Abrir Chamado");
        Console.WriteLine("2 - Editar Chamado");
        Console.WriteLine("3 - Excluir Chamado");
        Console.WriteLine("4 - Visualizar Chamado");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenuChamado = Console.ReadLine()?.ToUpper();

        return opcaoMenuChamado;
    }

    public void Cadastro()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Abrir Chamado");
        Console.WriteLine("---------------------------------");

        Console.Write("Qual o titulo do chamado? ");
        string? tituloChamado = Console.ReadLine();
        Console.WriteLine("---------------------------------");

        Console.Write("Qual a descricão do chamado? ");
        string? descricaoChamado = Console.ReadLine();

        Console.WriteLine("---------------------------------");

        DateTime dataAbertura = DateTime.Now;

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Visulizar Equipamentos");
        Console.WriteLine("---------------------------------");

        Equipamento[] equipamentosSalvos = repositorioEquipamentos.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
        );

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao.ToShortDateString()
        );
        }

        Console.Write("Qual item você deseja abrir o chamado? ");
        int idEquipamentoChamado = int.Parse(Console.ReadLine());

        Equipamento equipamentoSelecionado = null;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento eq = equipamentosSalvos[i];

            if (eq == null)
                continue;

            if (eq.id == idEquipamentoChamado)
            {
                equipamentoSelecionado = eq;
                break;
            }
        }

        Chamados novoChamado = new Chamados();
        novoChamado.titulo = tituloChamado;
        novoChamado.descricao = descricaoChamado;
        novoChamado.dataAbertura = dataAbertura;
        novoChamado.equipamento = equipamentoSelecionado;

        repositorioChamados.Cadastro(novoChamado);

        Console.WriteLine("Chamado aberto com sucesso!");
        Console.ReadLine();
    }

    public void Editar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Editar Chamado");
        Console.WriteLine("---------------------------------");

        Chamados[] chamadosSalvos = repositorioChamados.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -15} | {4, -15}",
            "Id", "Titulo", "Descricao", "Data de Abertura", "Equipamento"
        );
        for (int i = 0; i < chamadosSalvos.Length; i++)
        {
            Chamados ch = chamadosSalvos[i];

            if (ch == null)
                continue;

            Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -15} | {4, -15}",
            ch.id, ch.titulo, ch.descricao, ch.dataAbertura.ToShortDateString(), ch.equipamento.nome
        );
        }
        Console.WriteLine("---------------------------------");
        Console.Write("Qual o ID do equipamento que deseja editar? ");
        int idChamadoEditar = int.Parse(Console.ReadLine());

        Console.WriteLine("---------------------------------");
        Console.Write("Nome do chamado? ");
        string? novoTituloChamado = Console.ReadLine();

        Console.WriteLine("---------------------------------");
        Console.Write("Descricão do chamado? ");
        string? novaDescricaoChamado = Console.ReadLine();

        for (int i = 0; i < chamadosSalvos.Length; i++)
        {
            Chamados ch = chamadosSalvos[i];

            if (ch == null)
                continue;

            if (ch.id == idChamadoEditar)
            {
                ch.titulo = novoTituloChamado;
                ch.descricao = novaDescricaoChamado;
            }

            Console.WriteLine($"Chamado Id{ch.id} editado com sucesso!");
        }

        Console.WriteLine("Pressione enter para seguir...");
        Console.ReadLine();
    }

    public void Excluir()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Excluir Chamado");
        Console.WriteLine("---------------------------------");

        Chamados[] chamadosSalvos = repositorioChamados.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -15} | {4, -15}",
            "Id", "Titulo", "Descricao", "Data de Abertura", "Equipamento"
        );
        for (int i = 0; i < chamadosSalvos.Length; i++)
        {
            Chamados ch = chamadosSalvos[i];

            if (ch == null)
                continue;

            Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -15} | {4, -15}",
            ch.id, ch.titulo, ch.descricao, ch.dataAbertura.ToShortDateString(), ch.equipamento.nome
        );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Qual o ID do equipamento que deseja excluir? ");
        int idChamadoExcluir = int.Parse(Console.ReadLine());

        for (int i = 0; i < chamadosSalvos.Length; i++)
        {
            Chamados ch = chamadosSalvos[i];

            if (ch == null)
                continue;

            if (ch.id == idChamadoExcluir)
            {
                chamadosSalvos[i] = null;
            }
            Console.WriteLine($"Chamado Id {ch.id} excluido com sucesso!");
        }

        Console.WriteLine("Pressione enter para seguir...");
        Console.ReadLine();
    }

    public void Visualizar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Visulizar Chamados");
        Console.WriteLine("---------------------------------");

        Chamados[] chamadosSalvos = repositorioChamados.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -15} | {4, -15}",
            "Id", "Titulo", "Descricao", "Data de Abertura", "Equipamento"
        );
        for (int i = 0; i < chamadosSalvos.Length; i++)
        {
            Chamados ch = chamadosSalvos[i];

            if (ch == null)
                continue;

            Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -15} | {4, -15}",
            ch.id, ch.titulo, ch.descricao, ch.dataAbertura.ToShortDateString(), ch.equipamento.nome
        );
        }

        Console.ReadLine();
    }
}