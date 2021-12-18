using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS276.Models;
using BlazorUAS276.Services;
using Microsoft.AspNetCore.Components;


namespace BlazorUAS276.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
         public string id { get; set; }
         [Inject]
         public IStudentService StudentService { get; set; }
         public Student Student { get; set; } = new Student();

         protected override async Task OnInitializedAsync()
          {
             id = id ?? "1";
             Student = await StudentService.GetById(String.Format(id));
         }
    }
}