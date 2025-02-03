using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core.DTOs
{
    public class ApplicationDTO
    {
        public int appId { get; set; }
        public string Domain { get; set; }
        public DateTime dateTime { get; set; }
        public string Location { get; set; }
        public int CustomerId { get; set; }
    }
}
