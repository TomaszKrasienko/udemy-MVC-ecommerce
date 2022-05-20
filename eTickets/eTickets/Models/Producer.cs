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
        public string ProfilePictureUrl { get; set; }
        [Display(Name="Full name")]
        public string FullName { get; set; }
        [Display(Name="Biography")]
        public string Bio { get; set; }
        //Relationships 
        public List<Movie> Movies { get; set; }
    }
}