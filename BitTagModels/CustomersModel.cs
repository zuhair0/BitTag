using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class CustomersModel
    {
        public Guid custID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string custCNIC { get; set; }
        public string custEmail { get; set; }
        public string contact { get; set; }
        public DateTime DOB { get; set; }
        public int custPIN { get; set;}
    }
}
