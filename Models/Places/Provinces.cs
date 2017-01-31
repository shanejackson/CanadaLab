using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab03.Models.Places
{
    public class Provinces
    {   [Key]
        [Display(Name = "Province Code")]
        public string ProvinceCode { get; set; }
        [Display(Name = "Province")]
        public string ProvinceName { get; set; }

        public List<Cities> MyProperty { get; set; }
    }
}