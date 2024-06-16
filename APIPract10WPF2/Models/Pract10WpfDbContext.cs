using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIPract10WPF2.Models;

public partial class Pract10WpfDbContext : DbContext
{
    public Pract10WpfDbContext()
    {
    }

    public Pract10WpfDbContext(DbContextOptions<Pract10WpfDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AnalysDocument> AnalysDocuments { get; set; }

    public virtual DbSet<Appoinment> Appoinments { get; set; }

    public virtual DbSet<AppoinmentDocument> AppoinmentDocuments { get; set; }

    public virtual DbSet<Direction> Directions { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<ResearchDocument> ResearchDocuments { get; set; }

    public virtual DbSet<Specialite> Specialites { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Admin___69F56766F9465803");

            entity.ToTable("Admin_");

            entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");
            entity.Property(e => e.EnterPassword).HasMaxLength(50);
            entity.Property(e => e.NameAdmin).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<AnalysDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppoinmentDocument).HasName("PK__AnalysDo__C91A05C5A76EC10F");

            entity.ToTable("AnalysDocument");

            entity.Property(e => e.IdAppoinmentDocument)
                .ValueGeneratedNever()
                .HasColumnName("ID_AppoinmentDocument");
            entity.Property(e => e.NameAnalys).HasColumnName("NameAnalys");
            entity.Property(e => e.Rtf).HasColumnName("RTF");

        });

        modelBuilder.Entity<Appoinment>(entity =>
        {
            entity.HasKey(e => e.IdAppoinment).HasName("PK__Appoinme__20DD3F343DCE35C7");

            entity.Property(e => e.IdAppoinment).HasColumnName("ID_Appoinment");
            entity.Property(e => e.DoctorId).HasColumnName("Doctor_ID");
            entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            entity.Property(e => e.StatusId).HasColumnName("Status_ID");
        });

        modelBuilder.Entity<AppoinmentDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppoinmentDocument).HasName("PK__Appoinme__C91A05C5634ABA25");

            entity.ToTable("AppoinmentDocument");

            entity.Property(e => e.IdAppoinmentDocument)
                .ValueGeneratedNever()
                .HasColumnName("ID_AppoinmentDocument");
            entity.Property(e => e.Rtf).HasColumnName("RTF");
        });

        modelBuilder.Entity<Direction>(entity =>
        {
            entity.HasKey(e => e.IdDirection).HasName("PK__Directio__59A79AAF62A74E50");

            entity.Property(e => e.IdDirection)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ID_Direction");
            entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            entity.Property(e => e.SpecialistId).HasColumnName("Specialist_ID");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.IdDoctor).HasName("PK__Doctor__3246951CA59E334E");

            entity.ToTable("Doctor");

            entity.Property(e => e.IdDoctor).HasColumnName("ID_Doctor");
            entity.Property(e => e.EnterPassword).HasMaxLength(50);
            entity.Property(e => e.NameDoctor).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.SpecialistId).HasColumnName("Specialist_ID");
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.WorkAddress).HasMaxLength(50);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.IdPatient).HasName("PK__Patient__EE3EFF68DAB590B9");

            entity.ToTable("Patient");

            entity.Property(e => e.IdPatient)
                .ValueGeneratedNever()
                .HasColumnName("ID_Patient");
            entity.Property(e => e.AddressOfPatient).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LivingAddress).HasMaxLength(255);
            entity.Property(e => e.NamePatient).HasMaxLength(50);
            entity.Property(e => e.Nickname).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(18);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<ResearchDocument>(entity =>
        {
            entity.HasKey(e => e.IdAppoinmentDocument).HasName("PK__Research__C91A05C5AA95BAF4");

            entity.ToTable("ResearchDocument");

            entity.Property(e => e.IdAppoinmentDocument)
                .ValueGeneratedNever()
                .HasColumnName("ID_AppoinmentDocument");
            entity.Property(e => e.Attachment)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.NameResearch).HasColumnName("NameResearch");
            entity.Property(e => e.Rtf).HasColumnName("RTF");
        });

        modelBuilder.Entity<Specialite>(entity =>
        {
            entity.HasKey(e => e.IdSpecialist).HasName("PK__Speciali__8D2259AB456F4636");

            entity.Property(e => e.IdSpecialist).HasColumnName("ID_Specialist");
            entity.Property(e => e.SpecialistName).HasMaxLength(50);
            entity.Property(e => e.SpecialistPhotoName).HasMaxLength(200);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__Statuses__5AC2A7349A3DF0B2");

            entity.Property(e => e.IdStatus).HasColumnName("ID_Status");
            entity.Property(e => e.NameStatus).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
