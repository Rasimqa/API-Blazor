using API_Coworking.DBContext;
using API_Coworking.Interfaces;
using API_Coworking.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Coworking.Controllers
{
    [Route("api/Spaces")]
    [ApiController]
    public class SpacesController : ControllerBase
    {
        private readonly ISpacesService _SpaceService;

        public SpacesController(ISpacesService SpaceService)
        {
            _SpaceService = SpaceService;
        }

        // GET: api/Spaces
        [HttpGet]
        public IActionResult GetAllSpace()
        {
            var Spaces = _SpaceService.GetAllSpaces();
            return Ok(Spaces);
        }

        // GET: api/Spaces/{id}
        [HttpGet("{id}")]
        public IActionResult GetSpace(int id)
        {
            var Spaces = _SpaceService.GetSpaceById(id);
            if (Spaces == null)
            {
                return NotFound();
            }
            return Ok(Spaces);
        }

        // POST: api/Spaces
        [HttpPost]
        public IActionResult AddSpace([FromBody] Spaces Spaces)
        {
            if (Spaces == null || string.IsNullOrEmpty(Spaces.NameSpace))
            {
                return BadRequest("Invalid movie data.");
            }

            var addedSpace = _SpaceService.AddSpaces(Spaces);
            return CreatedAtAction(nameof(GetSpace), new { id = addedSpace.id }, addedSpace);
        }

        // PUT: api/Spaces/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateSpace(int id, [FromBody] Spaces updateSpace)
        {
            var Spaces = _SpaceService.UpdateSpaces(id, updateSpace);
            if (Spaces == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/Spaces/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteSpaces(int id)
        {
            _SpaceService.DeleteSpace(id);
            return NoContent();
        }
    }
}
