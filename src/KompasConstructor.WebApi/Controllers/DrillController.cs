using KompasConstructor.UseCase.Services.DrillService;
using KompasConstructor.WebApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KompasConstructor.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class DrillController : ControllerBase
    {
        private readonly IDrillService _drillService;

        public DrillController(IDrillService drillService)
        {
            _drillService = drillService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ConstructDrill(ConstructDrillDTO request)
        {
            var result = _drillService.ConstructDrill();
            return Ok("Hello bro");
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Test>), StatusCodes.Status200OK)]
        public IActionResult Drill()
        {
            var drill = new Test();
            drill.Name = "Drill";
            drill.Age = 10;
            var result = JsonConvert.SerializeObject(drill);
            return Ok(result);
        }
    }

    public class Test
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
