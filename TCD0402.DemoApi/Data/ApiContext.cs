using Microsoft.EntityFrameworkCore;

using TCD0402.DemoApi.Models;

namespace TCD0402.DemoApi.Data
{
  public class ApiDbContext : DbContext
  {
    public DbSet<ItemData> Items { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }

  }
}
