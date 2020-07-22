using Domain.Entities.Entities;
using Infrastructure.Persistence.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Commands
{
    public class EditStudentCommand
    {
        public StudentDto StudentDto { get; }
        public EditStudentCommand(StudentDto studentDto)
        {
            StudentDto = studentDto;
        }
    }
}
