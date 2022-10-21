using Microsoft.EntityFrameworkCore;

namespace PetProjects_Dev_Extreme.Models

{
    public class MyDbContext:DbContext
    {


        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
        #region DataSet
        public DbSet<TestDB> TestDBs { get; set; }
        public DbSet<Student> students { get; set; }
        #endregion
    }
}
