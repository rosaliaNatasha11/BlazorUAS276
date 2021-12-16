using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS276.Models;
using BlazorUAS276.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUAS276.Pages
{
    public partial class StudentPage
    {
        public List<Student> Student { get; set; } = new List<Student>();

        [Inject]
        public IStudentService StudentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = (await StudentService.GetAll()).ToList();
        }
    }
}