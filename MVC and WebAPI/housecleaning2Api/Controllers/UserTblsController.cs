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
    public class UserTblsController : ControllerBase
    {
        private readonly housecleaning1Context _context;

        public UserTblsController(housecleaning1Context context)
        {
            _context = context;
        }

        // GET: api/UserTbls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserTbl>>> GetUserTbls()
        {
            return await _context.UserTbls.ToListAsync();
        }

        // GET: api/UserTbls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserTbl>> GetUserTbl(int id)
        {
            var userTbl = await _context.UserTbls.FindAsync(id);

            if (userTbl == null)
            {
                return NotFound();
            }

            return userTbl;
        }

        // PUT: api/UserTbls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserTbl(int id, UserTbl userTbl)
        {
            if (id != userTbl.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userTbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserTblExists(id))
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

        // POST: api/UserTbls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserTbl>> PostUserTbl(UserTbl userTbl)
        {
            _context.UserTbls.Add(userTbl);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserTblExists(userTbl.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserTbl", new { id = userTbl.UserId }, userTbl);
        }

        // DELETE: api/UserTbls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserTbl(int id)
        {
            var userTbl = await _context.UserTbls.FindAsync(id);
            if (userTbl == null)
            {
                return NotFound();
            }

            _context.UserTbls.Remove(userTbl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserTblExists(int id)
        {
            return _context.UserTbls.Any(e => e.UserId == id);
        }
    }
}
