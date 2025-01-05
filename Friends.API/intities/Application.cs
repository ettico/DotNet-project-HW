namespace שב_4.Controllers.properties
{
    public class Application
    {
        public int appId { get; set; }
        public string Domain{ get; set; }
        public DateTime dateTime { get; set; }
        public string Location { get; set; }
        public int custID { get; set; }
        public int volId { get; set; }
        public Application(int appId, string domain, DateTime dateTime, string location, int custID, int volId)
        {
            this.appId = appId;
            Domain = domain;
            this.dateTime = dateTime;
            Location = location;
            this.custID = custID;
            this.volId = volId;
        }
        public Application()
        {

        }
    }
}
