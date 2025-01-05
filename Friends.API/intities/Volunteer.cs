namespace שב_4.Controllers.properties
{
    public class Volunteer
    {
        public int volId { get; set; }
        public  string volName { get; set; }
        public string volPhone { get; set; }
        public int carNum { get; set; }
        public string volDomain { get; set; }
        public bool volStatus { get; set; }
        public Volunteer(int volId, string volName, string volPhone, int carNum, string volDomain, bool volStatus)
        {
            this.volId = volId;
            this.volName = volName;
            this.volPhone = volPhone;
            this.carNum = carNum;
            this.volDomain = volDomain;
            this.volStatus = volStatus;
        }
        public Volunteer()
        {

        }
    }
}
