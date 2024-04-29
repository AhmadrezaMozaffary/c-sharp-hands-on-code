using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixthCourseProject.Data.Context;
using SixthCourseProject.Models;

namespace SixthCourseProject.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendModelsController : ControllerBase
    {
        private readonly SixthDbContext _context;

        public FriendModelsController(SixthDbContext context)
        {
            _context = context;
        }

        // GET: api/FriendModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FriendModel>>> GetFriends()
        {
          if (_context.Friends == null)
          {
              return NotFound();
          }
            return await _context.Friends.ToListAsync();
        }

        // GET: api/FriendModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FriendModel>> GetFriendModel(int id)
        {
          if (_context.Friends == null)
          {
              return NotFound();
          }
            var friendModel = await _context.Friends.FindAsync(id);

            if (friendModel == null)
            {
                return NotFound();
            }

            return friendModel;
        }

        // PUT: api/FriendModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFriendModel(int id, FriendModel friendModel)
        {
            if (id != friendModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(friendModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FriendModelExists(id))
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

        // POST: api/FriendModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FriendModel>> PostFriendModel(FriendModel friendModel)
        {
          if (_context.Friends == null)
          {
              return Problem("Entity set 'SixthDbContext.Friends'  is null.");
          }
            _context.Friends.Add(friendModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFriendModel", new { id = friendModel.Id }, friendModel);
        }

        // DELETE: api/FriendModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFriendModel(int id)
        {
            if (_context.Friends == null)
            {
                return NotFound();
            }
            var friendModel = await _context.Friends.FindAsync(id);
            if (friendModel == null)
            {
                return NotFound();
            }

            _context.Friends.Remove(friendModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FriendModelExists(int id)
        {
            return (_context.Friends?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
