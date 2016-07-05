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

        const string SAMPLE_FILTER = "NZ";

        [HttpGet]
        [Route("memoryfilter")]
        public IActionResult GetPortsFilteredInMemory()
        {
            var result = _portRepository.GetPortsFilteredInMemory(SAMPLE_FILTER);
            return Ok(result);
        }

        [HttpGet]
        [Route("dbfilter")]
        public IActionResult GetPortsFilteredWithEntity()
        {
            var result = _portRepository.GetPortsFilteredInDatabase(SAMPLE_FILTER);
            return Ok(result);
        }
    }
}
