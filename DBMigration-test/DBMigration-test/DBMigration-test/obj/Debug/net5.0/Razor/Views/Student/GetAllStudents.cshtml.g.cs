#pragma checksum "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "103d82e62bae75236dc123dc015909bd3ea0082a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetAllStudents), @"mvc.1.0.view", @"/Views/Student/GetAllStudents.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\_ViewImports.cshtml"
using DBMigration_test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\_ViewImports.cshtml"
using DBMigration_test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"103d82e62bae75236dc123dc015909bd3ea0082a", @"/Views/Student/GetAllStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a619598ebdf276f0c3ca64457e2ccf7a50667fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetAllStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBMigration_test.Context.Studentcs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
  
    ViewData["Title"] = "GetAllStudents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetAllStudents</h1>\r\n\r\n<div class=\"container\">\r\n     <h3 class=\"h3\">All Students</h3>\r\n           <div class=\"row\"> \r\n");
#nullable restore
#line 11 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
             foreach (var student in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"col mb-4\">\r\n                 <div class=\"card\" style=\"width: 18rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 414, "\"", 442, 1);
#nullable restore
#line 15 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
WriteAttributeValue("", 420, student.CoverImageUrl, 420, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" alt=\"...\">\r\n                    <div class=\"card-body\">\r\n                      <h5 class=\"card-title\">Id - ");
#nullable restore
#line 17 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
                                             Write(student.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                      <p class=\"card-text\">Name - ");
#nullable restore
#line 18 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
                                             Write(student.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                       <p class=\"card-text\">Age - ");
#nullable restore
#line 19 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
                                             Write(student.StudentAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("                    </div>\r\n                  </div>\r\n              </div>\r\n");
#nullable restore
#line 25 "D:\DBMigration-test\DBMigration-test\DBMigration-test\Views\Student\GetAllStudents.cshtml"
            
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </div>\r\n              </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBMigration_test.Context.Studentcs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
