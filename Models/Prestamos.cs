using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YohualkisTejada_AP1_P1.Models;

public class Prestamos
{
	[Key]
	public int PrestamoId { get; set; }

	[RegularExpression(@"^[a-zA-Z-ÁáÉéÍíÓóÚúÑñ\s]+$", ErrorMessage = "Este campo solo puede alojar letras/espacios.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string? Nombres { get; set; }

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string? Concepto { get; set; }

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	[RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Este campo solo puede alojar números.")]
	public double Monto { get; set; }

	[ForeignKey("DeudorId")]
	public int DeudorId { get; set; }

	public Deudores? Deudor { get; set; }
}
