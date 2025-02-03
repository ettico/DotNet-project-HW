using System.ComponentModel.DataAnnotations;

namespace CarsVolunteer.Core.Entities
{
    public class Application
    {
        [Key]
        public int appId { get; set; }
        public string Domain { get; set; }
        public DateTime dateTime { get; set; }
        public string Location { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        //public int volId { get; set; }
        // public Volunteer volunteer { get; set; }
        //public Application( string domain, DateTime dateTime, string location, int custID, int volId)
        //{
        //    //this.appId = appId;
        //    Domain = domain;
        //    this.dateTime = dateTime;
        //    Location = location;
        //    this.CustID = custID;
        //    this.volId = volId;
        //}
    }
}
