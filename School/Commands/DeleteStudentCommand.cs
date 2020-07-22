using Infrastructure.Persistence.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Commands
{
    public class DeleteStudentCommand
    {
        public StudentDto StudentDto { get; }
        public DeleteStudentCommand(StudentDto studentDto)
        {
            StudentDto = studentDto;
        }
    }
}
