using Microsoft.EntityFrameworkCore;
using Northwnd;

namespace NorthwndApp
{
    public class NorthwndMemoryContext : NorthwndContext
    {
        public NorthwndMemoryContext()
            : this(new DbContextOptionsBuilder().UseSqlite("DataSource=file::memory:?cache=shared").Options)
        {
        }

        public NorthwndMemoryContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            InitializeNorthwnd(new NorthwndFixedContext(false));
        }
    }
}
