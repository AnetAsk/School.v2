using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using MediatR;
using School.Requests;

namespace School.RequestHandlers
{
    public class GetSchoolRequestHandler : IRequestHandler<GetSchoolRequest, SchoolDto>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _coursesRepository;

        public GetSchoolRequestHandler(IStudentRepository studentRepository, ICourseRepository coursesRepository)
        {
            _studentRepository = studentRepository;
            _coursesRepository = coursesRepository;
        }

        public async Task<SchoolDto> Handle(GetSchoolRequest request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();
            var courses = _coursesRepository.GetAll();

            var schoolDto = new SchoolDto()
            {
                Students = students,
                Courses = courses
            };

            return schoolDto;
        }
    }
}