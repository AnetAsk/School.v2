using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Entities.Entities;
using MediatR;
using School.Requests;
using Infrastructure.Persistence.DTO;
using School.Commands;

namespace School.Controllers
{
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoursesController(IMediator mediator)
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
            var request = new GetCourseByIdRequest(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CourseDto courseDto)
        {
            var createCourseCommand = new CreateCourseCommand(courseDto);
            var response = await _mediator.Send(createCourseCommand);
            return Ok(response);
        }
    }
}

