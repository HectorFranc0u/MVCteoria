using System.ComponentModel.DataAnnotations;
using System;
using System.Diagnostics;

namespace firstApplication.Models
{
    public class Professor
    {
        //definicion de las propiedades
        [Key]
        
        public int ProfesorId{get;set;}
        
        [Required(ErrorMessage = "Name Is Required!")]
        [Display(Name ="Nombre del Profesor")]
        public string ProfesorNombre{get;set;}
        
        [Required(ErrorMessage = "LastName Is Required!")]
        [Display(Name ="Apellido del Professor")]
        [StringLength(20)]
        public string ProfesorApellido{get;set;}
    
        [Required(ErrorMessage = "Title Is Required!")]
        [Display(Name ="Titulo del Profesor")]
        [StringLength(150)]
        public string ProfesorTitulo{get;set;}
        
        [Required(ErrorMessage = "Workplace Is Required!")]
        [Display(Name ="Lugar de Trabajo")]
        public string ProfesorLugadeTrabajo{get;set;}
    }
}

/*"Server=localhost;Database=Recetas;Uid=root;Pwd=usbw;SSL Mode=None"*/