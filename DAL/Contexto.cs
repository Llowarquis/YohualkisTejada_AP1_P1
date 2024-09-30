using Microsoft.EntityFrameworkCore;
using YohualkisTejada_AP1_P1.Models;

namespace YohualkisTejada_AP1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) 
        : base(options) { }

    public DbSet<Registros> Registros { get; set; }

}
