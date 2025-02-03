using System.ComponentModel.DataAnnotations;

namespace CarsVolunteer.Core.Entities
{
    public class Volunteer
    {
        [Key]
        public int volId { get; set; }
        public string volName { get; set; }
        public string volPhone { get; set; }
        public string volDomain { get; set; }
        public bool volStatus { get; set; }
        public virtual List<Customer> customers { get; set; }
        // public Application Application { get; set; }
        //public Volunteer( string volName, string volPhone, int carNum, string volDomain, bool volStatus)
        //{
        //    //this.volId = volId;
        //    this.volName = volName;
        //    this.volPhone = volPhone;
        //    this.carNum = carNum;
        //    this.volDomain = volDomain;
        //    this.volStatus = volStatus;
        //}
        //public Volunteer()
        //{

        //}
    }
}
