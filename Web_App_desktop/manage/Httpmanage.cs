using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Web_App_desktop.manage
{
    public class Httpmanage
    {
        /// <summary>
        /// ip地址
        /// </summary>
        public string IpAddress { get; set; } = "http://localhost:5000/WeatherForecast/";
        public List<string> getSurvey_point_Number(string SubProject_Name)
        {
            var client = new RestClient($"{IpAddress}GetpointNumber?SubProject_Name={SubProject_Name}");
            client.Timeout = 3000;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                string retrunModel = JsonConvert.DeserializeObject<string>(response.Content);

                return null;
            }
            else
            {
                return null;
            }
        }

    }
}
