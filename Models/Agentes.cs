namespace Blood4A.Models;

public class Agentes
{
    [System.ComponentModel.DataAnnotations.Key]
    public int id_agente { get; set; }

    public required string Nome_Agente { get; set; }

    public required string Cnpj_Agente { get; set; }

    public required string Email_Agente { get; set; }
    
    public required string Senha_Agente { get; set; }

}