using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Commands;
using School.Requests;
using School.Responses;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new GetSchoolRequest();
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var request = new GetStudentByIdRequest(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Create(StudentDto studentDto)
        {
            var createStudentCommand = new CreateStudentCommand(studentDto);
            var response = await _mediator.Send(createStudentCommand);
            return Ok(response);
        }

        //[HttpPut("{id}")]
        //public IActionResult Edit(int id, [FromBody] StudentDto studentDto)
        //{
        //    var result = _studentRepository.Update(id, studentDto);

        //    if (result == null)
        //    {
        //        _logger.LogError("Not updated");
        //    }

        //    return Ok(result);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var result = _studentRepository.Remove(id);

        //    return Ok(result);
        //}


        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var result = _studentRepository.GetById(id);

        //    var response = new StudentResponse();

        //    if (result != null)
        //    {
        //        response = _mapper.Map<StudentResponse>(result);
        //        response.StatusCode = HttpStatusCode.OK;
        //    }
        //    else
        //    {
        //        response.StatusCode = HttpStatusCode.NotFound;
        //        response.ErrorMessage = "Student Not Found!";
        //    }

        //    return new JsonResult(response);
        //}
    }
}
