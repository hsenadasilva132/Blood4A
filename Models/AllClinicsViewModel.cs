using Blood4A.Domain;

namespace Blood4A.Models;

public class ClinicasEstado(string Estado, string EstadoCode, Clinicas[] Clinicas)
{
    public string Estado { get; set; } = Estado;
    public string EstadoCode { get; set; } = EstadoCode;
    public Clinicas[] ListaDeClinicas { get; set; } = Clinicas;
}

public class AllClinicsViewModel(ClinicasEstado[] ClinicasEstados)
{
    public ClinicasEstado[] ClinicasEstado { get; set; } = ClinicasEstados;
}