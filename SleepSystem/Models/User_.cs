using System.ComponentModel.DataAnnotations;

namespace SleepSystem.Models
{
    public class User_
    {

        public Guid Id { get; set; }
        public string Name { get; set; }


        public string LastName { get; set; }

        public int Age { get; set; }


        public string Genre { get; set; }


        public string Occupation { get; set; }


        public DateOnly Birth { get; set; }


        public string Mail { get; set; }


        public string Password { get; set; }




    }
}