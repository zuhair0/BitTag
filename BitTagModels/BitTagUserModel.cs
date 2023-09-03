using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class BitTagUserModel
    {
        public Guid userid_fk { get; set; }
        public Guid vehid_fk { get; set; }
        public string bittagcode { get; set; }
    }
}
