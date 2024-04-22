using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace teste_nstech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet(Name = "IsUserAuthorized"), Authorize]
        public string Get()
        {
            return $"Olá usuário do email: {_httpContextAccessor.HttpContext.User.Identity.Name}";
        }
    }
}
