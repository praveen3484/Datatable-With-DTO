//using DataTableAndDTO.Models;
//using AutoMapper;
//using System;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web.Http;
//using DataTableAndDTO.DTO;

//namespace DataTableAndDTO.Controllers
//{
//    public class StudentController : ApiController
//    {
//        private StudentContext context;
//        public StudentController()
//        {
//            context = new StudentContext();
//        }

//        // GET /api/customers
//        public IHttpActionResult GetCustomers(string query = null)
//        {
//            var customersQuery = context.Students1
//                .Include(c => c.studentdetails);

//            if (!String.IsNullOrWhiteSpace(query))
//                customersQuery = customersQuery.Where(c => c.FirstName.Contains(query));

//            var customerDtos = customersQuery
//                .ToList()
//                .Select(Mapper.Map<Students1, StudentDto>);

//            return Ok(customerDtos);
//        }

//        // GET /api/customers/1
//        public IHttpActionResult GetCustomer(int id)
//        {
//            var stud = context.Students1.SingleOrDefault(c => c.Id == id);

//            if (stud == null)
//                return NotFound();

//            return Ok(Mapper.Map<Students1, StudentDto>(stud));
//        }


//        // POST /api/customers
//        [HttpPost]
//        public IHttpActionResult CreateCustomer(StudentDto studentDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();

//            var student = Mapper.Map<StudentDto, Students1>(studentDto);
//            context.Students1.Add(student);
//            context.SaveChanges();

//            studentDto.Id = student.Id;
//            return Created(new Uri(Request.RequestUri + "/" + student.Id), studentDto);
//        }


//        // PUT /api/customers/1
//        [HttpPut]
//        public IHttpActionResult UpdateCustomer(int id, StudentDto studentDto)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();

//            var studentInDb = context.Students1.SingleOrDefault(c => c.Id == id);

//            if (studentInDb == null)
//                return NotFound();

//            Mapper.Map(studentDto, studentInDb);

//            context.SaveChanges();

//            return Ok();
//        }

//    }
//}
