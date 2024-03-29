﻿using Microsoft.EntityFrameworkCore;
using Northwnd;

namespace NorthwndApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new NorthwndFactory();
            using var context = factory.CreateDbContext();

            if (!context.Database.GetMigrations().Any())
            {
                context.Database.Migrate();
                context.InitializeNorthwnd(new NorthwndMemoryContext());
            }

            var sql = (
                from category in context.Categories
                select category.CategoryName
            ).ToQueryString();

            Console.WriteLine(sql);
        }

    }
}
