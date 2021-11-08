using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    [Table("Paciente")]// EF cuando crea la tabla la llama Paciente en signular sino por convension pluraliza el nombre "Pacientes"
    public class Paciente
    {
        public int Id { get; set; }

        [Required] // Not Null
        [Column(TypeName = "varchar")] //Tipo de dato de SQL SERVER
        [MaxLength(50)] // Hasta 50
        public string Nombre { get; set; }

        [Required] // Not Null
        [Column(TypeName = "varchar")] //Tipo de dato de SQL SERVER
        [MaxLength(50)] // Hasta 50
        public string Apellido { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FechaNacimiento { get; set; }
        public int NroHistoriaClinica { get; set; }
        public int MedicoID { get; set; } //FK clave externa

        //Propiedad de Navegacion
        [ForeignKey("MedicoID")]
        public Medico Medico { get; set; }
    }
}
