using System.Collections.Generic;
using Infrastructure.Persistence.DTO;

namespace Infrastructure.Persistence.Interfaces
{
    public interface ICourseRepository
    {
        CourseDto GetById(int id);
        IList<CourseDto> GetAll();
        CourseDto Create(CourseDto courseDto);
        CourseDto Update(int id, CourseDto courseDto);
        CourseDto Remove(int id);
    }
}