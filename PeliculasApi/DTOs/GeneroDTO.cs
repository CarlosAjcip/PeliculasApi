using System.ComponentModel.DataAnnotations;

namespace PeliculasApi.DTOs
{
    public class GeneroDTO : GeneroCreacionDTO
    {
        [Key]
        public int Id { get; set; }
    }
}
