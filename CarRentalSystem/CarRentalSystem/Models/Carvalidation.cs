using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{

    [MetadataType(typeof(carregMetaData))]
    public partial class carreg
    {
        public class carregMetaData { 
            [DisplayName("CarNo")]
            public int id { get; set; }
            [DisplayName("Car Model")]
            public string CarModel { get; set; }
            [DisplayName("Car Brand")]
            public string CarBrand { get; set; }
            [DisplayName("Car Type")]
            public string CarType { get; set; }
            [DisplayName("Available")]
            public string Available { get; set; }
        }

    }
}