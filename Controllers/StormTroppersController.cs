using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StormTroppersController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            return Ok(new List<StormTrooper>
            {
                new StormTrooper
                {
                    Name = "Storm",
                    Rank = "Trooper"
                }
            });
        }
    }
}