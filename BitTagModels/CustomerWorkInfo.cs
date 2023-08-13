using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class CustomerWorkInfo
    {
        public Guid org_FK { get; set; }
        public Guid userID_FK { get; set; }
        public string WorkType { get; set; }
        public string Desig { get; set; }
        public DateTime worktime { get; set; }
    }
}
