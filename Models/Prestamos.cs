using System.ComponentModel.DataAnnotations;

namespace YohualkisTejada_AP1_P1.Models;

public class Prestamos
{
	[Key]
	public int PrestamoId { get; set; }

	[RegularExpression(@"^[a-zA-Z-ÁáÉéÍíÓóÚúÑñ\s]+$", ErrorMessage = "Este campo solo puede alojar letras/espacios.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string? Deudor { get; set; }

	[RegularExpression(@"^[a-zA-Z-ÁáÉéÍíÓóÚúÑñ\s]+$", ErrorMessage = "Este campo solo puede alojar letras/espacios.")]
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string? Concepto { get; set; }

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	[RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Este campo solo puede alojar números.")]
}
