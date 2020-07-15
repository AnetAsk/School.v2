using AutoMapper;
using Domain.Entities.Entities;
using Infrastructure.Persistence.DTO;

namespace School.Profiles
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<StudentDto, Student>();
        }
    }
}