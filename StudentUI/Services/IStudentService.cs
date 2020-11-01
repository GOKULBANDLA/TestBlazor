using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentUI.Services
{
   public interface IStudentService
    {
        Task<IEnumerable<StudentData>> GetAllStudentInfo();
        Task<Student> GetStudentDetailsById(int id);
        Task<IEnumerable<StudentData>> GetStudentMarksID(int subjectId);
    }
}
