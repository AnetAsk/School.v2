using Infrastructure.Persistence.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Commands
{
    public class DeleteCourseCommand
    {
        public StudentDto StudentDto { get; }
        public DeleteCourseCommand(StudentDto studentDto)
        {
            StudentDto = studentDto;
        }
    }
}
