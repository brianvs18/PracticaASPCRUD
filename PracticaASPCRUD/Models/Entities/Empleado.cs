using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaASPCRUD.Models.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        //Instrucciones para la BD        
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El documento es obligatorio")]
        public int Documento { get; set; }
        [DisplayName("Cargo del Empleado")]
        public int Cargo { get; set; }
        public string Telefono { get; set; }
    }
}
