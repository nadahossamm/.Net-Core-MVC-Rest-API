using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DockerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet] //tells the rest of the MVC that this expects to be requested using a GET request
        public ActionResult <IEnumerable<string>> Get()
        {
            return new string[]  {"hi","from","vsCode"};
        }

        
    }
}