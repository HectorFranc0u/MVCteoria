using System;

namespace firstApplication.Models
{
    public class Author
    {
        //definir propiedades
        [Key]
        public int authorID {get; set;}

        [Required(ErrorMessage="Firstname is required!")]
        [Display(Name="Firstname")]

        public string firstname {get; set;}
        [Required(ErrorMessage="Lastname is required!")]
        [Display(Name="Lastname")]

        public string lastname {get; set;}
        [Required(ErrorMessage="Email is required!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email",  Prompt="email@domain.com")]

         public string email {get; set;}
        [Required(ErrorMessage="Gender is required!")]
        [Display(Name="Gender")]

         public string gender {get; set;}
        [Required(ErrorMessage="Address is required!")]
        [Display(Name="Address")]
        [StringLength(100)]
         public string address {get; set;}

         public ICollection<Country> Countries {get; set;} = new List<Country>();

    
    }
}