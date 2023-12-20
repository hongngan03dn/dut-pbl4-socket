using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MailServer.Entities
{
    public partial class testpbldbContext : DbContext
    {
        public testpbldbContext()
        {
        }

        public testpbldbContext(DbContextOptions<testpbldbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avatar> Avatars { get; set; } = null!;
        public virtual DbSet<File> Files { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=testpbldb.database.windows.net;Initial Catalog=testpbldb;Persist Security Info=True;User ID=adminpbl;Password=123Vnpt123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avatar>(entity =>
            {
                entity.Property(e => e.AvaImg).HasColumnType("image");

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Path).IsUnicode(false);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.ContentMsg).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.IdFileNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.IdFile)
                    .HasConstraintName("FK_IdFile_Messages_Files");

                entity.HasOne(d => d.IdFromNavigation)
                    .WithMany(p => p.MessageIdFromNavigations)
                    .HasForeignKey(d => d.IdFrom)
                    .HasConstraintName("FK_IdFrom_Messages_Users");

                entity.HasOne(d => d.IdToNavigation)
                    .WithMany(p => p.MessageIdToNavigations)
                    .HasForeignKey(d => d.IdTo)
                    .HasConstraintName("FK_IdTo_Messages_Users");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Bio).IsUnicode(false);

                entity.Property(e => e.Bod).HasColumnName("BOD");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);

                entity.HasOne(d => d.IdAvatarNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdAvatar)
                    .HasConstraintName("FK_IdAvatar_Users_Avatars");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_IdRole_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
