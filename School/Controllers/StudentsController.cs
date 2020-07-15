using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Responses;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private IMapper _mapper;

        public StudentsController(IStudentRepository studentRepository, 
            IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _studentRepository.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _studentRepository.GetById(id);

            var response = new StudentResponse();

            if (result != null)
            {
                response = _mapper.Map<StudentResponse>(result);
                response.StatusCode = HttpStatusCode.OK;
            }
            else
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ErrorMessage = "Student Not Found!";
            }

            return new JsonResult(response);
        }


        [HttpPost]
        public IActionResult Create(StudentDto studentDto)
        {
            var result = _studentRepository.Create(studentDto);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody] StudentDto studentDto)
        {
            var result = _studentRepository.Update(id, studentDto);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _studentRepository.Remove(id);

            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var result = _studentRepository.GetById(id);

        //    return Ok(result);
        //}

    }
}
