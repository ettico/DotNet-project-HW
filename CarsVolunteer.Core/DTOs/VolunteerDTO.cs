using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core.DTOs
{
    public class VolunteerDTO
    {
        public int volId { get; set; }
        public string volName { get; set; }
        public string volPhone { get; set; }
        public string volDomain { get; set; }
        public bool volStatus { get; set; }
    }
}
