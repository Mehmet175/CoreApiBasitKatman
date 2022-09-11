using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DenemeApi.EF
{
    public partial class PVSCADA2022Context : DbContext
    {
        public PVSCADA2022Context()
        {
        }

        public PVSCADA2022Context(DbContextOptions<PVSCADA2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAddressType> TblAddressTypes { get; set; }
        public virtual DbSet<TblCity> TblCities { get; set; }
        public virtual DbSet<TblCompany> TblCompanies { get; set; }
        public virtual DbSet<TblDevice> TblDevices { get; set; }
        public virtual DbSet<TblDevicePrice> TblDevicePrices { get; set; }
        public virtual DbSet<TblDeviceStatuLog> TblDeviceStatuLogs { get; set; }
        public virtual DbSet<TblDeviceStatus> TblDeviceStatuses { get; set; }
        public virtual DbSet<TblDeviceType> TblDeviceTypes { get; set; }
        public virtual DbSet<TblDeviceTypeAddressTypeMap> TblDeviceTypeAddressTypeMaps { get; set; }
        public virtual DbSet<TblDistrict> TblDistricts { get; set; }
        public virtual DbSet<TblInvoice> TblInvoices { get; set; }
        public virtual DbSet<TblMeterInstantReading> TblMeterInstantReadings { get; set; }
        public virtual DbSet<TblMeterInstantReadingLog> TblMeterInstantReadingLogs { get; set; }
        public virtual DbSet<TblMotorSwitch> TblMotorSwitchs { get; set; }
        public virtual DbSet<TblNotification> TblNotifications { get; set; }
        public virtual DbSet<TblPage> TblPages { get; set; }
        public virtual DbSet<TblPeriodResult> TblPeriodResults { get; set; }
        public virtual DbSet<TblPowerPlaintDay> TblPowerPlaintDays { get; set; }
        public virtual DbSet<TblPowerPlaintMonth> TblPowerPlaintMonths { get; set; }
        public virtual DbSet<TblPowerPlaintSayacDay> TblPowerPlaintSayacDays { get; set; }
        public virtual DbSet<TblPowerPlaintSayacMonth> TblPowerPlaintSayacMonths { get; set; }
        public virtual DbSet<TblPowerPlaintSayacYear> TblPowerPlaintSayacYears { get; set; }
        public virtual DbSet<TblPowerPlaintYear> TblPowerPlaintYears { get; set; }
        public virtual DbSet<TblRun> TblRuns { get; set; }
        public virtual DbSet<TblSayacPeriodResult> TblSayacPeriodResults { get; set; }
        public virtual DbSet<TblStatusHandler> TblStatusHandlers { get; set; }
        public virtual DbSet<TblStatusHandlerLog> TblStatusHandlerLogs { get; set; }
        public virtual DbSet<TblStatusHandlerScada> TblStatusHandlerScadas { get; set; }
        public virtual DbSet<TblStatusHandlerScadaAnlikLog> TblStatusHandlerScadaAnlikLogs { get; set; }
        public virtual DbSet<TblStatusHandlerScadaLog> TblStatusHandlerScadaLogs { get; set; }
        public virtual DbSet<TblStatusHandlerScadaUretilenLog> TblStatusHandlerScadaUretilenLogs { get; set; }
        public virtual DbSet<TblSystemIsWorking> TblSystemIsWorkings { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblWeatherForecast> TblWeatherForecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblAddressType>(entity =>
            {
                entity.ToTable("tblAddressType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.ToTable("tblCities");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.ToTable("tblCompanies");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreaateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone1).HasMaxLength(15);

                entity.Property(e => e.Phone2).HasMaxLength(15);

                entity.Property(e => e.Phone3).HasMaxLength(15);

                entity.Property(e => e.RolId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName).HasMaxLength(150);

                entity.Property(e => e.Website).HasMaxLength(150);
            });

            modelBuilder.Entity<TblDevice>(entity =>
            {
                entity.ToTable("tblDevices");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AboneNo).HasMaxLength(150);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Asdu).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceKw).HasMaxLength(500);

                entity.Property(e => e.DeviceName).HasMaxLength(150);

                entity.Property(e => e.DeviceType).HasMaxLength(500);

                entity.Property(e => e.Img1).HasColumnName("img1");

                entity.Property(e => e.Img2).HasColumnName("img2");

                entity.Property(e => e.Img3).HasColumnName("img3");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.LicenceFinishDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(500);

                entity.Property(e => e.SozlesmeGucu).HasMaxLength(150);

                entity.Property(e => e.TekilNo).HasMaxLength(150);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasMaxLength(50);

                entity.Property(e => e.UnitPriceBuy).HasMaxLength(50);

                entity.Property(e => e.Visibility)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblDevicePrice>(entity =>
            {
                entity.ToTable("tblDevicePrices");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstDate).HasColumnType("date");

                entity.Property(e => e.LastDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblDeviceStatuLog>(entity =>
            {
                entity.ToTable("tblDeviceStatuLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblDeviceStatus>(entity =>
            {
                entity.ToTable("tblDeviceStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblDeviceType>(entity =>
            {
                entity.ToTable("tblDeviceTypes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Port).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDeviceTypeAddressTypeMap>(entity =>
            {
                entity.ToTable("tblDeviceTypeAddressTypeMap");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblDistrict>(entity =>
            {
                entity.ToTable("tblDistricts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblInvoice>(entity =>
            {
                entity.ToTable("tblInvoice");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('Aktif Enerji ')");

                entity.Property(e => e.Kdv).HasColumnName("KDV");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice).IsRequired();
            });

            modelBuilder.Entity<TblMeterInstantReading>(entity =>
            {
                entity.ToTable("tblMeterInstantReading");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMeterInstantReadingLog>(entity =>
            {
                entity.ToTable("tblMeterInstantReadingLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId).HasColumnName("CreateUserID");
            });

            modelBuilder.Entity<TblMotorSwitch>(entity =>
            {
                entity.ToTable("tblMotorSwitchs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Tip).HasMaxLength(25);
            });

            modelBuilder.Entity<TblNotification>(entity =>
            {
                entity.ToTable("tblNotifications");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Token).HasMaxLength(200);
            });

            modelBuilder.Entity<TblPage>(entity =>
            {
                entity.ToTable("tblPages");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Icon).HasMaxLength(150);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblPeriodResult>(entity =>
            {
                entity.ToTable("tblPeriodResults");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.MonthMoney).HasMaxLength(100);

                entity.Property(e => e.MonthResult).HasMaxLength(100);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.TodayMoney).HasMaxLength(100);

                entity.Property(e => e.TodayResult).HasMaxLength(100);

                entity.Property(e => e.TotalMoney).HasMaxLength(100);

                entity.Property(e => e.TotalResult).HasMaxLength(100);

                entity.Property(e => e.YearMoney).HasMaxLength(100);

                entity.Property(e => e.YearResult).HasMaxLength(100);

                entity.Property(e => e.YesterdayMoney).HasMaxLength(100);

                entity.Property(e => e.YesterdayResult).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPowerPlaintDay>(entity =>
            {
                entity.ToTable("tblPowerPlaintDay");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnType("date")
                    .HasColumnName("Day_");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPowerPlaintMonth>(entity =>
            {
                entity.ToTable("tblPowerPlaintMonth");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Month).HasColumnName("Month_");

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("Year_");
            });

            modelBuilder.Entity<TblPowerPlaintSayacDay>(entity =>
            {
                entity.ToTable("tblPowerPlaintSayacDay");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnType("date")
                    .HasColumnName("Day_");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPowerPlaintSayacMonth>(entity =>
            {
                entity.ToTable("tblPowerPlaintSayacMonth");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Month).HasColumnName("Month_");

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("Year_");
            });

            modelBuilder.Entity<TblPowerPlaintSayacYear>(entity =>
            {
                entity.ToTable("tblPowerPlaintSayacYear");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("Year_");
            });

            modelBuilder.Entity<TblPowerPlaintYear>(entity =>
            {
                entity.ToTable("tblPowerPlaintYear");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("Year_");
            });

            modelBuilder.Entity<TblRun>(entity =>
            {
                entity.ToTable("tblRun");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Datetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSayacPeriodResult>(entity =>
            {
                entity.ToTable("tblSayacPeriodResults");

                entity.Property(e => e.AylikEndeks).HasMaxLength(100);

                entity.Property(e => e.AylikPara).HasMaxLength(100);

                entity.Property(e => e.BugunAktifEndeksFarki).HasMaxLength(100);

                entity.Property(e => e.BugunEndeks).HasMaxLength(100);

                entity.Property(e => e.BugunInduktif).HasMaxLength(100);

                entity.Property(e => e.BugunInduktifEndeksFarki).HasMaxLength(100);

                entity.Property(e => e.BugunKapasitif).HasMaxLength(100);

                entity.Property(e => e.BugunKapasitifEndeksFarki).HasMaxLength(100);

                entity.Property(e => e.BugunPara).HasMaxLength(100);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.DunEndeks).HasMaxLength(100);

                entity.Property(e => e.DunPara).HasMaxLength(100);

                entity.Property(e => e.GecenAyEndeks).HasMaxLength(100);

                entity.Property(e => e.GecenAyPara).HasMaxLength(100);

                entity.Property(e => e.GecenYilEndeks).HasMaxLength(100);

                entity.Property(e => e.GecenYilPara).HasMaxLength(100);

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.SerialNo).HasMaxLength(50);

                entity.Property(e => e.TotalEndeks).HasMaxLength(100);

                entity.Property(e => e.TotalPara).HasMaxLength(100);

                entity.Property(e => e.YillikEndeks).HasMaxLength(100);

                entity.Property(e => e.YillikPara).HasMaxLength(100);
            });

            modelBuilder.Entity<TblStatusHandler>(entity =>
            {
                entity.ToTable("tblStatusHandlers");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Asdu).IsRequired();

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip).IsRequired();

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<TblStatusHandlerLog>(entity =>
            {
                entity.ToTable("tblStatusHandlerLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Asdu).IsRequired();

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip).IsRequired();

                entity.Property(e => e.Port).HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<TblStatusHandlerScada>(entity =>
            {
                entity.ToTable("tblStatusHandlerScadas");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Asdu)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblStatusHandlerScadaAnlikLog>(entity =>
            {
                entity.ToTable("tblStatusHandlerScadaAnlikLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Asdu)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblStatusHandlerScadaLog>(entity =>
            {
                entity.ToTable("tblStatusHandlerScadaLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Asdu)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblStatusHandlerScadaUretilenLog>(entity =>
            {
                entity.ToTable("tblStatusHandlerScadaUretilenLogs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Asdu)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblSystemIsWorking>(entity =>
            {
                entity.ToTable("tblSystemIsWorking");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(150);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tblUsers");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UserTypeId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserrName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblWeatherForecast>(entity =>
            {
                entity.ToTable("tblWeatherForecast");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Datetime).HasColumnType("date");

                entity.Property(e => e.Day).HasMaxLength(50);

                entity.Property(e => e.Heat)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Humidity).HasMaxLength(250);

                entity.Property(e => e.WindKph)
                    .HasMaxLength(250)
                    .HasColumnName("Wind_kph");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
