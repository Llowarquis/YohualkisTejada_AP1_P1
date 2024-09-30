using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YohualkisTejada_AP1_P1.DAL;
using YohualkisTejada_AP1_P1.Models;

namespace YohualkisTejada_AP1_P1.Services
{
	public class PrestamosService(Contexto contexto)
	{
		private readonly Contexto _contexto = contexto;

		// Guardar
		public async Task<bool> Guardar(Prestamos prestamo)
		{
			if (!await Existe(prestamo.PrestamoId))
				return await Insertar(prestamo);
			else
				return await Modificar(prestamo);
		}

		// Existe
		private async Task<bool> Existe(int id)
		{
			return await _contexto.Prestamos
				.AnyAsync<Prestamos>(t => t.PrestamoId == id);
		}

		// Insertar
		private async Task<bool> Insertar(Prestamos prioridad)
		{
			_contexto.Prestamos.Add(prioridad);
			return await _contexto.SaveChangesAsync() > 0;
		}

		// Modificar
		private async Task<bool> Modificar(Prestamos prioridad)
		{
			_contexto.Prestamos.Update(prioridad);
			return await _contexto.SaveChangesAsync() > 0;
		}

		// Eliminar
		public async Task<bool> Eliminar(int id)
		{
			return await _contexto.Prestamos
				.Where(t => t.PrestamoId == id)
				.AsNoTracking()
				.ExecuteDeleteAsync() > 0;
		}

		// Buscar
		public async Task<Prestamos?> Buscar(int id)
		{
			return await _contexto.Prestamos
				.AsNoTracking()
				.FirstOrDefaultAsync(t => t.PrestamoId == id);
		}

		// Listar
		public async Task<List<Prestamos>> Listar(Expression<Func<Prestamos, bool>> criterio)
		{
			return await _contexto.Prestamos
				.AsNoTracking()
				.Where(criterio)
				.ToListAsync();
		}

		// ExisteDeudor
		public async Task<bool> ExisteDeudor(string? deudor)
		{
			return await _contexto?.Prestamos
				.AnyAsync(e => e.Deudor.Trim().ToLower().Equals(deudor.Trim().ToLower()));
		}
	}
}
