using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HotelRooms.Data.Entities
{
    public class AppUser : AppModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

        [JsonIgnore]
        [MaxLength(128)]
        public string Password { get; set; }

        public AppUser()
        {

        }

        public AppUser(string email, string hash)
        {
            this.Email = email;
            this.Password = hash;
        }
    }
}