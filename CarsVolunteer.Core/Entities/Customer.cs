using System.ComponentModel.DataAnnotations;

namespace שב_4.Controllers.properties
{
    public class Customer
    {
        [Key]
        public int castId { get; set; }
        public string castName { get; set; }
        public string castPhone { get; set; }
        public string  castEmail{ get; set; }
        public string castAddress { get; set; }
        public Customer(int castId, string castName, string castPhone, string castEmail, string castAddress)
        {
            this.castId = castId;
            this.castName = castName;
            this.castPhone = castPhone;
            this.castEmail = castEmail;
            this.castAddress = castAddress;
        }
        //public Customer()
        //{

        //}
    }
}
