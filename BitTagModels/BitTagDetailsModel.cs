﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitTagModels
{
    public class BitTagDetailsModel
    {
        public Guid tagID { get; set; }
        public string tagSerial { get; set; }
        public Guid custID_FK { get; set; }
        public Guid orgId { get; set; }
    }
}
