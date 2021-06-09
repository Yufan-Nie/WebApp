using Algorithm;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Models;
using WebApp_Models.Model;
using WebApp_Service;

namespace WebApp_webapi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        public readonly testContext _testContext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, testContext testContext)
        {
            _logger = logger;
            _testContext = testContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        /// <summary>
        /// 4、	使用webAPI构建一个后台服务，添加数据查询接口，对上述数据库中的表格进行查询，结果以json格式返回。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object GetTable1()
        {
#region
            string i = Algorithmsort.sort("dddaakkkbceooo");
            int c = Algorithmsort.Fibonacci(30);
#endregion
            var blogs = _testContext.Set<Table1>().ToList();                          
            return blogs;
        }

        [HttpGet]
        public object GetTable2()
        {
            var blogs = _testContext.Set<Table2>().ToList();
            return blogs;
        }
        /// <summary>
        /// (1)	构建一个get接口，url中参数为某一特定SubProject_Name，返回该SubProject_Name中所有的Survey_point_Number。（数据参考table1）
        /// </summary>
        /// <param name="SubProject_Name"></param>
        /// <returns></returns>
        [HttpGet]
        public object GetpointNumber(string SubProject_Name)
        {
            var blogs = _testContext.Table1s
                .Where(b => b.SubProjectName == SubProject_Name)
                .Select(b=>new { 
                 Survey_point_Number=b.SurveyPointNumber
                })
                .ToList();
            //遍历value

            return blogs;
        }


        /// <summary>
        /// (2)	构建一个post接口，传递参数为Survey_point_Number，startTime，endTime。其中Survey_point_Number为某一特定点号，startTime和endTime为起止时间，要求返回传入点号在起止时间之间的所有数据记录。（数据参考table2）
        /// </summary>
        /// <param name="timeQuery"></param>
        /// <returns></returns>
        [HttpPost]
        public object GetTime(TimeQuery timeQuery)
        {
            var blogs = _testContext.Table2s
                .Where(x => x.SurveyPointNumber==timeQuery.SurveyPointNumber&&x.UpdateTime >= timeQuery.startTime&& x.UpdateTime <= timeQuery.endTime)
                .ToList();
            return blogs;
        }

    }
}
