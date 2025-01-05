using System.ComponentModel.DataAnnotations;

namespace שב_4.Controllers.properties
{
    public class Application
    {
        [Key]
        public int appId { get; set; }
        public string Domain{ get; set; }
        public DateTime dateTime { get; set; }
        public string Location { get; set; }
        public int CustID { get; set; }
        //public Customer customer { get; set; }
        public int volId { get; set; }
        public Application(int appId, string domain, DateTime dateTime, string location, int custID, int volId)
        {
            this.appId = appId;
            Domain = domain;
            this.dateTime = dateTime;
            Location = location;
            this.CustID = custID;
            this.volId = volId;
        }
    }
}
