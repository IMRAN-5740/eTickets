using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture URL is Recquired")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Recquired")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Bio Grapghy")]
        [Required(ErrorMessage = "Bio Graphy is Recquired")]
        public string Bio { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
