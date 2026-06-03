using Microsoft.AspNetCore.Mvc;
using NBAApi.Data;
using NBAApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace NBAApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PlayersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlayersController(AppDbContext context)
        {
            _context = context;
        }

        // 📥 GET: api/players
        [HttpGet]
        public IActionResult Get()
        {
            var players = _context.Players.ToList();
            return Ok(players);
        }

        // 📥 GET by id: api/players/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var player = _context.Players.Find(id);

            if (player == null)
                return NotFound();

            return Ok(player);
        }

        // 📤 POST: api/players
        [HttpPost]
        public IActionResult Create(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

            return Ok(player);
        }

        // ✏️ PUT: api/players/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Player updatedPlayer)
        {
            var player = _context.Players.Find(id);

            if (player == null)
                return NotFound();

            player.Name = updatedPlayer.Name;
            player.Team = updatedPlayer.Team;
            player.Number = updatedPlayer.Number;

            _context.SaveChanges();

            return Ok(player);
        }

        // 🗑 DELETE: api/players/1
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var player = _context.Players.Find(id);

            if (player == null)
                return NotFound();

            _context.Players.Remove(player);
            _context.SaveChanges();

            return Ok("Jugador eliminado");
        }
    }
}