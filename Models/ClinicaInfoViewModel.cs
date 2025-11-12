using Blood4A.Data;

namespace Blood4A.Models;

public class ClinicaInfoViewModel
{

    public Clinicas clinica { get; set; }
    public AberturaFechamento[] horarios { get; set; }

    public ClinicaInfoViewModel(Clinicas clinica, AberturaFechamento[] horarios)
    {
        this.clinica = clinica;
        this.horarios = horarios;
    }

}