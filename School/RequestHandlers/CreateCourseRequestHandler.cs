using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using School.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace School.RequestHandlers
{
    public class CreateCourseRequestHandler : IRequestHandler<CreateCourseCommand, CourseDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ILogger<CreateCourseRequestHandler> _logger;

        public CreateCourseRequestHandler(ICourseRepository courseRepository, ILogger<CreateCourseRequestHandler> logger)
        {
            _courseRepository = courseRepository;
            _logger = logger;
        }

        public async Task<CourseDto> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {

            var result = _courseRepository.Create(request.CourseDto);

            if (result == null)
            {
                _logger.LogError("Not created");
            }

            return result;
        }
    }
}