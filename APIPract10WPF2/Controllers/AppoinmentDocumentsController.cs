using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIPract10WPF2.Models;

namespace APIPract10WPF2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppoinmentDocumentsController : ControllerBase
    {
        private readonly Pract10WpfDbContext _context;

        public AppoinmentDocumentsController(Pract10WpfDbContext context)
        {
            _context = context;
        }

        // GET: api/AppoinmentDocuments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppoinmentDocument>>> GetAppoinmentDocuments()
        {
            return await _context.AppoinmentDocuments.ToListAsync();
        }

        // GET: api/AppoinmentDocuments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppoinmentDocument>> GetAppoinmentDocument(int id)
        {
            var appoinmentDocument = await _context.AppoinmentDocuments.FindAsync(id);

            if (appoinmentDocument == null)
            {
                return NotFound();
            }

            return appoinmentDocument;
        }

        // PUT: api/AppoinmentDocuments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppoinmentDocument(int id, AppoinmentDocument appoinmentDocument)
        {
            if (id != appoinmentDocument.IdAppoinmentDocument)
            {
                return BadRequest();
            }

            _context.Entry(appoinmentDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppoinmentDocumentExists(id))
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

        // POST: api/AppoinmentDocuments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppoinmentDocument>> PostAppoinmentDocument(AppoinmentDocument appoinmentDocument)
        {
            _context.AppoinmentDocuments.Add(appoinmentDocument);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AppoinmentDocumentExists(appoinmentDocument.IdAppoinmentDocument))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAppoinmentDocument", new { id = appoinmentDocument.IdAppoinmentDocument }, appoinmentDocument);
        }

        // DELETE: api/AppoinmentDocuments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppoinmentDocument(int id)
        {
            var appoinmentDocument = await _context.AppoinmentDocuments.FindAsync(id);
            if (appoinmentDocument == null)
            {
                return NotFound();
            }

            _context.AppoinmentDocuments.Remove(appoinmentDocument);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppoinmentDocumentExists(int id)
        {
            return _context.AppoinmentDocuments.Any(e => e.IdAppoinmentDocument == id);
        }
    }
}
