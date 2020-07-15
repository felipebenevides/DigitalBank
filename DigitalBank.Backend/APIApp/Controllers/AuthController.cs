using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace APIApp.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// get auth.
        /// </summary>
        
        [HttpGet("/auth")]
        public async Task<bool> auth([FromQuery]string code)
        {

            return true;
        }


    }
}
