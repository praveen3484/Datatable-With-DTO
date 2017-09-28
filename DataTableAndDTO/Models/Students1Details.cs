using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataTableAndDTO.Models
{
    public class Students1Details
    {
        
        public int Id { get; set; }
        public string Address { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        
    }
}