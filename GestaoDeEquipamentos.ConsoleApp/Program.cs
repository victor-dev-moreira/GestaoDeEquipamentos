using GestaoDeEquipamentos.ConsoleApp.Apresentacao;
using GestaoDeEquipamentos.ConsoleApp.Dominio;


DateTime dataAgora = DateTime.Now; // data de agora
Equipamento[] equipamentosSalvos = new Equipamento[100];
int contadorIdEquipamento = 1;

Chamados[] chamadosSalvos = new Chamados[100];
int contadorIdChamado = 1;

TelaPrincipal telaPrincipal = new TelaPrincipal();

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
                string? nome = Console.ReadLine();
                Console.WriteLine("---------------------------------");

                Console.Write("Qual preco de aquisicão? ");
                decimal precoAquisicao = decimal.Parse(Console.ReadLine());

                Console.WriteLine("---------------------------------");
                Console.Write("Digite a data de fabricação do equipamento: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                Equipamento equipamento = new Equipamento();

                equipamento.id = contadorIdEquipamento++;
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
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Edicão de Equipamentos");
                Console.WriteLine("---------------------------------");
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

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoEditado = equipamentosSalvos[i];

                    if (equipamentoEditado == null)
                        continue;

                    if (equipamentoEditado.id == idEditar)
                    {
                        equipamentoEditado.nome = nome;
                        equipamentoEditado.precoAquisicao = precoAquisicao;
                        equipamentoEditado.dataFabricacao = dataFabricacao;
                        break;
                    }
                }
                Console.WriteLine("Equipamento editado com sucesso!");
                Console.ReadLine();
            }
            else if (opcaoMenu == "3")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Edicão de Equipamentos");
                Console.WriteLine("---------------------------------");
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

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];
                    if (equipamentosSalvos[i] == null)
                        continue;

                    if (eq.id == idExcluir)
                    {
                        equipamentosSalvos[i] = null;
                        break;
                    }
                }
                Console.WriteLine("Equipamento excluido com sucesso!");
                Console.ReadLine();
            }
            else if (opcaoMenu == "4")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Visulizar Equipamentos");
                Console.WriteLine("---------------------------------");

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
                Console.ReadLine();
            }
        }
    }

    else if (opcaoMenuPrincipal == "2")
    {
        Console.Clear();
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

        if (opcaoMenuChamado == "S")
        {
            Console.Clear();
            break;
        }

        if (opcaoMenuChamado == "1")
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
            Console.Write("Digite a data de abertura do chamado: ");
            DateTime dataAbertura = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Visulizar Equipamentos");
            Console.WriteLine("---------------------------------");

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

            Chamados chamado = new Chamados();
            chamado.id = contadorIdChamado++;
            chamado.titulo = tituloChamado;
            chamado.descricao = descricaoChamado;
            chamado.dataAbertura = dataAbertura;
            chamado.equipamento = equipamentoSelecionado;

            for (int i = 0; i < chamadosSalvos.Length; i++)
            {
                if (chamadosSalvos == null)
                {
                    continue;
                }

                chamadosSalvos[i] = chamado;
                break;
            }

            Console.WriteLine("Chamado aberto com sucesso!");
            Console.ReadLine();
        }
        else if (opcaoMenuChamado == "2")
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Editar Chamado");
            Console.WriteLine("---------------------------------");

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
        else if (opcaoMenuChamado == "3")
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Excluir Chamado");
            Console.WriteLine("---------------------------------");

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
                Console.WriteLine($"Chamado Id{ch.id} excluido com sucesso!");
            }

            Console.WriteLine("Pressione enter para seguir...");
            Console.ReadLine();

        }
        else if (opcaoMenuChamado == "4")
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Visulizar Chamados");
            Console.WriteLine("---------------------------------");

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
}