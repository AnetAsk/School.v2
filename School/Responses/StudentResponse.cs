using System.Net;
using Infrastructure.Persistence.DTO;

namespace School.Responses
{
    public class StudentResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public StudentDto StudentDto { get; set; }
        public string ErrorMessage { get; set; }
    }
}