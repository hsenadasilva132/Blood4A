using Blood4A.Data;
using Blood4A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blood4A.Controllers;

[ApiController] 
[Route("api/info")]
public class InfoController : ControllerBase
{
    private readonly ApplicationDbContext _db;

    public InfoController(ApplicationDbContext db)
    {
        _db = db;
    }


    [HttpGet("clinic_data/{clinic_id}")]
    public async Task<IActionResult> GetClinicData(int clinic_id)
    {
        Clinicas? specific_clinic = await _db.Clinicas
            .Include(clinic => clinic.obj_cep_location)
            .FirstOrDefaultAsync(entity => entity.id_clinica == clinic_id);

        if (specific_clinic == null)
        {
            return NotFound(new { message = $"Clínica com ID {clinic_id} não encontrada." });
        }

        var horarios = await _db.AberturaFechamento
            .Include(horario => horario.obj_referente_a)
            .Where(entity => entity.referente_a == specific_clinic.id_clinica)
            .ToArrayAsync();

        var model = new ClinicaInfoViewModel(specific_clinic, horarios);
        
        return Ok(model);
    }

    [HttpGet("clinic_donations/{clinic_id}")]
    public async Task<IActionResult> GetClinicDonations(int clinic_id)
    {
        Doacoes[] doacoes = await _db.Doacoes
            .Include(doacao => doacao.obj_id_agente)
            .Include(doacao => doacao.obj_id_clinica)
            .Include(doacao => doacao.obj_id_doador)
            .Where(entity => entity.id_clinica == clinic_id)
            .ToArrayAsync();

        if (doacoes.Length == 0)
        {
            return NotFound(new { message = "Not possible to locate donations for the specified ID" });
        }

        return Ok(doacoes);
    }

}