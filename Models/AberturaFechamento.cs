using System.ComponentModel.DataAnnotations.Schema;

namespace Blood4A.Models;

public class AberturaFechamento
{
    // FK -----------------------------------------------   
    [System.ComponentModel.DataAnnotations.Key]
    public int referente_a { get; set; }
    // FK -----------------------------------------------   

    public required string Horario_Abertura { get; set; }

    public required string Horario_Fechamento { get; set; }

    public required string Dia_Da_Semana { get; set; }

    // FK -----------------------------------------------    
    [ForeignKey("referente_a")]
    public Clinicas? obj_referente_a { get; set; }
    // FK -----------------------------------------------

}
