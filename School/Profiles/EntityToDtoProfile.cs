using AutoMapper;
using Domain.Entities.Entities;
using Infrastructure.Persistence.DTO;

namespace School.Profiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Course, CourseDto>();
        }
    }
}