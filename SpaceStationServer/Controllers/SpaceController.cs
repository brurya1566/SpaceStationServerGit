using BL;
using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceStationServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpaceController : ControllerBase
    {
        private readonly ILogger<SpaceController> _logger;
        private readonly ISpaceBL _SpaceBL;
        public SpaceController(ILogger<SpaceController> logger,ISpaceBL spaceBL)
        {
            _logger = logger;
            _SpaceBL = spaceBL;
        }
        // GET: api/<SpaceController>
        [HttpGet]
        public async Task<SpaceLocationResponse> GetLocation()
        {
            return await _SpaceBL.GetLocation();
        }

        // POST api/<SpaceController>
        [HttpPost]
        public List<ImportantLocation> Post([FromBody] ImportantLocation value)
        {
            return _SpaceBL.SaveLocation(value);
        }

    }
}
