#pragma checksum "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeTechnology.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0715700ef98bf9807b541df1a8a98bbfb75cad3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeTechnology), @"mvc.1.0.view", @"/Views/Employee/EmployeeTechnology.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0715700ef98bf9807b541df1a8a98bbfb75cad3b", @"/Views/Employee/EmployeeTechnology.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47eea1922208144dd7d3bcabcbb8389cbd4f7504", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeTechnology : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeLinqTest.Models.JoinModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n\r\n    <table class=\"table table-dark\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">Name</th>\r\n      <th scope=\"col\">Technology</th>\r\n      </tr>\r\n      </thead>\r\n      <tbody>\r\n\r\n");
#nullable restore
#line 16 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeTechnology.cshtml"
           foreach(var tech in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n      <th scope=\"row\">");
#nullable restore
#line 19 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeTechnology.cshtml"
                 Write(tech.employeeModel.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 20 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeTechnology.cshtml"
     Write(tech.emptechnology.EmpTechnology);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 22 "D:\EmployeeLinqTest\EmployeeLinqTest\EmployeeLinqTest\Views\Employee\EmployeeTechnology.cshtml"

      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </table>\r\n      </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeLinqTest.Models.JoinModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591