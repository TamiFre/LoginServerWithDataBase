using LoginServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginDemoDbContext context;

        public LoginController(LoginDemoDbContext context)
        {
            this.context = context;
        }   
    }
     
}
