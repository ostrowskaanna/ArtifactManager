﻿using ArtifactManager.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext() : base("ArtifactDatabase")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CodeFirstContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CodeFirstContext>());
        }


        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cave> Caves { get; set; }
        public virtual DbSet<Forest> Forests { get; set; }
        public virtual DbSet<Tower> Towers { get; set; }
        public virtual DbSet<Dragon> Dragons { get; set; }
        public virtual DbSet<Bat> Bats { get; set; }
        public virtual DbSet<Spider> Spiders { get; set; }
        public virtual DbSet<Ent> Ents { get; set; }
        public virtual DbSet<Wolf> Wolfs { get; set; }
        public virtual DbSet<Giant> Giants { get; set; }
        public virtual DbSet<Knight> Knights { get; set; }
        public virtual DbSet<Magus> Magus { get; set; }
        public virtual DbSet<Witch> Witches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Dragon>()
                .HasOptional<Cave>(c => c.Cave)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Bat>()
                .HasOptional<Cave>(c => c.Cave)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Spider>()
                .HasOptional<Cave>(c => c.Cave)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Ent>()
                .HasOptional<Forest>(c => c.Forest)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Wolf>()
                .HasOptional<Forest>(c => c.Forest)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Giant>()
                .HasOptional<Forest>(c => c.Forest)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Knight>()
                .HasOptional<Tower>(c => c.Tower)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Magus>()
                .HasOptional<Tower>(c => c.Tower)
                .WithMany()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Witch>()
                .HasOptional<Tower>(c => c.Tower)
                .WithMany()
                .WillCascadeOnDelete(true);
        }

    }
}
