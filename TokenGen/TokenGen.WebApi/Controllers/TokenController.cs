﻿using Microsoft.AspNetCore.Mvc;

namespace TokenGen.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public dynamic Get()
        {
            return new
            {
                Guid = Guid.NewGuid().ToString(),
                Expires = DateTime.Now.AddDays(1),
                Issuer = Environment.MachineName
            };
        }


        [HttpGet("error")]
        public dynamic Error()
        {
            throw new ApplicationException("appication issue");
        }
    }
}
