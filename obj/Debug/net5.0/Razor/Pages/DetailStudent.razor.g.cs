#pragma checksum "C:\blazor\BlazorUAS276\Pages\DetailStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da45679ac007367c9031eefb7a439e0c4414f923"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUAS276.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\blazor\BlazorUAS276\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\blazor\BlazorUAS276\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\blazor\BlazorUAS276\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\blazor\BlazorUAS276\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\blazor\BlazorUAS276\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\blazor\BlazorUAS276\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\blazor\BlazorUAS276\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\blazor\BlazorUAS276\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\blazor\BlazorUAS276\_Imports.razor"
using BlazorUAS276;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\blazor\BlazorUAS276\_Imports.razor"
using BlazorUAS276.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailstudent/{id}")]
    public partial class DetailStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Detail Student 0276</h3>\r\n");
            __builder.OpenElement(1, "tr");
            __builder.AddContent(2, "Student Id : ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\blazor\BlazorUAS276\Pages\DetailStudent.razor"
                  Student.studentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "tr");
            __builder.AddContent(6, "Last Name : ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\blazor\BlazorUAS276\Pages\DetailStudent.razor"
                 Student.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "tr");
            __builder.AddContent(10, "First Name : ");
            __builder.AddContent(11, 
#nullable restore
#line 6 "C:\blazor\BlazorUAS276\Pages\DetailStudent.razor"
                  Student.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "tr");
            __builder.AddContent(14, "Enrollment Date : ");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\blazor\BlazorUAS276\Pages\DetailStudent.razor"
                       Student.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.AddMarkupContent(17, "<tr><td><a href=\"studentpage\" class=\"btn btn-primary m-1\">Back</a>\r\n        <a href=\"#\" class=\"btn btn-secondary m-1\">Edit</a></td></tr>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
