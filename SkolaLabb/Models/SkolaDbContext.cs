using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SkolaLabb.Models
{
    public partial class SkolaDbContext : DbContext
    {
        public SkolaDbContext()
        {
        }

        public SkolaDbContext(DbContextOptions<SkolaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Befattning> Befattning { get; set; }
        public virtual DbSet<Betyg> Betyg { get; set; }
        public virtual DbSet<Elev> Elev { get; set; }
        public virtual DbSet<Klass> Klass { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }

        public virtual List<Elev> Elever { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-RS3CPJF;Initial Catalog=SkolaV2;Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Befattning>(entity =>
            {
                entity.HasKey(e => e.BefattningsId);

                entity.Property(e => e.BefattningsId).ValueGeneratedNever();

                entity.Property(e => e.BefattningsNamn)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Betyg>(entity =>
            {
                entity.HasKey(e => e.BetygsId);

                entity.Property(e => e.Betyg1)
                    .HasColumnName("Betyg")
                    .HasMaxLength(50);

                entity.Property(e => e.BetygsDatum).HasColumnType("date");

                entity.Property(e => e.KursNamn).HasMaxLength(50);

                entity.HasOne(d => d.Elev)
                    .WithMany(p => p.Betyg)
                    .HasForeignKey(d => d.ElevId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Betyg_Elev");

                entity.HasOne(d => d.Lärar)
                    .WithMany(p => p.Betyg)
                    .HasForeignKey(d => d.LärarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Betyg_Personal");
            });

            modelBuilder.Entity<Elev>(entity =>
            {
                entity.Property(e => e.Fnamn)
                    .HasColumnName("FNamn")
                    .HasMaxLength(50);

                entity.Property(e => e.Lnamn)
                    .HasColumnName("LNamn")
                    .HasMaxLength(50);

                entity.Property(e => e.PrsNr).HasMaxLength(50);

                entity.HasOne(d => d.Klass)
                    .WithMany(p => p.Elev)
                    .HasForeignKey(d => d.KlassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Elev_Klass");
            });

            modelBuilder.Entity<Klass>(entity =>
            {
                entity.Property(e => e.KlassId).ValueGeneratedNever();

                entity.Property(e => e.KlassNamn).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.AnställningsNr);

                entity.Property(e => e.Fnamn)
                    .HasColumnName("FNamn")
                    .HasMaxLength(50);

                entity.Property(e => e.Lnamn)
                    .HasColumnName("LNamn")
                    .HasMaxLength(50);

                entity.Property(e => e.PrsNr).HasMaxLength(50);

                entity.HasOne(d => d.Befattnings)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.BefattningsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personal_Befattning");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
