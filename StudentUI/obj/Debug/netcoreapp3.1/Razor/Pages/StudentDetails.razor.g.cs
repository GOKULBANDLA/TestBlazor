#pragma checksum "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d846dbdf79504cab970c797efcefdc50837673d0"
// <auto-generated/>
#pragma warning disable 1591
namespace StudentUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using StudentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using StudentUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Testapplications\StudentUI\StudentUI\_Imports.razor"
using StudentUI.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentDetails/{id}")]
    public partial class StudentDetails : StudentDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
 if (Students.StudentName == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 7 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddAttribute(10, "style", "min-width: 18rem; max-width:70.5%;");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "h1");
            __builder.AddContent(16, 
#nullable restore
#line 16 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                         Students.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-body text-center");
            __builder.AddMarkupContent(21, "\r\n                    <img class=\"card-img-top\" src=\"images/john.png\">\r\n\r\n                    ");
            __builder.OpenElement(22, "h4");
            __builder.AddContent(23, "Student ID : ");
            __builder.AddContent(24, 
#nullable restore
#line 22 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                                      Students.StudentIdID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "h4");
            __builder.AddContent(27, "Age : ");
            __builder.AddContent(28, 
#nullable restore
#line 23 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                               Students.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-footer text-center");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.AddMarkupContent(34, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                                      () => ShowPopup(Students.StudentIdID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-primary m-1");
            __builder.AddMarkupContent(38, "\r\n                        View\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 35 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
 if (show)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
     if (MarksData.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "        <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 41 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal fade show d-block");
            __builder.AddAttribute(47, "id", "exampleModal");
            __builder.AddAttribute(48, "tabindex", "-1");
            __builder.AddAttribute(49, "role", "dialog");
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-dialog");
            __builder.AddAttribute(53, "role", "document");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-content");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-header");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "h5");
            __builder.AddAttribute(62, "class", "modal-title");
            __builder.AddAttribute(63, "id", "exampleModalLabel");
            __builder.AddContent(64, 
#nullable restore
#line 48 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                                                                Students.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "close");
            __builder.AddAttribute(69, "data-dismiss", "modal");
            __builder.AddAttribute(70, "aria-label", "Close");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                                  () => ClosePopup()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.AddMarkupContent(73, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-body");
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "table");
            __builder.AddAttribute(80, "class", "table");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.AddMarkupContent(82, "<thead class=\"thead-dark\">\r\n                        <tr>\r\n                            <th scope=\"col\">Subject</th>\r\n                            <th scope=\"col\">Marks</th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
            __builder.OpenElement(83, "tbody");
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 63 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                         foreach (var item in MarksData.ToList())
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                            ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.OpenElement(88, "td");
            __builder.AddMarkupContent(89, "\r\n                                    ");
            __builder.AddContent(90, 
#nullable restore
#line 67 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                                     item.subject

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(91, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.OpenElement(93, "td");
            __builder.AddMarkupContent(94, "\r\n                                    ");
            __builder.AddContent(95, 
#nullable restore
#line 71 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                                     item.Marks

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(96, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 75 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 84 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\Testapplications\StudentUI\StudentUI\Pages\StudentDetails.razor"
     
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
