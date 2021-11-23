using System.ComponentModel.DataAnnotations;
using System;
using System.Diagnostics;

namespace firstApplication.Models
{
    public class Professor
    {
        //definicion de las propiedades
        [Key]
         public int ProfessorId{get;set;}
        
        [Required(ErrorMessage = "Name Is Required!")]
        [Display(Name ="Nombre del Profesor")]
        public string ProfessorNombre{get;set;}
        
        [Required(ErrorMessage = "LastName Is Required!")]
        [Display(Name ="Apellidos del Profesor")]
        [StringLength(75)]
        public string ProfessorApellidos{get;set;}
    
        [Required(ErrorMessage = "Title Is Required!")]
        [Display(Name ="Titulo del Profesor")]
        [StringLength(100)]
        public string ProfessorTitulo{get;set;}
        
        [Required(ErrorMessage = "Workplace Is Required!")]
        [Display(Name ="Lugar de Trabajo del Profesor")]
        public string ProfessorLugardeTrabajo{get;set;}
    }
}