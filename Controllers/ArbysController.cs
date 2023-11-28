using Microsoft.AspNetCore.Http.HttpResults;

namespace gregslist_sql.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArbysController : ControllerBase
    {

        private readonly ArbysService _arbysService;

        public ArbysController(ArbysService arbysService)
        {
            _arbysService = arbysService;
        }

        [HttpGet]
        public ActionResult<List<Arby>> GetArbys()
        {
            try
            {
                List<Arby> arbys = _arbysService.GetArbys();
                return Ok(arbys);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }

        [HttpGet("{arbyId}")]
        public ActionResult<Arby> GetArbyById(int arbyId)
        {
            try
            {
                Arby arby = _arbysService.GetArbyById(arbyId);
                return Ok(arby);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{arbyId}")]
        public ActionResult<Arby> DestroyArby(int arbyId)
        {
            try
            {
                Arby arby = _arbysService.DestroyArby(arbyId);
                return Ok(arby);
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }
    }
}