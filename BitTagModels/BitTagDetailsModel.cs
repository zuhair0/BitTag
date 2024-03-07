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
        public int? tagSerial { get; set; }
        public string QRcode { get; set; }
        public Guid orgId { get; set; }
        public Guid vehicleID { get; set; }
        public Guid custID_FK { get; set; }
        public string vehiclePlate { get; set; }
        public string vehicleMake { get; set; }
        public int vehicleModel { get; set; }
        public string vehicleType { get; set; }
        public string vehicleColor { get; set; }
	}
}
