using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Northwnd;
using System.Reflection;

namespace NorthwndApp
{
    public class NorthwndFactory : IDesignTimeDbContextFactory<NorthwndContext>
    {
        private static readonly string _connectionString = "server=127.0.0.1;database=northwnd";
        private static readonly Lazy<ServerVersion> _dbVersion = new(() => ServerVersion.AutoDetect(_connectionString));

        public NorthwndContext CreateDbContext(params string[] args)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            var options = new DbContextOptionsBuilder()
                .UseMySql(_connectionString, _dbVersion.Value, x => x.MigrationsAssembly(assemblyName))
                .Options;
            return new NorthwndContext(options);
        }
    }

}
