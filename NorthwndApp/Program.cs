using Microsoft.EntityFrameworkCore;
using Northwnd;
using System;
using System.Threading;

namespace NorthwndApp
{
    class Program
    {
        private const string _connectionString = "server=127.0.0.1;database=northwnd";
        public const string DefaultPrefix = "@n";

        private static readonly Lazy<ServerVersion> _dbVersion = new(() => ServerVersion.AutoDetect(_connectionString));
        public static readonly DbContextOptions ApplicationDefaultDbContextOptions = new DbContextOptionsBuilder()
            .UseMySql(_connectionString, _dbVersion.Value, x => x.MigrationsAssembly(nameof(NorthwndApp))).Options;

        static void Main(string[] args)
        {
            using (var mysql = new NorthwndContext(ApplicationDefaultDbContextOptions, DefaultPrefix))
            {
                mysql.Database.Migrate();
            }

            var memoryContext = new NorthwndMemoryContext();
            using (var mysql = new NorthwndContext(ApplicationDefaultDbContextOptions, DefaultPrefix))
            {
                mysql.InitializeNorthwnd(memoryContext);
            }
        }

    }
}
