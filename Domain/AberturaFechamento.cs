using System.ComponentModel.DataAnnotations.Schema;


namespace Blood4A.Domain;

public class AberturaFechamento
{
    // FK -----------------------------------------------   
    [System.ComponentModel.DataAnnotations.Key]
    public int referente_a { get; set; }
    // FK -----------------------------------------------   

    public required string horario_abertura { get; set; }

    public required string horario_fechamento { get; set; }

    public required string dia_da_semana { get; set; }

    // FK -----------------------------------------------    
    [ForeignKey("referente_a")]
    public Clinicas? obj_referente_a { get; set; }
    // FK -----------------------------------------------

}
