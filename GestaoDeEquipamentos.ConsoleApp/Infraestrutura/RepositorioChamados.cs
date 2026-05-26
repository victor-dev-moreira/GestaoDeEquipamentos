namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

using GestaoDeEquipamentos.ConsoleApp.Dominio;
public class RepostiorioChamados
{
    private Chamados[] chamadosSalvos = new Chamados[100];
    public int contadorIdChamado = 1;

    public void Cadastro(Chamados novoChamado)
    {
        for (int i = 0; i < chamadosSalvos.Length; i++)
        {
            if (chamadosSalvos == null)
            {
                continue;
            }

            chamadosSalvos[i] = novoChamado;
            break;
        }
    }

    public Chamados[] SelecionarTodos()
    {
        return chamadosSalvos;
    }

}