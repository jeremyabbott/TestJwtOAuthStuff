using System.Web.Http;

namespace WebApplication6.Controllers
{
    [Authorize]
    public class SecretController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new { Property = "Hello" });
        }
    }
}