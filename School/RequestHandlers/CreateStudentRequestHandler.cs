using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using School.Commands;

namespace School.RequestHandlers
{
    public class CreateStudentRequestHandler : IRequestHandler<CreateStudentCommand, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<CreateStudentRequestHandler> _logger;

        public CreateStudentRequestHandler(IStudentRepository studentRepository, ILogger<CreateStudentRequestHandler> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        public async Task<StudentDto> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {

            var result = _studentRepository.Create(request.StudentDto);

            if (result == null)
            {
                _logger.LogError("Not created");
            }

            return result;
        }
    }
}