using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TareaHelpers.Datos.Models.BindingModels
{

   

    public class RegistroUsuariosBindingModel
    {
        /*[Range(10,11, ErrorMessage ="debe de ser de 11 caracteres")]*/
        [Required(ErrorMessage ="Introduzca una CEDULA y que solo sea numeros por favor")]
        [Display(Name = "Cedula")]
        public long Cedula { get; set; }

        [Required(ErrorMessage = "Introduzca un NOMBRE por favor")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Introduzca un APELLIDO por favor")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "Introduzca un GENERO por favor")]
        [Display(Name = "Sexo")]
        public Gender Sexo { get; set; }


        [Required(ErrorMessage = "Introduzca una ocupacion por favor")]
        [Display(Name = "Ocupacion")]
        public string Ocupacion { get; set; }


        [Required(ErrorMessage = "Introduzca un HOBBY por favor")]
        [Display(Name = "Hobby")]
        public bool CheckBox { get; set; }

        [Required(ErrorMessage ="debe de poner un correo")]
        [Display(Name ="Correo")]
        [EmailAddress(ErrorMessage ="Este correo no es valido, ponga un correo que sea valido")]
        public string Correo { get; set; }

        [Display(Name ="Edad")]
        [Required(ErrorMessage ="debe de poner su edad")]
        [Range(15,99, ErrorMessage ="Debe de tener mas de 15")]
        public long Edad { get; set; }


        [Display(Name ="Telefono")]
        [Required(ErrorMessage ="ponga su telefono")]
        
        [DataType(DataType.PhoneNumber, ErrorMessage ="Ponga un numero de 10 digito")]
        public long Telefono { get; set; }

        

       



    }

  


    public enum Gender
    {
        Hombre,
        Mujer
        
    }


    


}
