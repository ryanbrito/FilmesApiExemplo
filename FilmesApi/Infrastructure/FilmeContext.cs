using FilmesApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Infrastructure
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts)
            : base(opts)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
