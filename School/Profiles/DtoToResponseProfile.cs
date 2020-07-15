using System;
using AutoMapper;
using Infrastructure.Persistence.DTO;
using School.Responses;

namespace School.Profiles
{
    public class DtoToResponseProfile : Profile
    {
        public DtoToResponseProfile()
        {
            CreateMap<StudentDto, StudentResponse>()
                .ForMember(c => c.StudentDto,
                    opt => opt.MapFrom(c => c));
        }
    }
}