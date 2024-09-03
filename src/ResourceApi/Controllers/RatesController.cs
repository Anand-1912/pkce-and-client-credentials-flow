using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace ResourceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [RequiredScopeOrAppPermission(
           AcceptedScope = new[] { "access_as_admin" },
           AcceptedAppPermission = new[] { "RatesConsumer" })]
    public class RatesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok($"This is the Rates Endpoint");
        }
    }
}
