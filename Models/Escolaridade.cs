namespace Blood4A.Models;

public class Escolaridade
{
    [System.ComponentModel.DataAnnotations.Key]
    public int id_escolaridade { get; set; }

    public required string Grau_Escolaridade { get; set; }

    public required string Descricao_Escolaridade { get; set; }

}