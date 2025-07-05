using API_Coworking.DBContext;
using API_Coworking.Interfaces;
using API_Coworking.Models;
using API_Coworking.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_Coworking.Controllers
{
    [Route("api/WorkPlace")]
    [ApiController]
    public class WorkPlaceController : ControllerBase
    {
        private readonly IWorkPlacesService _WorkPlaceService;

        public WorkPlaceController(IWorkPlacesService WorkPlaceService)
        {
            _WorkPlaceService = WorkPlaceService;
        }

        // GET: api/WorkPlace
        [HttpGet]
        public IActionResult GetAllWorkPlace()
        {
            var WorkPlace = _WorkPlaceService.GetAllWorkPlace();
            return Ok(WorkPlace);
        }

        // GET: api/WorkPlace/{id}
        [HttpGet("{id}")]
        public IActionResult GetWorkPlace(int id)
        {
            var WorkPlace = _WorkPlaceService.GetWorkPlaceById(id);
            if (WorkPlace == null)
            {
                return NotFound();
            }
            return Ok(WorkPlace);
        }

        // POST: api/WorkPlace
        [HttpPost]
        public IActionResult AddWorkPlace([FromBody] WorkPlace WorkPlace)
        {
            if (WorkPlace == null || string.IsNullOrEmpty(WorkPlace.Description))
            {
                return BadRequest("Invalid movie data.");
            }

            var addedWorkPlace = _WorkPlaceService.AddWorkPlace(WorkPlace);
            if(addedWorkPlace != null)
            {
                return CreatedAtAction(nameof(GetWorkPlace), new { id = addedWorkPlace.id }, addedWorkPlace);
            }
            else
            {
                return BadRequest("Invalid movie data.");
            }
            
        }

        // PUT: api/WorkPlace/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateWorkPlace(int id, [FromBody] WorkPlace updatedWorkPlace)
        {
            var WorkPlace = _WorkPlaceService.UpdateWorkPlace(id, updatedWorkPlace);
            if (WorkPlace == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/WorkPlace/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkPlace(int id)
        {
            _WorkPlaceService.DeleteWorkPlace(id);
            return NoContent();
        }
    }
}
