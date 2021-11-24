using System.ComponentModel.DataAnnotations;
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace firstApplication.Models
{   [Authorize]
    public class Recipes
    {
        
        //definicion de las propiedades
        [Key]
        
        public int RecId{get;set;}
        
        [Required(ErrorMessage = "Recipe Is Required!")]
        [Display(Name ="Nombre de la receta")]
        public string RecNombre{get;set;}
        
        [Required(ErrorMessage = "Recipe type Is Required!")]
        [Display(Name ="Tipo de la receta")]
        [StringLength(20)]
        public string RecTipo{get;set;}
    
        [Required(ErrorMessage = "Recipe Ingredients are Required!")]
        [Display(Name ="Ingredientes de la receta")]
        [StringLength(150)]
        public string RecIngredientes{get;set;}
        
        [Required(ErrorMessage = "Recipe Autor Is Required!")]
        [Display(Name ="Autor de la receta")]
        public string RecAutor{get;set;}
    }
}

/*"Server=localhost;Database=Recetas;Uid=root;Pwd=usbw;SSL Mode=None"*/