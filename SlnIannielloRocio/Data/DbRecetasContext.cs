using Microsoft.EntityFrameworkCore;
using SlnIannielloRocio.Models;

namespace SlnIannielloRocio.Data
{
    public class DbRecetasContext: DbContext
    {
        public DbRecetasContext(DbContextOptions<DbRecetasContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }
    }
}

