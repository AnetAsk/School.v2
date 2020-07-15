using System.Collections.Generic;
using Infrastructure.Persistence.DTO;

namespace Infrastructure.Persistence.Interfaces
{
    public interface ICourseRepository
    {
        IList<CourseDto> GetAll();
    }
}