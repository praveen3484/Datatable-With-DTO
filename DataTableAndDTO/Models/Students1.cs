using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataTableAndDTO.Models
{
    public class Students1
    {   [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(255, ErrorMessage = "Name field must be less than 255 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(255, ErrorMessage = "Name field must be less than 255 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Roll No is Required")]
        public int RollNo { get; set; }
        [Required]
        public string Standard { get; set; }
        public Students1Details studentdetails { get; set; }


    }
}