using EntityLayer;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentContext studentContext;
        public StudentRepo(StudentContext context)
        {
            this.studentContext = context;
        }
        public async Task<IEnumerable<StudentData>> GetAllStudentInfo()
        {
            var students = (from student in studentContext.Students
                            join sub in studentContext.Subjects on student.subjectId equals sub.subjectId
                            select new StudentData
                            {
                                 StudentIdID = student.StudentIdID,
                                Age = student.Age,
                                ID = student.ID,
                                Marks = student.Marks,
                                StudentName = student.StudentName,
                                subject = sub.subject
                            }).ToList();
            var groupedData = students.GroupBy(l => new { l.StudentIdID }).Select(cl => new StudentData
            {
                Age = cl.FirstOrDefault().Age,
                StudentName = cl.FirstOrDefault().StudentName,
                Marks = cl.FirstOrDefault().Marks,
                StudentIdID = cl.FirstOrDefault().StudentIdID,
                subject = cl.First().subject
            }).ToList();
            return await Task.FromResult(groupedData);
        }

        public async Task<Student> GetStudentDetailsById(int id)
        {
            var student = studentContext.Students.Where(x => x.StudentIdID == id).ToList();
            if (student.Count > 0)
            {
                return await Task.FromResult(student[0]);
            }
            else
            {
                return await Task.FromResult(new Student());
            }
           
        }

        public async Task<IEnumerable<StudentData>> GetStudentMarksID(int studentID)
        {
            var students = (from student in studentContext.Students
                            join sub in studentContext.Subjects on student.subjectId equals sub.subjectId
                            where student.StudentIdID == studentID
                            select new StudentData
                            {
                                Age = student.Age,
                                StudentIdID = student.StudentIdID,
                                Marks = student.Marks,
                                StudentName = student.StudentName,
                                subject = sub.subject
                            }).ToList();
       
            List<StudentData> result = students.GroupBy(l => new { l.subject}).Select(cl => new StudentData
      {
        Marks = cl.Sum(c => c.Marks),
        StudentName = cl.FirstOrDefault().StudentName,
        StudentIdID = cl.FirstOrDefault().StudentIdID,
        subject = cl.First().subject
      }).ToList();
            return await Task.FromResult(result);
        }
    }
}
