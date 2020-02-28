using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Scarecrow.Core
{
    [Table("Usuarios")]
    public class Registro
    {
        public object Usuarios;

        [Key]
        public int Id { get; set; }

        //Nombre
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo nombre tiene una longitud de 20 caracteres")]
        [DataType(DataType.Text)]
        public String Nombre { get; set; }

        //Apellido
        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo apellido tiene una longitud de 20 caracteres")]
        [DataType(DataType.Text)]
        public String Apellido { get; set; }

        //Correo
        [Required(ErrorMessage = "El campo correo es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo correo tiene una longitud de 50 caracteres")]
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }

        //Password
        [Required(ErrorMessage = "El campo password es obligatorio")]
        [StringLength(15, ErrorMessage = "El campo password tiene una longitud de 10 caracteres")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}