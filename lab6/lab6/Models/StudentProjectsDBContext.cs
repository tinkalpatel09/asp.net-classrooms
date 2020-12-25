using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab6.Models
{
    public partial class StudentProjectsDBContext : DbContext
    {
        public StudentProjectsDBContext()
        {
        }

        public StudentProjectsDBContext(DbContextOptions<StudentProjectsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProjectAssignments> ProjectAssignments { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PM122L9;Initial Catalog=StudentProjectsDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectAssignments>(entity =>
            {
                entity.HasKey(e => new { e.StudentNumber, e.ProjectCode });

                entity.Property(e => e.ProjectCode).HasMaxLength(10);

                entity.Property(e => e.AssignedDate).HasColumnType("date");

                entity.Property(e => e.SubmittedDate).HasColumnType("date");

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.ProjectAssignments)
                    .HasForeignKey(d => d.ProjectCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectAssignments_Projects");

                entity.HasOne(d => d.StudentNumberNavigation)
                    .WithMany(p => p.ProjectAssignments)
                    .HasForeignKey(d => d.StudentNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectAssignments_Students");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectCode);

                entity.Property(e => e.ProjectCode).HasMaxLength(10);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ProjectTitle)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentNumber);

                entity.Property(e => e.StudentNumber).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
