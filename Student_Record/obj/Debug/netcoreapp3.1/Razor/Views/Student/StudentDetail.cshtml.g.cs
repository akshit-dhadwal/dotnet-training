#pragma checksum "C:\Users\Akshit Dadhwal\Desktop\Student_Record\Views\Student\StudentDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b76ec4da64525e8c22d8c5c7b1bdc156ed1ed34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentDetail), @"mvc.1.0.view", @"/Views/Student/StudentDetail.cshtml")]
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
#line 1 "C:\Users\Akshit Dadhwal\Desktop\Student_Record\Views\_ViewImports.cshtml"
using Student_Record;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akshit Dadhwal\Desktop\Student_Record\Views\_ViewImports.cshtml"
using Student_Record.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b76ec4da64525e8c22d8c5c7b1bdc156ed1ed34", @"/Views/Student/StudentDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a112099eb08d395fe83232cba11be76103ecb56a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h2><b>Student Details</b></h2>\r\n\r\n");
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 12 "C:\Users\Akshit Dadhwal\Desktop\Student_Record\Views\Student\StudentDetail.cshtml"
Write(Html.Partial("_Students", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
