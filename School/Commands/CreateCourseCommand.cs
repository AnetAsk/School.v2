using Infrastructure.Persistence.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Commands
{
    public class CreateCourseCommand : IRequest<CourseDto>
    {
        public CourseDto CourseDto { get; }

        public CreateCourseCommand(CourseDto courseDto)
        {
            CourseDto = courseDto;
        }
    }
}