using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPGetRate
{
    public class Rate
    {
        private String ServiceType;
        private String TransitDay;
        private String RegularPrice;

        public Rate()
        {
        }

        public Rate(string serviceType, string transitDay, string regularPrice)
        {
            ServiceType = serviceType;
            TransitDay = transitDay;
            RegularPrice = regularPrice;
        }

        public string ServiceType1 { get => ServiceType; set => ServiceType = value; }
        public string TransitDay1 { get => TransitDay; set => TransitDay = value; }
        public string RegularPrice1 { get => RegularPrice; set => RegularPrice = value; }
    }
}