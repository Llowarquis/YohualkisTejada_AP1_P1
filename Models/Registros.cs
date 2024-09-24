using System.ComponentModel.DataAnnotations;

namespace YohualkisTejada_AP1_P1.Models;

public class Registros
{
    [Key]
    public int RegistroId { get; set; }

    public string? Nombre { get; set; }
}
