using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;
namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class MenuEquipamento
{

    public RepositorioEquipamentos repositorioEquipamentos;
    public string ObterMenuEquipamento()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar equipamento");
        Console.WriteLine("2 - Editar equipamento");
        Console.WriteLine("3 - Excluir equipamento");
        Console.WriteLine("4 - Visualizar equipamentos");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }

    public void Cadastro()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Equipamentos");
        Console.WriteLine("---------------------------------");

        Console.Write("Qual nome do equipamento? ");
        string? nome = Console.ReadLine();
        Console.WriteLine("---------------------------------");

        Console.Write("Qual preco de aquisicão? ");
        decimal precoAquisicao = decimal.Parse(Console.ReadLine());

        Console.WriteLine("---------------------------------");
        Console.Write("Digite a data de fabricação do equipamento: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        Equipamento equipamento = new Equipamento();

        equipamento.nome = nome;
        equipamento.dataFabricacao = dataFabricacao;
        equipamento.precoAquisicao = precoAquisicao;

        repositorioEquipamentos.Cadastro(equipamento);

        Console.WriteLine($"O Equipamento {equipamento.nome} cadastrado com sucesso!");
        Console.ReadLine();
    }

    public void Editar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Edicão de Equipamentos");
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
        Console.Write("Qual SKU deseja editar? ");
        int idEditar = int.Parse(Console.ReadLine());


        Console.Write("Qual nome do equipamento? ");
        string nome = Console.ReadLine();
        Console.WriteLine("---------------------------------");

        Console.Write("Qual preco de aquisicão? ");
        decimal precoAquisicao = decimal.Parse(Console.ReadLine());

        Console.WriteLine("---------------------------------");
        Console.Write("Digite a data de fabricação do equipamento: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        Equipamento equipamentoAtualizado = new Equipamento();
        equipamentoAtualizado.nome = nome;
        equipamentoAtualizado.precoAquisicao = precoAquisicao;
        equipamentoAtualizado.dataFabricacao = dataFabricacao;

        repositorioEquipamentos.Editar(idEditar, equipamentoAtualizado);

        Console.WriteLine("Equipamento editado com sucesso!");
        Console.ReadLine();
    }

    public void Excluir()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Excluir de Equipamentos");
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

        Console.Write("Qual Id do equipamento que deseja excluir? ");
        int idExcluir = int.Parse(Console.ReadLine());

        repositorioEquipamentos.Excluir(idExcluir);

        Console.WriteLine("Equipamento excluido com sucesso!");
        Console.ReadLine();
    }

    public void Visualizar()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Visulizar Equipamentos");
        Console.WriteLine("---------------------------------");

        Equipamento[] equipamentosSalvos = repositorioEquipamentos.SelecionarTodos();

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
        );

        repositorioEquipamentos.Visualizar();
        Console.ReadLine();
    }

}