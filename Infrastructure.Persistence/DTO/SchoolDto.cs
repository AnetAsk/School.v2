using System.Collections;
using System.Collections.Generic;
using Domain.Entities.Entities;

namespace Infrastructure.Persistence.DTO
{
    public class SchoolDto
    {
        public IList<StudentDto> Students { get; set; }
        public IList<CourseDto> Courses { get; set; }
    }
}