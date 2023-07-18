using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class Orgnization_EmployeeModel
    {
        public Guid orgID_FK { get; set; }
        public Guid Emp_ID { get; set; }
        public string Emp_firstName { get; set; }
        public string Emp_lastName { get; set; }
        public string Emp_CNIC { get; set; }
        public int Pin { get; set; }
        public string Designation { get; set; }
        public string PhoneNum { get; set; }


    }
}
