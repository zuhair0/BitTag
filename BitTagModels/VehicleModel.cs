using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class VehicleModel
    {
        public Guid custID_FK { get; set; }
        public Guid tagID { get; set; }
        public Guid vehicleID { get; set; }
        public string vehiclePlate { get; set; }
        public string vehicleMake { get; set; }
        public int vehicleModel { get; set; }
        public string vehicleType { get; set; }
        public string vehicleColor { get; set; }
    }
}
