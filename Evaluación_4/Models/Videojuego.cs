using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluación_4.Models
{
    [Table("Videojuego")]
    public class Videojuego
    {
        public int Id { get; set; }
        public int Compania_id { get; set; }
        public string NombreVideojuego { get; set; }
        public int CopiasVendidas { get; set; } 
        public virtual CompaniaDeVideojuego CompaniaDeVideojuegos { get; set; }
    }
}
