using Microsoft.EntityFrameworkCore;
using WebApi_Funcionarios.Models;

namespace WebApi_Funcionarios.DataContext
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
