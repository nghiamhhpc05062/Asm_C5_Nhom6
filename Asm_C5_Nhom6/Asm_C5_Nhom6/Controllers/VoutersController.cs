using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoutersController : ControllerBase
    {
        private readonly AppDbcontext _context;

        public VoutersController(AppDbcontext context)
        {
            _context = context;
        }

        // GET: api/Vouters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vouter>>> GetVouters()
        {
            return await _context.Vouters.ToListAsync();
        }

        // GET: api/Vouters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vouter>> GetVouter(int id)
        {
            var vouter = await _context.Vouters.FindAsync(id);

            if (vouter == null)
            {
                return NotFound();
            }

            return vouter;
        }

        // PUT: api/Vouters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVouter(int id, Vouter vouter)
        {
            if (id != vouter.VouterId)
            {
                return BadRequest();
            }

            _context.Entry(vouter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VouterExists(id))
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

        // POST: api/Vouters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vouter>> PostVouter(Vouter vouter)
        {
            _context.Vouters.Add(vouter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVouter", new { id = vouter.VouterId }, vouter);
        }

        // DELETE: api/Vouters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVouter(int id)
        {
            var vouter = await _context.Vouters.FindAsync(id);
            if (vouter == null)
            {
                return NotFound();
            }

            _context.Vouters.Remove(vouter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VouterExists(int id)
        {
            return _context.Vouters.Any(e => e.VouterId == id);
        }
    }
}
