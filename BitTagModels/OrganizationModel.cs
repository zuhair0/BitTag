using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class OrganizationModel
    {
        public Guid orgID { get; set; }
        public string orgName { get; set; }
        public string orgType { get; set; }
        public string orgAddress { get; set; }
        public int orgCapacity { get; set; }
    }
}
