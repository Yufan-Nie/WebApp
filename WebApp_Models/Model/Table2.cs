using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Models.Model
{
    public partial class Table2
    {
        public double? Id { get; set; }
        public string SurveyPointNumber { get; set; }
        public DateTime? ObservationDate { get; set; }
        public DateTime? ObservationTime { get; set; }
        public double? Temperature { get; set; }
        public double? LoadReading { get; set; }
        public string Remark { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
