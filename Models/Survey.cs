using System.ComponentModel.DataAnnotations;
namespace DojoSurWithModel.Models
{
    public class Survey
    {
        [Required(ErrorMessage=" Valid Name is required")]
        [Display(Name="Your Name : ")]
        public string YourName {get;set;}

        [Required(ErrorMessage=" Select at Least One Option for Dojo Location")]
        public string DojoLocations {get; set;}

        [Required(ErrorMessage=" Select at Least One Option for Favorite Language")]
        public string FavLang {get;set;}

        public string Comments {get;set;}
    }
}