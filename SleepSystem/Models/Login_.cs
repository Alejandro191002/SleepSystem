using System.ComponentModel.DataAnnotations;

namespace SleepSystem.Models
{
    public class Login_
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }


    }
}
