using Ink;
using Microsoft.EntityFrameworkCore;
using Northwnd;
using NStandard;

namespace NorthwndApp;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new NorthwndMemoryContext())
        {
            var query = (
                from category in context.Employees
                select category.BirthDate
            );
            var sql = query.ToQueryString();
        }

        {
            var factory = new NorthwndFactory();
            using var context = factory.CreateDbContext();

            if (context.Database.GetMigrations().Any())
            {
                context.Database.Migrate();
                context.InitializeNorthwnd(new NorthwndFixedContext());
            }

            var query = (
                from category in context.Employees
                select category.BirthDate
            );
            var sql = query.ToQueryString();

            Console.WriteLine(sql);
            Echo.Table(query.Take(3).ToArray());
        }
    }
}
