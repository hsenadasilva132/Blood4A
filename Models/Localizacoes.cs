namespace Blood4A.Models;

public class Localizacoes
{
    [System.ComponentModel.DataAnnotations.Key]
    public required string cep { get; set; }

    public required string Logradouro { get; set; }

    public required string Bairro { get; set; }

    public required string Cidade { get; set; }

    public required string Estado { get; set; }
    
    public required int Uf { get; set; }

}
