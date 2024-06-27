using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CreateApi.Models;

namespace CreateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly pract10Context _context;

        public PatientsController(pract10Context context)
        {
            _context = context;
        }

        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
          if (_context.Patients == null)
          {
              return NotFound();
          }
            return await _context.Patients.ToListAsync();
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(long id)
        {
          if (_context.Patients == null)
          {
              return NotFound();
          }
            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(long id, Patient patient)
        {
            if (id != patient.IdOms)
            {
                return BadRequest();
            }

            _context.Entry(patient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostPatient([FromBody] Patient patient)
        {
            if (_context.Patients == null)
            {
                return Problem("Entity set 'pract10Context.Patients'  is null.");
            }

            var existingPatient = await _context.Patients.FirstOrDefaultAsync(p => p.IdOms == patient.IdOms);

            if (existingPatient != null)
            {
                return Ok(new { Success = true });
            }
            else
            {
                return NotFound(new { Success = false });
            }
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(long id)
        {
            if (_context.Patients == null)
            {
                return NotFound();
            }
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        

        private bool PatientExists(long id)
        {
            return (_context.Patients?.Any(e => e.IdOms == id)).GetValueOrDefault();
        }
    }
}
