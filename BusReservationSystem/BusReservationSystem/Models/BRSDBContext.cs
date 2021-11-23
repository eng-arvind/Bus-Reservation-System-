using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusReservationSystem.Models
{
    public partial class BRSDBContext : DbContext
    {
        public BRSDBContext()
        {
        }

        public BRSDBContext(DbContextOptions<BRSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminMaster> AdminMasters { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Bu> buses { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<UserReg> UserRegs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=(localdb)\\MSSqlLocalDB; Database=BRSDB; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminMaster>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("pk_AId");

                entity.ToTable("AdminMaster");

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Admin')");

                entity.Property(e => e.UsrPswd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Admin')");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("pk_BkId");

                entity.ToTable("Booking");

                entity.Property(e => e.BookStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Not Booked')");

                entity.Property(e => e.IdProof)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Npassengers).HasColumnName("NPassengers");

                entity.Property(e => e.Tcharge)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("TCharge");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserMob)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("fk_schID");
            });

            modelBuilder.Entity<Bu>(entity =>
            {
                entity.HasKey(e => e.BusId)
                    .HasName("pkBusID");

                entity.ToTable("BUS");

                entity.Property(e => e.BusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PayMode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("pk_fk_bkId");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("Route");

                entity.Property(e => e.Arrive)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("arrive");

                entity.Property(e => e.Dest)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("dest");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Fare).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.JrnyDate).HasColumnType("date");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.BusId)
                    .HasConstraintName("fk_bus");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("fk_route");
            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity.HasKey(e => e.RefId)
                    .HasName("pkReId");

                entity.ToTable("Seat");

                entity.Property(e => e.RefId).HasColumnName("refId");

                entity.Property(e => e.SeatId).HasColumnName("seatId");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Seats)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("fkBId");
            });

            modelBuilder.Entity<UserReg>(entity =>
            {
                entity.HasKey(e => e.UserEmail)
                    .HasName("pk_usrEmail");

                entity.ToTable("UserReg");

                entity.HasIndex(e => e.UserMob, "UQ__UserReg__29E70E7CB569B4A7")
                    .IsUnique();

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pswd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserMob)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsrAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Wallet)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
