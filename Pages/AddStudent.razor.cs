using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS276.Models;
using BlazorUAS276.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUAS276.Pages
{
    public partial class AddStudent
      {

      public Student Student { get; set; } = new Student();

          [Inject]
          public IStudentService StudentService { get; set; }
          [Inject]
          public NavigationManager NavigationManager { get; set; }
          public List <Student> Students { get; set; } = new List<Student>();
          [Parameter]
          public string Id { get; set; }
          
          protected async override Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAll()).ToList();
        }

         protected async Task HandleValidSubmit(){
           // var result = await StudentService.tambah(Student);
            NavigationManager.NavigateTo("studentpage");
        }
      }
}