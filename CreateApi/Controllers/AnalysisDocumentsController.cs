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
    public class AnalysisDocumentsController : ControllerBase
    {
        private readonly pract10Context _context;

        public AnalysisDocumentsController(pract10Context context)
        {
            _context = context;
        }

        // GET: api/AnalysisDocuments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnalysisDocument>>> GetAnalysisDocuments()
        {
          if (_context.AnalysisDocuments == null)
          {
              return NotFound();
          }
            return await _context.AnalysisDocuments.ToListAsync();
        }

        // GET: api/AnalysisDocuments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnalysisDocument>> GetAnalysisDocument(int id)
        {
          if (_context.AnalysisDocuments == null)
          {
              return NotFound();
          }
            var analysisDocument = await _context.AnalysisDocuments.FindAsync(id);

            if (analysisDocument == null)
            {
                return NotFound();
            }

            return analysisDocument;
        }

        // PUT: api/AnalysisDocuments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnalysisDocument(int id, AnalysisDocument analysisDocument)
        {
            if (id != analysisDocument.IdAnalysisDocument)
            {
                return BadRequest();
            }

            _context.Entry(analysisDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnalysisDocumentExists(id))
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

        // POST: api/AnalysisDocuments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnalysisDocument>> PostAnalysisDocument(AnalysisDocument analysisDocument)
        {
          if (_context.AnalysisDocuments == null)
          {
              return Problem("Entity set 'pract10Context.AnalysisDocuments'  is null.");
          }
            _context.AnalysisDocuments.Add(analysisDocument);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnalysisDocument", new { id = analysisDocument.IdAnalysisDocument }, analysisDocument);
        }

        // DELETE: api/AnalysisDocuments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnalysisDocument(int id)
        {
            if (_context.AnalysisDocuments == null)
            {
                return NotFound();
            }
            var analysisDocument = await _context.AnalysisDocuments.FindAsync(id);
            if (analysisDocument == null)
            {
                return NotFound();
            }

            _context.AnalysisDocuments.Remove(analysisDocument);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnalysisDocumentExists(int id)
        {
            return (_context.AnalysisDocuments?.Any(e => e.IdAnalysisDocument == id)).GetValueOrDefault();
        }
    }
}
