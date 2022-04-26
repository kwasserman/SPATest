using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaBL;

namespace SpaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterApiController : ControllerBase
    {
        private readonly ISpaBL repo;
        public RegisterApiController(ISpaBL _info)
        {
            repo = _info;
        }
        [HttpPost("Add")]
        public IActionResult addUsers([FromQuery] string username, string password)
        {
            try
            {
                
                return Created("Register Successful", repo.addUsers());
            }
            catch
            {
                throw new Exception("Error: This is being built");
            }
        }
    }
}
