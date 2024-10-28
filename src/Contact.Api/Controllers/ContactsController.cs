using Microsoft.AspNetCore.Mvc;

namespace Contacts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{areaCode}")]
        public IActionResult GetByAreaCode(string areaCode)
        {
            return Ok();
        }

        [HttpPost()]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut()]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
