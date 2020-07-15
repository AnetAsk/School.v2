using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;

namespace Infrastructure.Persistence.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _context;
        private readonly IMapper _mapper;

        public CourseRepository(SchoolDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<CourseDto> GetAll()
        {
            var courses = _context.Courses.ToList();

            return _mapper.Map<List<CourseDto>>(courses);
        }
    }
}