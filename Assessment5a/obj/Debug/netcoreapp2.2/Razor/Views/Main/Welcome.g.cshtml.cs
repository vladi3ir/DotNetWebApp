#pragma checksum "C:\Users\vladi3ir\source\repos\Assessment5a\Assessment5a\Views\Main\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5325482461a43a11b8e1d58fd075273094fa1cbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Welcome), @"mvc.1.0.view", @"/Views/Main/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Welcome.cshtml", typeof(AspNetCore.Views_Main_Welcome))]
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
#line 1 "C:\Users\vladi3ir\source\repos\Assessment5a\Assessment5a\Views\_ViewImports.cshtml"
using Assessment5a;

#line default
#line hidden
#line 2 "C:\Users\vladi3ir\source\repos\Assessment5a\Assessment5a\Views\_ViewImports.cshtml"
using Assessment5a.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5325482461a43a11b8e1d58fd075273094fa1cbc", @"/Views/Main/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da9dbc8cb16282f0ecfebc35a1338fc8e77bbd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assessment5a.Models.MainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vladi3ir\source\repos\Assessment5a\Assessment5a\Views\Main\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(87, 14, true);
            WriteLiteral("\r\n<h1>Welcome ");
            EndContext();
            BeginContext(102, 20, false);
#line 7 "C:\Users\vladi3ir\source\repos\Assessment5a\Assessment5a\Views\Main\Welcome.cshtml"
       Write(Model.Name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(122, 10, true);
            WriteLiteral(" </h1>\r\n\r\n");
            EndContext();
            BeginContext(141, 17, false);
#line 10 "C:\Users\vladi3ir\source\repos\Assessment5a\Assessment5a\Views\Main\Welcome.cshtml"
Write(Model.Name.Length);

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assessment5a.Models.MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
