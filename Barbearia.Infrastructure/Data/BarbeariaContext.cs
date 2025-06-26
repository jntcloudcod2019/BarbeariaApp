using Microsoft.EntityFrameworkCore;

namespace Barbearia.Infrastructure.Data
{
    public class BarbeariaContext : DbContext
    {
         public BarbeariaContext(DbContextOptions<BarbeariaContext> options) : base(options) { }
    }
}