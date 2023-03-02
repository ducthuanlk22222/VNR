using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Infrastructure
{
    public class VnResouceContext : DbContext
    {
        public VnResouceContext()
        {
        }

        public VnResouceContext(DbContextOptions<VnResouceContext> options)
            :base(options) 
        {
        }

        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }

    }
}
