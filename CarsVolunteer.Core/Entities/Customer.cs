using System.ComponentModel.DataAnnotations;

namespace CarsVolunteer.Core.Entities
{
    public class Customer
    {
        [Key]
        public int castId { get; set; }
        public string castName { get; set; }
        public string castPhone { get; set; }
        public string castEmail { get; set; }
        public string castAddress { get; set; }
        public int VolunteerId { get; set; }
        public virtual Volunteer Volun { get; set; }
        public List<Application> applications { get; set; }
        //public Customer( string castName, string castPhone, string castEmail, string castAddress)
        //{
        //   // this.castId = castId;
        //    this.castName = castName;
        //    this.castPhone = castPhone;
        //    this.castEmail = castEmail;
        //    this.castAddress = castAddress;
        //}
        //public Customer()
        //{

        //}
    }
}
