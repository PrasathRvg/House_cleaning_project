using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using housecleaning2Api.Models;

namespace housecleaning2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomcostsController : ControllerBase
    {
        private readonly housecleaning1Context _context;

        public RoomcostsController(housecleaning1Context context)
        {
            _context = context;
        }

        // GET: api/Roomcosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roomcost>>> GetRoomcosts()
        {
            return await _context.Roomcosts.ToListAsync();
        }

        // GET: api/Roomcosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Roomcost>> GetRoomcost(int id)
        {
            var roomcost = await _context.Roomcosts.FindAsync(id);

            if (roomcost == null)
            {
                return NotFound();
            }

            return roomcost;
        }

        // PUT: api/Roomcosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomcost(int id, Roomcost roomcost)
        {
            if (id != roomcost.RoomId)
            {
                return BadRequest();
            }

            _context.Entry(roomcost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomcostExists(id))
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

        // POST: api/Roomcosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Roomcost>> PostRoomcost(Roomcost roomcost)
        {
            _context.Roomcosts.Add(roomcost);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RoomcostExists(roomcost.RoomId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoomcost", new { id = roomcost.RoomId }, roomcost);
        }

        // DELETE: api/Roomcosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomcost(int id)
        {
            var roomcost = await _context.Roomcosts.FindAsync(id);
            if (roomcost == null)
            {
                return NotFound();
            }

            _context.Roomcosts.Remove(roomcost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoomcostExists(int id)
        {
            return _context.Roomcosts.Any(e => e.RoomId == id);
        }
    }
}
