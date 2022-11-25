using System.ComponentModel.DataAnnotations;

namespace PeliculasApi.DTOs
{
    public class ActorDTO
    {
        [Key]
        public int IdAutor { get; set; }
        [Required]
        [StringLength(120)]
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public string Foto { get; set; }
    }
}
