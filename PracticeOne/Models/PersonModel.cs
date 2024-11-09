using System.ComponentModel.DataAnnotations;

namespace PracticeOne.Models
{
    public class PersonModel
    {
        public int Opmode { get; set; }
        public int ID { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public long PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public int? Age { get; set; }
    }
}
