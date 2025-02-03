using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core.DTOs
{
    public class CustomerDTO
    {
        public int castId { get; set; }
        public string castName { get; set; }
        public string castPhone { get; set; }
        public string castEmail { get; set; }
        public string castAddress { get; set; }
        public int VolunteerId { get; set; }
    }
}
