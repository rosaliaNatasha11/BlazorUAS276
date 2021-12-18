using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS276.Models;
using BlazorUAS276.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUAS276.Pages
{
    public partial class DeleteStudent
      {
            [Parameter]
          public string Id { get; set; }

             [Inject]
          public IStudentService StudentService { get; set; }

            [Inject]
          public NavigationManager NavigationManager { get; set; }
           protected async override Task OnInitializedAsync()
        {
            //await StudentService.Delete(String.Format(id));
            NavigationManager.NavigateTo("/studentpage");
        }

      }
}