﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet/errors - count")]
    [ApiController]

    // b. api / metrics / dotnet / errors - count / from /{ fromTime}/ to /{ toTime}

    
    public class DotnetMetricsController : ControllerBase
    {
        
        [HttpGet("from /{ fromTime}/ to /{ toTime}")]

        public IActionResult GetDotnetMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
    
}
