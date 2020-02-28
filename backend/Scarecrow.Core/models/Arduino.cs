using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Scarecrow.Core
{
    [Table("Dato")]
    public class Arduino
    {
        public object Datos;

        [Key]
        public int Id { get; set; }

        public int ChipId { get; set; }

        //Distancia
        [Required(ErrorMessage = "La distancia es obligatoria")]
        [StringLength(20, ErrorMessage = "La ditancia no puede ser mayor a 20 caracteres")]
        public float Distancia { get; set; }

        //Hora
        [Required(ErrorMessage = "El campo hora es obligatorio")]
        [StringLength(10, ErrorMessage = "El campo hora debe de tener menos de 8 caracteres")]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        //Fecha
        [Required(ErrorMessage = "El campo fecha es obligatorio")]
        [StringLength(12, ErrorMessage = "El campo fecha debe de tener menos de 12 caracteres")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
    }
}