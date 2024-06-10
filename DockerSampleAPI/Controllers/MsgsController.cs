using DockerSampleAPI.Data;
using DockerSampleAPI.Interfaces;
using DockerSampleAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerSampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MsgsController : ControllerBase
    {
        private readonly IMsgRepository _msgRepository;
        private readonly DatabaseContext _databaseContext;
        public MsgsController(IMsgRepository msgRepository, DatabaseContext databaseContext)
        {
            _msgRepository = msgRepository;
            _databaseContext = databaseContext;
        }
    
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Msg>))]
        public IActionResult GetMsgs()
        {
            var msgs = _msgRepository.GetMsgs();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(msgs);
        }

        



    }
}
