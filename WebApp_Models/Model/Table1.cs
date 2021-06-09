using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_Models.Model
{
    public partial class Table1
    {
        public double? Id { get; set; }
        public string SurveyPointNumber { get; set; }
        public double? ProjectCode { get; set; }
        public string SubProjectName { get; set; }
        public string ItemProjectName { get; set; }
        public string MonitorName { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentType { get; set; }
        public string ExFactoryNumber { get; set; }
        public DateTime? ExFactoryDate { get; set; }
        public string InstallPerson { get; set; }
        public DateTime? InstallTime { get; set; }
        public double? CoordinateX { get; set; }
        public double? CoordinateY { get; set; }
        public double? CoordinateZ { get; set; }
        public string Mileage { get; set; }
        public double? Elevation { get; set; }
        public string SectionName { get; set; }
        public string DrillName { get; set; }
        public double? DrillDepth { get; set; }
        public string DrillAngle { get; set; }
        public string InstrumentSpan { get; set; }
        public double? Waterproof { get; set; }
        public double? CalculateCoeffiG { get; set; }
        public double? TemperaReviseK { get; set; }
        public double? ConversionC { get; set; }
        public double? BenchmarkResistRatio { get; set; }
        public double? BenchmarkResist { get; set; }
        public double? TemperatureRead { get; set; }
        public double? ZeroResistance { get; set; }
        public string PointDescrip { get; set; }
        public string Remark { get; set; }
        public string PointCode { get; set; }
    }
}
