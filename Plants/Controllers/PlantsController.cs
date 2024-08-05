using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Plants.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantsController : ControllerBase
    {
        private readonly IPlantService _plantService;

        public PlantsController(IPlantService plantService)
        {
            _plantService = plantService;
        }

        [HttpGet("information")]
        public async Task<IActionResult> GetAsync()
        {
            var serviceResult = await _plantService.GetPlantInformationsAsync();
            return StatusCode((int)serviceResult.HttpStatusCode, serviceResult);
        }
    }
}
