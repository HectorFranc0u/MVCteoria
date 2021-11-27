using System;

namespace firstApplication.Models
{
    public class Country
    {
        //definir propiedades
        public int countryID {get; set;}


        /// <summary>
        /// /name
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage="Name is required")]
        [Display(Name="Name")]


        public string Name {get; set;}
        /// <summary>
        /// /end name
        /// </summary>
        /// <value></value>


        /// <summary>
        /// /population
        /// </summary>
        /// <value></value>
        [Required(ErrorMessage="Population is required")]
        [Display(Name="Population")]

        public string Population {get; set;}
        /// <summary>
        /// /end population
        /// </summary>
        /// <value></value>

        //referencias para author
        [Required(ErrorMessage="Author is required")]
        [Display(Name="Author")]
        
        public int authorID {get; set;}
        public Author Authors {get; set;}
    }
}