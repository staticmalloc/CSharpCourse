using Microsoft.EntityFrameworkCore;

namespace UniversityDataBase.Models
{
    public class AppDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Disertation> Disertations { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Cafedra> Cafedras { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Journal> Journals { get; set; }
        
        public DbSet<Diploma> Diplomas { get; set; }
        
        public DbSet<Session> Sessions { get; set; }
        
        
        public DbSet<FacultyCafedra> FacultyCafedras { get; set; }
        
        public DbSet<GroupsDisciplines> GroupsDisciplines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacultyCafedra>().HasKey(fc => new {fc.CafedraId, fc.FacultyId});
            modelBuilder.Entity<GroupsDisciplines>().HasKey(gd => new {gd.GroupId, gd.DisciplineId});
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        
    }
}