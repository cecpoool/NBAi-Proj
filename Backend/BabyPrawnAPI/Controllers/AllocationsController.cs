using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BabyPrawnAPI.Models;

namespace BabyPrawnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationsController : ControllerBase
    {
        private readonly BabyPrawnContext _context;

        public AllocationsController(BabyPrawnContext context)
        {
            _context = context;
        }

        // GET: api/Allocations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Allocation>>> GetAllocation()
        {
            return await _context.Allocation.ToListAsync();
        }

        // GET: api/Allocations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Allocation>> GetAllocation(int id)
        {
            var allocation = await _context.Allocation.FindAsync(id);

            if (allocation == null)
            {
                return NotFound();
            }

            return allocation;
        }

        // PUT: api/Allocations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAllocation(int id, Allocation allocation)
        {
            if (id != allocation.TeamId)
            {
                return BadRequest();
            }

            _context.Entry(allocation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllocationExists(id))
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

        // POST: api/Allocations
        [HttpPost]
        public async Task<ActionResult<Allocation>> PostAllocation(Allocation allocation)
        {
            _context.Allocation.Add(allocation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AllocationExists(allocation.TeamId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAllocation", new { id = allocation.TeamId }, allocation);
        }

        // DELETE: api/Allocations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Allocation>> DeleteAllocation(int id)
        {
            var allocation = await _context.Allocation.FindAsync(id);
            if (allocation == null)
            {
                return NotFound();
            }

            _context.Allocation.Remove(allocation);
            await _context.SaveChangesAsync();

            return allocation;
        }

        private bool AllocationExists(int id)
        {
            return _context.Allocation.Any(e => e.TeamId == id);
        }
    }
}
