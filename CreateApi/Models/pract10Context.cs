using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CreateApi.Models
{
    public partial class pract10Context : DbContext
    {
        public pract10Context()
        {
        }

        public pract10Context(DbContextOptions<pract10Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Adminn> Adminns { get; set; } = null!;
        public virtual DbSet<AnalysisDocument> AnalysisDocuments { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<AppointmentDocument> AppointmentDocuments { get; set; } = null!;
        public virtual DbSet<Direction> Directions { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<ResearchDocument> ResearchDocuments { get; set; } = null!;
        public virtual DbSet<Speciality> Specialities { get; set; } = null!;
        public virtual DbSet<Statuss> Statusses { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adminn>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("PK__Adminn__69F567660C8C44A8");

                entity.ToTable("Adminn");

                entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisDocument>(entity =>
            {
                entity.HasKey(e => e.IdAnalysisDocument)
                    .HasName("PK__Analysis__5098C25DC0386EB8");

                entity.ToTable("AnalysisDocument");

                entity.Property(e => e.IdAnalysisDocument).HasColumnName("ID_AnalysisDocument");

                entity.Property(e => e.AppointmentId).HasColumnName("Appointment_ID");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rtf).IsUnicode(false);

               
                    
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.IdAppointment)
                    .HasName("PK__Appointm__CE24CCCCE7364696");

                entity.Property(e => e.IdAppointment).HasColumnName("ID_Appointment");

                

                entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");

                entity.Property(e => e.OmsId).HasColumnName("OMS_ID");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                
            });

            modelBuilder.Entity<AppointmentDocument>(entity =>
            {
                entity.HasKey(e => e.IdAppointmentDocument)
                    .HasName("PK__Appointm__077DCD83826A26F5");

                entity.ToTable("AppointmentDocument");

                entity.Property(e => e.IdAppointmentDocument).HasColumnName("ID_AppointmentDocument");

                entity.Property(e => e.AppointmentId).HasColumnName("Appointment_ID");

                entity.Property(e => e.Named)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rtf).IsUnicode(false);

                
            });

            modelBuilder.Entity<Direction>(entity =>
            {
                entity.HasKey(e => e.IdDirection)
                    .HasName("PK__Directio__59A79AAFFB6F9829");

                entity.Property(e => e.IdDirection).HasColumnName("ID_Direction");

                entity.Property(e => e.OmsId).HasColumnName("OMS_ID");

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");

                
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.IdDoctor)
                    .HasName("PK__Doctor__3246951C7C8B9BBE");

                entity.ToTable("Doctor");

                entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

               
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.IdOms)
                    .HasName("PK__Patient__20E9AB5C8E8EF106");

                entity.ToTable("Patient");

                entity.Property(e => e.IdOms).HasColumnName("ID_OMS");

                entity.Property(e => e.AddressP)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LivingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResearchDocument>(entity =>
            {
                entity.HasKey(e => e.IdResearchDocument)
                    .HasName("PK__Research__117811C649A6E33B");

                entity.ToTable("ResearchDocument");

                entity.Property(e => e.IdResearchDocument).HasColumnName("ID_ResearchDocument");

                entity.Property(e => e.AppointmentId).HasColumnName("Appointment_ID");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rtf).IsUnicode(false);

               
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.HasKey(e => e.IdSpeciality)
                    .HasName("PK__Speciali__8D22304DFEFC9436");

                entity.Property(e => e.IdSpeciality).HasColumnName("ID_Speciality");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statuss>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Statuss__5AC2A7343998A397");

                entity.ToTable("Statuss");

                entity.Property(e => e.IdStatus).HasColumnName("ID_Status");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
