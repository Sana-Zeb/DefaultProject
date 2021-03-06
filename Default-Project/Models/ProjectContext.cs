﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DefaultProject.Models
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-2L2M9A5\\SQLEXPRESS;Database=Project;Trusted_Connection=True; User ID=sa; Password=sana123;");
            }
        }
*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(50);

                entity.Property(e => e.Cv)
                    .HasColumnName("CV")
                    .HasMaxLength(250);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gpa).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProfilePicture)
                    .HasColumnName("Profile_Picture")
                    .HasMaxLength(250);

                entity.Property(e => e.RollNo)
                    .HasColumnName("Roll_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(50);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Cv)
                    .HasColumnName("CV")
                    .HasMaxLength(250);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("Phone_No")
                    .HasMaxLength(50);

                entity.Property(e => e.ProfilePicture)
                    .HasColumnName("Profile_Picture")
                    .HasMaxLength(250);
            });
        }
    }
}
