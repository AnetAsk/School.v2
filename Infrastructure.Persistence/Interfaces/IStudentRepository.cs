using System.Collections;
using System.Collections.Generic;
using Domain.Entities.Entities;
using Infrastructure.Persistence.DTO;

namespace Infrastructure.Persistence.Interfaces
{
    public interface IStudentRepository
    {
        // ReturnType Method(InputType)

        StudentDto GetById(int id);

        IList<StudentDto> GetAll();

        StudentDto Create(StudentDto studentDto);

        StudentDto Update(int id, StudentDto studentDto);
        StudentDto Remove(int id);
    }
}