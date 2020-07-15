using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _studentRepository.GetAll();

            return Ok(result);
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
    }
}
