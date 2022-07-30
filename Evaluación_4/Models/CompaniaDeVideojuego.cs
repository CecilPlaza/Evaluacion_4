using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluación_4.Models
{
    [Table("CompaniaVideojuego")]
    public class CompaniaDeVideojuego
    {
        public int Id { get; set; }
        public string NombreCompania { get; set; }
        public DateTime Fundado { get; set; }
        public bool? DominaMercado { get; set; } 
        public int AnioIndustria { get; set; }
        

        //Relación
        public virtual ICollection<Videojuego> Videojuegos { get; set; }
    }
    
}
