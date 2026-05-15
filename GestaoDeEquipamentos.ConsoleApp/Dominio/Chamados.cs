using System;

/*
• Deve ter um identificador único (id);
• Deve ter a título do chamado;
• Deve ter a descrição do chamado;
• Deve ter um equipamento;
• Deve ter uma data de abertura;

*/

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Chamados
{
    public int id;
    public string titulo;
    public string descricao;
    public DateTime dataAbertura;
    public Equipamento equipamento;
}
