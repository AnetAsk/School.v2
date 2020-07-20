using Infrastructure.Persistence.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Requests
{
    public class GetCourseByIdRequest : IRequest<CourseDto>
    {
        public int CourseId { get; }

        public GetCourseByIdRequest(int id)
        {
            CourseId = id;
        }
    }
}