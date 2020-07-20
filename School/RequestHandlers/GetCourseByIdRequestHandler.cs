using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using MediatR;
using School.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace School.RequestHandlers
{
    public class GetCourseByIdRequestHandler : IRequestHandler<GetCourseByIdRequest, CourseDto>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCourseByIdRequestHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public async Task<StudentDto> Handle(GetCourseByIdRequest request, CancellationToken cancellationToken)
        {
            var result = _courseRepository.GetById(request.CourseId);

            return result;
        }
    }
}