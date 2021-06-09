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

        public List<maxloadReadinglist> Statistics(string SubProject_Name)
        {
            List<maxloadReadinglist> maxloadReadinglists = new List<maxloadReadinglist>();
            List<string> Survey_point_Numberlist = getSurvey_point_Number(SubProject_Name);
            for (int i = 0; i< Survey_point_Numberlist.Count;i++)
            {
                maxloadReadinglist maxloadReadinglist = new maxloadReadinglist();
                maxloadReadinglist.SurveyPointNumber = Survey_point_Numberlist[i];
                maxloadReadinglist.LoadReading = GetmaxloadReading(maxloadReadinglist.SurveyPointNumber);
                maxloadReadinglists.Add(maxloadReadinglist);
            }
            return maxloadReadinglists;

        }
        /// <summary>
        /// ip地址
        /// </summary>
        public string IpAddress { get; set; } = "http://localhost:5000/WeatherForecast/";
        public List<string> getSurvey_point_Number(string SubProject_Name)
        {
            List<string> list = new List<string>();
            var client = new RestClient($"{IpAddress}GetpointNumber?SubProject_Name={SubProject_Name}");
            client.Timeout = 3000;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                string retrunModel = response.Content;
                string[] strTmps = retrunModel.Split('"');
                for (int i = 1; i < strTmps.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        list.Add(strTmps[i]);
                    }
                }
                return list;
            }
            else
            {
                return list;
            }
        }


        public double GetmaxloadReading(string Survey_point_Number)
        {
            //Survey_point_Number = "DC-D1-K-02";
            double list = 0;
            var client = new RestClient($"{IpAddress}GetmaxloadReading?Survey_point_Number={Survey_point_Number}");
            client.Timeout = 5000;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                list = double.Parse(response.Content);
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
