using Infrastructure.Persistence.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Commands
{
    public class EditCourseCommand
    {
        public StudentDto StudentDto { get; }
        public EditCourseCommand(StudentDto studentDto)
        {
            StudentDto = studentDto;
        }
    }
}
