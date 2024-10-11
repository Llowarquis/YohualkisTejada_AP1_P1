using System.ComponentModel.DataAnnotations;

namespace YohualkisTejada_AP1_P1.Models;

public class Deudores
{
    [Key]
    public int DeudorId { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]

    public string? Nombres { get; set; }
}
