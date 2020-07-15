using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using MediatR;
using School.Requests;

namespace School.RequestHandlers
{
    public class GetStudentByIdRequestHandler : IRequestHandler<GetStudentByIdRequest, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdRequestHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public async Task<StudentDto> Handle(GetStudentByIdRequest request, CancellationToken cancellationToken)
        {
            var result = _studentRepository.GetById(request.StudentId);

            return result;
        }
    }
}