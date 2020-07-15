using Infrastructure.Persistence.DTO;
using MediatR;

namespace School.Commands
{
    public class CreateStudentCommand : IRequest<StudentDto>
    {
        public StudentDto StudentDto { get; }

        public CreateStudentCommand(StudentDto studentDto)
        {
            StudentDto = studentDto;
        }
    }
}