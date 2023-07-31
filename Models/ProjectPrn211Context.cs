using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectPrn211.Models
{
    public partial class ProjectPrn211Context : DbContext
    {
        public ProjectPrn211Context()
        {
        }

        public ProjectPrn211Context(DbContextOptions<ProjectPrn211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> Cards { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Example> Examples { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Sound> Sounds { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Topic> Topics { get; set; } = null!;
        public virtual DbSet<Video> Videos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProjectPrn211;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.ToTable("Card");

                entity.Property(e => e.CardMeaning).HasMaxLength(100);

                entity.Property(e => e.CardText).HasMaxLength(100);

                entity.Property(e => e.DateLearn).HasColumnType("date");

                entity.Property(e => e.Ef).HasColumnName("EF");

                entity.HasOne(d => d.CatNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.Cat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Category");

                entity.HasOne(d => d.ExampleNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.Example)
                    .HasConstraintName("FK_Card_Example");

                entity.HasOne(d => d.ImageNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.Image)
                    .HasConstraintName("FK_Card_Image");

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.InverseOrg)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_Card_Card");

                entity.HasOne(d => d.TopicNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.Topic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Topic");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("Category");

                entity.Property(e => e.CatName).HasMaxLength(50);
            });

            modelBuilder.Entity<Example>(entity =>
            {
                entity.HasKey(e => e.ExId);

                entity.ToTable("Example");

                entity.Property(e => e.Ex).HasMaxLength(250);

                entity.HasOne(d => d.CardNavigation)
                    .WithMany(p => p.Examples)
                    .HasForeignKey(d => d.Card)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Example_Card");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.Image1)
                    .HasMaxLength(200)
                    .HasColumnName("Image");

                entity.HasOne(d => d.CardNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.Card)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_Card");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateLearn).HasColumnType("date");

                entity.Property(e => e.Ef).HasColumnName("EF");

                entity.HasOne(d => d.CardNavigation)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.Card)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Card");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Student");
            });

            modelBuilder.Entity<Sound>(entity =>
            {
                entity.ToTable("Sound");

                entity.Property(e => e.Sound1)
                    .HasMaxLength(200)
                    .HasColumnName("Sound");

                entity.HasOne(d => d.CardNavigation)
                    .WithMany(p => p.Sounds)
                    .HasForeignKey(d => d.Card)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sound_Card");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.StudentName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.TopicName).HasMaxLength(100);

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.Student)
                    .HasConstraintName("FK_Topic_Student");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.ToTable("Video");

                entity.Property(e => e.Video1)
                    .HasMaxLength(200)
                    .HasColumnName("Video");

                entity.HasOne(d => d.CardNavigation)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.Card)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_Card");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
