using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Mvc;

namespace MVC6_Example.Models
{
    public class ExampleViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}