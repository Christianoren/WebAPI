using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CCandidateController : ControllerBase
    {
        private readonly CurriculumDBcontext _context;

        public CCandidateController(CurriculumDBcontext context)
        {
            _context = context;
        }

        // GET: api/CCandidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CCandidate>>> GetCCandidates()
        {
            return await _context.CCandidates.Include(c => c.
            Adresse).ToListAsync();
        }

        // GET: api/CCandidate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CCandidate>> GetCCandidate(int id)
        {
            var cCandidate = await _context.CCandidates.FindAsync(id);

            if (cCandidate == null)
            {
                return NotFound();
            }

            return cCandidate;
        }

        // PUT: api/CCandidate/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCCandidate(int id, CCandidate cCandidate)
        {
            cCandidate.id = id;

            _context.Entry(cCandidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CCandidateExists(id))
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

        // POST: api/CCandidate
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CCandidate>> PostCCandidate(CCandidate cCandidate)
        {
            _context.CCandidates.Add(cCandidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCCandidate", new { id = cCandidate.id }, cCandidate);
        }

        // DELETE: api/CCandidate/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CCandidate>> DeleteCCandidate(int id)
        {
            var cCandidate = await _context.CCandidates.FindAsync(id);
            if (cCandidate == null)
            {
                return NotFound();
            }

            _context.CCandidates.Remove(cCandidate);
            await _context.SaveChangesAsync();

            return cCandidate;
        }

        private bool CCandidateExists(int id)
        {
            return _context.CCandidates.Any(e => e.id == id);
        }
    }
}
