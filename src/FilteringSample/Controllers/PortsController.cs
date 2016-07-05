using FilteringSample.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilteringSample.Controllers
{
    [Route("api")]
    public class PortsController : Controller
    {
        private readonly IPortRepository _portRepository;

        public PortsController(IPortRepository personRepository)
        {
            _portRepository = personRepository;
        }

        [HttpGet]
        [Route("memory/{filter}")]
        public IActionResult GetPortsFilteredInMemory(string filter)
        {
            var result = _portRepository.GetPortsFilteredInMemory(filter);
            return Ok(result);
        }

        [HttpGet]
        [Route("db/{filter}")]
        public IActionResult GetPortsFilteredWithEntity(string filter)
        {
            var result = _portRepository.GetPortsFilteredInDatabase(filter);
            return Ok(result);
        }
    }
}
