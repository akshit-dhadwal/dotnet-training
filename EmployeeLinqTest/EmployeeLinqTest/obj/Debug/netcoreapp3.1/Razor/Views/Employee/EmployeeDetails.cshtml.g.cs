#pragma checksum "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a814ad5329ba25b0336a9049ff6504b61d7d9101"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeDetails), @"mvc.1.0.view", @"/Views/Employee/EmployeeDetails.cshtml")]
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
#line 1 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\_ViewImports.cshtml"
using EmployeeLinqTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\_ViewImports.cshtml"
using EmployeeLinqTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a814ad5329ba25b0336a9049ff6504b61d7d9101", @"/Views/Employee/EmployeeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47eea1922208144dd7d3bcabcbb8389cbd4f7504", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n     <div class=\"row\">\r\n           <ul class=\"list-group\">\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Name - </span>");
#nullable restore
#line 6 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                    Write(Model.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Age - </span>");
#nullable restore
#line 7 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                   Write(Model.EmpAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Email - </span>");
#nullable restore
#line 8 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                     Write(Model.EmpEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Father Name - </span>");
#nullable restore
#line 9 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                           Write(Model.EmpFathername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Mother Name - </span>");
#nullable restore
#line 10 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                           Write(Model.EmpMothername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Salary - </span>");
#nullable restore
#line 11 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                      Write(Model.EmpSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Gender - </span>");
#nullable restore
#line 12 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeDetails.cshtml"
                                                                                      Write(Model.EmpGender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n     </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
