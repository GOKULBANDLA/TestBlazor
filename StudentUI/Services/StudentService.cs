using EntityLayer;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentUI.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            
        }

        public async Task<IEnumerable<StudentData>> GetAllStudentInfo()
        {
            return await httpClient.GetJsonAsync<IEnumerable<StudentData>>("api/Students");
        }

        public async Task<Student> GetStudentDetailsById(int id)
        {
            return await httpClient.GetJsonAsync<Student>($"api/Students/{id}");
        }

        public async Task<IEnumerable<StudentData>> GetStudentMarksID(int id)
        {
            return await httpClient.GetJsonAsync<IEnumerable<StudentData>>($"api/Students/getmarks/{id}");
        }
    }
}
