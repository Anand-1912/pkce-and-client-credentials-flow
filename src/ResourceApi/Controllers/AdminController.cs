using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace ResourceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [RequiredScopeOrAppPermission(
           AcceptedScope = new[] { "access_as_admin" })]
    public class AdminController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public AdminController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok($"This is the Admin Endpoint");
        }
    }
}
