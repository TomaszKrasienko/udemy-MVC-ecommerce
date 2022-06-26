using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Profile picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name="Full name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name="Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //Relationships 
        public List<Movie> Movies { get; set; }
    }
}