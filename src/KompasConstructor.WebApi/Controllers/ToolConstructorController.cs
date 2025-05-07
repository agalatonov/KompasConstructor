using KompasConstructor.WebApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KompasConstructor.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ToolConstructorController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ConstructDrill(ConstructDrillDTO request)
        {
            var result = new byte[1];
            return Ok(result);
        }
    }
}
