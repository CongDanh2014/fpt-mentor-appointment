using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BussinessObject.Models
{
    public partial class FPT_Mentor_AppointmentContext : DbContext
    {
        public FPT_Mentor_AppointmentContext()
        {
        }

        public FPT_Mentor_AppointmentContext(DbContextOptions<FPT_Mentor_AppointmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBooking> TblBookings { get; set; }
        public virtual DbSet<TblJoinSubject> TblJoinSubjects { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblStatusBooking> TblStatusBookings { get; set; }
        public virtual DbSet<TblSubject> TblSubjects { get; set; }
        public virtual DbSet<TblTimeSubject> TblTimeSubjects { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server =(local); Database = FPT_Mentor_Appointment; Uid=sa; Pwd=20122001;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__tblBooki__C6D03BCD9E1AC861");

                entity.ToTable("tblBooking");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingId");

                entity.Property(e => e.Accepter)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("accepter");

                entity.Property(e => e.Booker)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("booker");

                entity.Property(e => e.BookingDescription)
                    .HasMaxLength(600)
                    .HasColumnName("bookingDescription");

                entity.Property(e => e.BookingLink)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("bookingLink");

                entity.Property(e => e.BookingTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("bookingTitle");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("date")
                    .HasColumnName("createAt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("statusName");

                entity.Property(e => e.Time)
                    .HasColumnType("date")
                    .HasColumnName("time");

                entity.Property(e => e.TimeStart)
                    .HasColumnType("date")
                    .HasColumnName("timeStart");

                entity.HasOne(d => d.AccepterNavigation)
                    .WithMany(p => p.TblBookingAccepterNavigations)
                    .HasForeignKey(d => d.Accepter)
                    .HasConstraintName("FK__tblBookin__accep__403A8C7D");

                entity.HasOne(d => d.BookerNavigation)
                    .WithMany(p => p.TblBookingBookerNavigations)
                    .HasForeignKey(d => d.Booker)
                    .HasConstraintName("FK__tblBookin__booke__3F466844");

                entity.HasOne(d => d.StatusNameNavigation)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.StatusName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tblBookin__statu__4222D4EF");
            });

            modelBuilder.Entity<TblJoinSubject>(entity =>
            {
                entity.HasKey(e => new { e.SubjectId, e.Accepter })
                    .HasName("PK__tblJoinS__E9EEB69416FEF36F");

                entity.ToTable("tblJoinSubject");

                entity.Property(e => e.SubjectId).HasColumnName("subjectId");

                entity.Property(e => e.Accepter)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("accepter");

                entity.HasOne(d => d.AccepterNavigation)
                    .WithMany(p => p.TblJoinSubjects)
                    .HasForeignKey(d => d.Accepter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblJoinSu__accep__4CA06362");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblJoinSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblJoinSu__subje__4BAC3F29");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__tblRoles__CD98462A3162EB15");

                entity.ToTable("tblRoles");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("roleId");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<TblStatusBooking>(entity =>
            {
                entity.HasKey(e => e.StatusName)
                    .HasName("PK__tblStatu__6A50C213D8985AA4");

                entity.ToTable("tblStatusBooking");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<TblSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PK__tblSubje__ACF9A760FECEF4CB");

                entity.ToTable("tblSubject");

                entity.Property(e => e.SubjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("subjectId");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("date")
                    .HasColumnName("createAt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Key)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("key");

                entity.Property(e => e.SubjectDescription)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("subjectDescription");

                entity.Property(e => e.SubjectLink)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("subjectLink");

                entity.Property(e => e.SubjectTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("subjectTitle");

                entity.Property(e => e.Subjecter)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("subjecter");

                entity.HasOne(d => d.SubjecterNavigation)
                    .WithMany(p => p.TblSubjects)
                    .HasForeignKey(d => d.Subjecter)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tblSubjec__subje__45F365D3");
            });

            modelBuilder.Entity<TblTimeSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblTimeSubject");

                entity.Property(e => e.SubjectId).HasColumnName("subjectId");

                entity.Property(e => e.Time)
                    .HasColumnType("date")
                    .HasColumnName("time");

                entity.Property(e => e.TimeStart)
                    .HasColumnType("date")
                    .HasColumnName("timeStart");

                entity.HasOne(d => d.Subject)
                    .WithMany()
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tblTimeSu__subje__48CFD27E");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__tblUsers__AB6E6165789D4D2F");

                entity.ToTable("tblUsers");

                entity.Property(e => e.Email)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Photo)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tblUsers__roleId__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
