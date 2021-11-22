using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using housecleaning4Api.Models;

namespace housecleaning4Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomCostsController : ControllerBase
    {
        private readonly housecleaning4Context _context;

        public RoomCostsController(housecleaning4Context context)
        {
            _context = context;
        }

        // GET: api/RoomCosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomCost>>> GetRoomCosts()
        {
            return await _context.RoomCosts.ToListAsync();
        }

        // GET: api/RoomCosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomCost>> GetRoomCost(int id)
        {
            var roomCost = await _context.RoomCosts.FindAsync(id);

            if (roomCost == null)
            {
                return NotFound();
            }

            return roomCost;
        }

        // PUT: api/RoomCosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomCost(int id, RoomCost roomCost)
        {
            if (id != roomCost.RoomId)
            {
                return BadRequest();
            }

            _context.Entry(roomCost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomCostExists(id))
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

        // POST: api/RoomCosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoomCost>> PostRoomCost(RoomCost roomCost)
        {
            _context.RoomCosts.Add(roomCost);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RoomCostExists(roomCost.RoomId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoomCost", new { id = roomCost.RoomId }, roomCost);
        }

        // DELETE: api/RoomCosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomCost(int id)
        {
            var roomCost = await _context.RoomCosts.FindAsync(id);
            if (roomCost == null)
            {
                return NotFound();
            }

            _context.RoomCosts.Remove(roomCost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoomCostExists(int id)
        {
            return _context.RoomCosts.Any(e => e.RoomId == id);
        }
    }
}
