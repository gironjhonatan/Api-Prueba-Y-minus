using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Agrega esta directiva

namespace WebAPIPrueba.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public required string Codigo { get; set; }
        
        [Required]
        public required string Nombre { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        [Required]
        public required List<int> ListaDePrecios { get; set; }

        public string Imagen { get; set; } = string.Empty;

        [Required]
        public bool ProductoParaLaVenta { get; set; } 

        public decimal PorcentajeIva { get; set; }
    }
}
