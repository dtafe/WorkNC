namespace WorkNCInfoService.Mvc5.Models.WorkModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkContext : DbContext
    {
        public WorkContext()
            : base("name=WorkContext")
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkNC_Company> WorkNC_Company { get; set; }
        public virtual DbSet<WorkNC_Factory> WorkNC_Factory { get; set; }
        public virtual DbSet<WorkNC_Machine> WorkNC_Machine { get; set; }
        public virtual DbSet<WorkNC_UserPermission> WorkNC_UserPermission { get; set; }
        public virtual DbSet<WorkNC_WorkZone> WorkNC_WorkZone { get; set; }
        public virtual DbSet<WorkNC_WorkZoneDetail> WorkNC_WorkZoneDetail { get; set; }
        public virtual DbSet<WorkNC_WorkZoneDetailProblem> WorkNC_WorkZoneDetailProblem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasMany(e => e.Memberships)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Roles)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Application>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Application)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Membership)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Profile)
                .WithRequired(e => e.User);

            modelBuilder.Entity<WorkNC_Factory>()
                .Property(e => e.ImageFile)
                .IsUnicode(false);

            modelBuilder.Entity<WorkNC_WorkZone>()
                .Property(e => e.MachiningTimeTotal)
                .IsFixedLength();

            modelBuilder.Entity<WorkNC_WorkZone>()
                .Property(e => e.ImageFile)
                .IsUnicode(false);

            modelBuilder.Entity<WorkNC_WorkZoneDetail>()
                .Property(e => e.MachineTime)
                .IsFixedLength();

            modelBuilder.Entity<WorkNC_WorkZoneDetail>()
                .Property(e => e.ImageFile)
                .IsUnicode(false);

            modelBuilder.Entity<WorkNC_WorkZoneDetailProblem>()
                .Property(e => e.ImageFile)
                .IsUnicode(false);
        }
    }
}
