using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdapterPattern.Abstract;
using AdapterPattern.Concrete;
using AdapterPattern.Adapter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new AdapterPattern.Adapter.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
