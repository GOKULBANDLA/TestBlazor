using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repository
{
   public interface IStudentRepo
    {
        Task<IEnumerable<StudentData>> GetAllStudentInfo();
        Task<Student> GetStudentDetailsById(int id);
        Task<IEnumerable<StudentData>> GetStudentMarksID(int subjectId);

    }
}
