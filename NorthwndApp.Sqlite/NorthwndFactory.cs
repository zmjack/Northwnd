using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Northwnd;
using System;
using System.Reflection;

namespace NorthwndApp
{
    public class NorthwndFactory : IDesignTimeDbContextFactory<NorthwndContext>
    {
        private static readonly string _connectionString = "Data Source=northwnd.db";

        public NorthwndContext CreateDbContext(params string[] args)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var options = new DbContextOptionsBuilder()
                .UseSqlite(_connectionString, x => x.MigrationsAssembly(assemblyName))
                .Options;
            return new NorthwndContext(options);
        }
    }
}
