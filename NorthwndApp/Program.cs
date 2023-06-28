using Microsoft.EntityFrameworkCore;
using Northwnd;
using System.Threading;

namespace NorthwndApp
{
    class Program
    {
        public static readonly DbContextOptions ApplicationDefaultDbContextOptions = new DbContextOptionsBuilder()
            .UseMySql("server=127.0.0.1;database=northwnd", x => x.MigrationsAssembly(nameof(NorthwndApp))).Options;

        static void Main(string[] args)
        {
            using (var sqlite = NorthwndContext.UseSqliteResource())
            using (var mysql = new NorthwndContext(ApplicationDefaultDbContextOptions))
            {
                // You should apply migrations before write to target database
                sqlite.WriteTo(mysql);
            }
        }

    }
}
