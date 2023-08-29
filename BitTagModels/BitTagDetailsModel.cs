using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class BitTagDetailsModel
    {
        public Guid tagID { get; set; }
        public int tagSerial { get; set; }
        public string QRcode { get; set; }
        public Guid orgId { get; set; }
    }
}
