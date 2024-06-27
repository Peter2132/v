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
    public class AdminnsController : ControllerBase
    {
        private readonly pract10Context _context;

        public AdminnsController(pract10Context context)
        {
            _context = context;
        }

        // GET: api/Adminns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adminn>>> GetAdminns()
        {
            if (_context.Adminns == null)
            {
                return NotFound();
            }
            return await _context.Adminns.ToListAsync();
        }

        // GET: api/Adminns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adminn>> GetAdminn(int id)
        {
            if (_context.Adminns == null)
            {
                return NotFound();
            }
            var adminn = await _context.Adminns.FindAsync(id);

            if (adminn == null)
            {
                return NotFound();
            }

            return adminn;
        }

        // PUT: api/Adminns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdminn(int id, Adminn adminn)
        {
            if (id != adminn.IdAdmin)
            {
                return BadRequest();
            }

            _context.Entry(adminn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminnExists(id))
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

        // POST: api/Adminns
        [HttpPost]
        public async Task<ActionResult<Adminn>> PostAdminn(Adminn adminn)
        {
            if (_context.Adminns == null)
            {
                return Problem("Entity set 'pract10Context.Adminns' is null.");
            }
            _context.Adminns.Add(adminn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdminn", new { id = adminn.IdAdmin }, adminn);
        }

        // DELETE: api/Adminns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminn(int id)
        {
            if (_context.Adminns == null)
            {
                return NotFound();
            }
            var adminn = await _context.Adminns.FindAsync(id);
            if (adminn == null)
            {
                return NotFound();
            }

            _context.Adminns.Remove(adminn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Новый метод для проверки пользователя
        [HttpPost("validate")]
        public async Task<ActionResult<bool>> ValidateUser([FromBody] Adminn user)
        {
            if (_context.Adminns == null)
            {
                return NotFound();
            }
            var adminn = await _context.Adminns
                .FirstOrDefaultAsync(a => a.IdAdmin == user.IdAdmin && a.PasswordHash == user.PasswordHash);

            if (adminn == null)
            {
                return Ok(false);
            }

            return Ok(true);
        }

        private bool AdminnExists(int id)
        {
            return _context.Adminns?.Any(e => e.IdAdmin == id) ?? false;
        }
    }
}