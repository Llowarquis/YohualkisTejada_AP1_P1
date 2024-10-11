using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YohualkisTejada_AP1_P1.DAL;
using YohualkisTejada_AP1_P1.Models;

namespace YohualkisTejada_AP1_P1.Services;

public class DeudoresService(Contexto contexto)
{
    private readonly Contexto _contexto = contexto;

    public async Task<List<Deudores>> Listar(Expression<Func<Deudores, bool>> criterio)
    {
        return await _contexto.Deudores
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}
