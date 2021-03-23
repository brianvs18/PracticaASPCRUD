using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaASPCRUD.Models.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        [Column("NombreEmpleado", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public int Documento { get; set; }
        public int Cargo { get; set; }
        public string Telefono { get; set; }
    }
}
