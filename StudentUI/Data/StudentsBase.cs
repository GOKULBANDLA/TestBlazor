using EntityLayer;
using Microsoft.AspNetCore.Components;
using StudentUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentUI.Data
{
    public class StudentsBase : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }
        public IEnumerable<StudentData> Students { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAllStudentInfo()).ToList();
        }

    }
}
