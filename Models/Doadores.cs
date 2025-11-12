using System.ComponentModel.DataAnnotations.Schema;

namespace Blood4A.Models;

public class Doadores
{
    [System.ComponentModel.DataAnnotations.Key]
    public int id_doador { get; set; }

    public required string Nome_Doador { get; set; }

    public required string Data_Nascimento_Doador { get; set; }

    public required string Cpf_Doador { get; set; }

    public required string Telefone_Doador { get; set; }

    public required string Tipo_Sanguineo_Doador { get; set; }

    // FK -----------------------------------------------
    public required string cep_location { get; set; }

    public required int id_escolaridade { get; set; }

    [ForeignKey("cep_location")]
    public Localizacoes? obj_cep_location { get; set; }

    [ForeignKey("id_escolaridade")]
    public Escolaridade? obj_id_escolaridade { get; set; }
    // FK -----------------------------------------------


}