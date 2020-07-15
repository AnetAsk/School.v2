using Infrastructure.Persistence.DTO;
using MediatR;

namespace School.Requests
{
    public class GetStudentByIdRequest : IRequest<StudentDto>
    {
        public int StudentId { get; }

        public GetStudentByIdRequest(int id)
        {
            StudentId = id;
        }
    }
}