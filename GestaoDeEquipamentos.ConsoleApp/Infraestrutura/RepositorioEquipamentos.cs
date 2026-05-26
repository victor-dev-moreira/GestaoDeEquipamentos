using GestaoDeEquipamentos.ConsoleApp.Dominio;
namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioEquipamentos
{
    private Equipamento[] equipamentosSalvos = new Equipamento[100];
    public int contadorIdEquipamento = 1;

    public void Cadastro(Equipamento novoEquipamento)
    {
        novoEquipamento.id = contadorIdEquipamento++;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = novoEquipamento;
                break;
            }
        }
    }

    public void Editar(int idEditar, Equipamento equipamentoAtualizado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento equipamentoEditado = equipamentosSalvos[i];

            if (equipamentoEditado == null)
                continue;

            if (equipamentoEditado.id == idEditar)
            {
                equipamentoEditado.nome = equipamentoAtualizado.nome;
                equipamentoEditado.precoAquisicao = equipamentoAtualizado.precoAquisicao;
                equipamentoEditado.dataFabricacao = equipamentoAtualizado.dataFabricacao;
                break;
            }
        }
    }

    public void Excluir(int idExcluir)
    {
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
    }

    public void Visualizar()
    {
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
    }
    public Equipamento[] SelecionarTodos()
    {
        return equipamentosSalvos;
    }

}