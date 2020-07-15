using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Entities;
using Infrastructure.Persistence.DTO;
using Infrastructure.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(SchoolDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public StudentDto GetById(int id)
        {
            var student = _context.Students.Find(id);
            return _mapper.Map<StudentDto>(student);
        }

        public IList<StudentDto> GetAll()
        {
            var allStudents = _context.Students.ToList();
            var studentsDto = _mapper.Map<List<StudentDto>>(allStudents);

            return studentsDto;
        }

        public StudentDto Create(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);

            var savedStudentEntry = _context.Students.Add(student);
            _context.SaveChanges();

            return _mapper.Map<StudentDto>(savedStudentEntry.Entity);
        }

        public StudentDto Update(int id, StudentDto studentDto)
        {
            var student = _context.Students.Find(id);

            student.Name = studentDto.Name;

            //_context.Entry(student).State = EntityState.Modified;
            _context.Students.Update(student);
            _context.SaveChanges();

            return _mapper.Map<StudentDto>(student);
        }

        public StudentDto Remove(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return _mapper.Map<StudentDto>(student);
        }
    }
}