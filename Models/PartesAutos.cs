using System.ComponentModel.DataAnnotations;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace firstApplication.Models
{   [Authorize]
    public class PartesAutos
    {
        
        //definicion de las propiedades
        [Key]
        
        public int PartId{get;set;}
        
        [Required(ErrorMessage = "Recipe Is Required!")]
        [Display(Name ="Nombre de la receta")]
        public string ParteNombre{get;set;}
        
        [Required(ErrorMessage = "Recipe type Is Required!")]
        [Display(Name ="Tipo de la receta")]
        [StringLength(20)]
        public string ParteModelo{get;set;}
    
        [Required(ErrorMessage = "Recipe Ingredients are Required!")]
        [Display(Name ="Ingredientes de la receta")]
        [StringLength(150)]
        public int PartePrecio{get;set;}
        
       
    }
}