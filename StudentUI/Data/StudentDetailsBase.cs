using EntityLayer;
using Microsoft.AspNetCore.Components;
using StudentUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentUI.Data
{
    public class StudentDetailsBase : ComponentBase
    {
        [Inject]
        public IStudentService StudentService { get; set; }
        public Student Students { get; set; } = new Student();
        public StudentData StudentData { get; set; } = new StudentData();
        public List<StudentData> MarksData { get; set; } = new List<StudentData>();

        [Parameter]
        public string Id { get; set; }
        public bool show = false;
        protected  override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Students = (await StudentService.GetStudentDetailsById(int.Parse(Id)));
        }
        protected async Task ShowPopup(int Id)
        {
            show = true;
            MarksData = (List<StudentData>)(await StudentService.GetStudentMarksID(Id));
        }
        protected async Task ClosePopup()
        {
            show = false;
        }
    }
}
