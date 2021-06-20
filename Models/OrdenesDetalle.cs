using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidos.Models
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id { get; set; }

        public int OrdenId { get; set; }

        public int Cantidad { get; set; }

        public float Costo { get; set; }
    }
}
