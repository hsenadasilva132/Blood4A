using System.ComponentModel.DataAnnotations.Schema;

namespace Blood4A.Models;

public class Clinicas
{
    [System.ComponentModel.DataAnnotations.Key]
    public int id_clinica { get; set; }

    public required string Nome_Clinica { get; set; }

    public required string Cnpj_Clinica { get; set; }
    
    // FK -----------------------------------------------
    public required string cep_location { get; set; }
    
    [ForeignKey("cep_location")]
    public Localizacoes? obj_cep_location { get; set; }
    // FK -----------------------------------------------

}