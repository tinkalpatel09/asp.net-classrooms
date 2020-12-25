using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    [MetadataType(typeof(customerMetaData))]
    public partial class Customer
    {
        public class customerMetaData
        {
            [DisplayName("Customer Name")]
        
            public string CustName { get; set; }
            [DisplayName("Customer Address")]
            public string Address { get; set; }
            [DisplayName("Customer Mobile")]
            public string Mobile { get; set; }
        }
    }
}