using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApp_Models.Model
{
    public partial class testContext : DbContext
    {
        //public testContext()
        //{
        //}

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Table2> Table2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WIN-C0COR5DO86C;Database=test;User Id =sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table1");

                entity.Property(e => e.BenchmarkResist).HasColumnName("Benchmark_Resist");

                entity.Property(e => e.BenchmarkResistRatio).HasColumnName("Benchmark_Resist_Ratio");

                entity.Property(e => e.CalculateCoeffiG).HasColumnName("Calculate_Coeffi_G");

                entity.Property(e => e.ConversionC).HasColumnName("Conversion_C");

                entity.Property(e => e.CoordinateX).HasColumnName("Coordinate_X");

                entity.Property(e => e.CoordinateY).HasColumnName("Coordinate_Y");

                entity.Property(e => e.CoordinateZ).HasColumnName("Coordinate_Z");

                entity.Property(e => e.DrillAngle)
                    .HasMaxLength(255)
                    .HasColumnName("Drill_angle");

                entity.Property(e => e.DrillDepth).HasColumnName("Drill_Depth");

                entity.Property(e => e.DrillName)
                    .HasMaxLength(255)
                    .HasColumnName("Drill_Name");

                entity.Property(e => e.ExFactoryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EX_factory_Date");

                entity.Property(e => e.ExFactoryNumber)
                    .HasMaxLength(255)
                    .HasColumnName("EX_factory_Number");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InstallPerson)
                    .HasMaxLength(255)
                    .HasColumnName("Install_Person");

                entity.Property(e => e.InstallTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Install_Time");

                entity.Property(e => e.InstrumentName)
                    .HasMaxLength(255)
                    .HasColumnName("Instrument_Name");

                entity.Property(e => e.InstrumentSpan)
                    .HasMaxLength(255)
                    .HasColumnName("Instrument_Span");

                entity.Property(e => e.InstrumentType)
                    .HasMaxLength(255)
                    .HasColumnName("Instrument_Type");

                entity.Property(e => e.ItemProjectName)
                    .HasMaxLength(255)
                    .HasColumnName("ItemProject_Name");

                entity.Property(e => e.Mileage).HasMaxLength(255);

                entity.Property(e => e.MonitorName)
                    .HasMaxLength(255)
                    .HasColumnName("Monitor_Name");

                entity.Property(e => e.PointCode)
                    .HasMaxLength(255)
                    .HasColumnName("Point_Code");

                entity.Property(e => e.PointDescrip)
                    .HasMaxLength(255)
                    .HasColumnName("Point_Descrip");

                entity.Property(e => e.ProjectCode).HasColumnName("Project_Code");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.SectionName)
                    .HasMaxLength(255)
                    .HasColumnName("Section_Name");

                entity.Property(e => e.SubProjectName)
                    .HasMaxLength(255)
                    .HasColumnName("SubProject_Name");

                entity.Property(e => e.SurveyPointNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Survey_point_Number");

                entity.Property(e => e.TemperaReviseK).HasColumnName("Tempera_Revise_K");

                entity.Property(e => e.TemperatureRead).HasColumnName("Temperature_Read");

                entity.Property(e => e.ZeroResistance).HasColumnName("Zero_Resistance");
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoadReading).HasColumnName("loadReading");

                entity.Property(e => e.ObservationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Observation_Date");

                entity.Property(e => e.ObservationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Observation_Time");

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.SurveyPointNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Survey_point_Number");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
