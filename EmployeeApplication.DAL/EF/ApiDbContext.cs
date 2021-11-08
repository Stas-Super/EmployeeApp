using EmployeeApplication.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EmployeeApplication.DAL.EF
{
    public class ApiDbContext : DbContext, IDesignTimeDbContextFactory<ApiDbContext>
    {
        public DbSet<Employee> Employees { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
        public ApiDbContext() { }

        public ApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApiDbContext>();
            builder.UseSqlServer("Server=tcp:disco-dev-sql-srv.database.windows.net,1433;Initial Catalog=EmployeeDb;Persist Security Info=False;User ID=discosa;Password=cJM23H87;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(ApiDbContext).GetTypeInfo().Assembly.GetName().Name));

            return new ApiDbContext(builder.Options);
        }
    }
}
