using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentasId { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Total { get; set; }

        // propiedades de navegacion
        public List<DetallesdelaVenta> Detalles { get; set; }
    }
}