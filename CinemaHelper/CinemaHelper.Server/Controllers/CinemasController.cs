using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaHelper.Server.Data;
using CinemaHelper.Server.DTOs;
using CinemaHelper.Server.Mapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly DataContext _context;

        public CinemasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Cinemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CinemaDTO>>> GetCinemas()
        {
            return await _context.Cinemas
                .Select(x=>x.ToCinemaDTO()) 
                .ToListAsync();
        }

        // GET: api/Cinemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CinemaDTO>> GetCinema(int id)
        {
            CinemaHelper.Server.Entities.Cinema? game = await _context.Cinemas.FindAsync(id);

            return game == null 
                ? BadRequest() : 
                Ok(game.ToCinemaDTO());
        }

        // PUT: api/Cinemas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCinema(int id, UpdateCinemaDto cinema)
        {
            var existingCinema = await _context.Cinemas.FindAsync(id);

            if (existingCinema is null)
            {
                return NotFound();
            }

            _context.Entry(existingCinema)
                     .CurrentValues
                     .SetValues(cinema.ToEntity(id));

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Cinemas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostCinema(AddCinemaDto newCinema)
        {
            CinemaHelper.Server.Entities.Cinema cinema = newCinema.ToEntity();

            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Cinemas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCinema(int id)
        {
            await _context.Cinemas
                     .Where(game => game.Id == id)
                     .ExecuteDeleteAsync();

            return NoContent();
        }

        private bool CinemaExists(int id)
        {
            return _context.Cinemas.Any(e => e.Id == id);
        }
    }
}
