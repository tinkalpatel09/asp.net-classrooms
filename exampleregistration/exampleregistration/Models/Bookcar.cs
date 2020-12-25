using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exampleregistration.Models
{
    public class Bookcar
    {
        public int carid { get; set; }

        public int custid { get; set; }
        public string custname { get; set; }
        public string cartype { get; set; }
        public double Prize { get; set; }
        public string PickupLoc { get; set; }

        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int age { get; set; }
      //  public int qty { get; set; }
        public float bill { get; set; }

    }
}