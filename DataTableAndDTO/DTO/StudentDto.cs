using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataTableAndDTO.DTO
{
    public class StudentDto
    {
        [Key]
        public int Id { get; set; }
       
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
     
        public int RollNo { get; set; }
     
        public string Standard { get; set; }
        public StudentDetailsDto studentdetails { get; set; }
    }
}