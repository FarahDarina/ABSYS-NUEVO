using System;
using System.ComponentModel.DataAnnotations;

namespace ABSYS.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        // Campos obligatorios
        [Required]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; } = DateTime.Today.AddYears(-18);

        [Required]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        public string Sexo { get; set; } = string.Empty;

        [Required]
        public string CURP { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Carrera { get; set; } = string.Empty;

        [Required]
        public bool EsBecado { get; set; }

        [Required]
        public string Modalidad { get; set; } = string.Empty;

        // Campos opcionales
        public string? DescripcionPersonal { get; set; }

        public bool TieneMascotas { get; set; } = false;

        public string? TipoMascotas { get; set; }

        public TimeOnly? HorarioComida { get; set; }

        // Eliminación lógica
        public bool Eliminado { get; set; } = false;
    }
}


