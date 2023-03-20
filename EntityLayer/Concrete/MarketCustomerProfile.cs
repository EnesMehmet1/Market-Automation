﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MarketCustomerProfile
    {
        [Key]
        public int marketCustomerProfileID { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public DateTime memberDate { get; set; }
    }
}
