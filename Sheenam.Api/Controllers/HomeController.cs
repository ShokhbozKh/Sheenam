//==================================================
//Copyright (c) Coalition of Good-Hearted Enginners
//Free To Use Comfort and Pleace
//==================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello Mario, the princess is in another castle");
        }

    }
}
