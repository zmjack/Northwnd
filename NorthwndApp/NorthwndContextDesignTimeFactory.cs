using Microsoft.EntityFrameworkCore.Design;
using Northwnd;

namespace NorthwndApp
{
    public class NorthwndContextDesignTimeFactory : IDesignTimeDbContextFactory<NorthwndContext>
    {
        public NorthwndContext CreateDbContext(string[] args)
        {
            return new NorthwndContext(Program.ApplicationDefaultDbContextOptions, Program.DefaultPrefix);
        }
    }

}
