using GestaoDeEquipamentos.ConsoleApp.Dominio;

DateTime dataAgora = DateTime.Now; // data de agora
Equipamento[] equipamentosSalvos = new Equipamento[100];
int contadorSku = 1;

while (true)
{
    // Console.Clear();
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

    if (opcaoMenu == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenu == "1")
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Equipamentos");
        Console.WriteLine("---------------------------------");
        Console.Write("Qual nome do equipamento? ");
        string nome = Console.ReadLine();
        Console.WriteLine("---------------------------------");

        Console.Write("Qual preco de aquisicão? ");
        decimal precoAquisicao = decimal.Parse(Console.ReadLine());

        Console.WriteLine("---------------------------------");
        Console.Write("Digite a data de fabricação do equipamento: ");
        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

        Equipamento equipamento = new Equipamento();

        equipamento.id = contadorSku++;
        equipamento.nome = nome;
        equipamento.dataFabricacao = dataFabricacao;
        equipamento.precoAquisicao = precoAquisicao;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = equipamento;
                break;
            }
        }
        Console.WriteLine($"O Equipamento {equipamento.nome} cadastrado com sucesso!");
        Console.ReadLine();
    }
    else if (opcaoMenu == "2")
    {
    }
    else if (opcaoMenu == "3")
    {
    }
    else if (opcaoMenu == "4")
    {
    }
}