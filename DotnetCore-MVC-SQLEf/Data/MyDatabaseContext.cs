using DotnetCore_MVC_SQLEf.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore_MVC_SQLEf.Data
{
    public class MyDatabaseContext: DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
            
        }

        public DbSet<Todo>? Todo { get; set; }
    }
}
