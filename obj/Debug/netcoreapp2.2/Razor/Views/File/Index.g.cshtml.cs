#pragma checksum "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/File/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b1eebabf51292e26c33045235e1c6044adcda4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Index), @"mvc.1.0.view", @"/Views/File/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/File/Index.cshtml", typeof(AspNetCore.Views_File_Index))]
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
#line 1 "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/_ViewImports.cshtml"
using lab;

#line default
#line hidden
#line 2 "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/_ViewImports.cshtml"
using lab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b1eebabf51292e26c33045235e1c6044adcda4", @"/Views/File/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a525c2b9f5b4e11df46e2eb0b985798acb8afdb3", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/File/Index.cshtml"
  
    ViewData["Title"] = "Index page";
    var files = ViewData ["files"] as string[];

#line default
#line hidden
            BeginContext(95, 77, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Index</h1>\r\n    <ul>\r\n");
            EndContext();
#line 9 "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/File/Index.cshtml"
         foreach (var item in files) {

#line default
#line hidden
            BeginContext(212, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(229, 4, false);
#line 10 "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/File/Index.cshtml"
           Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(233, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "/Users/zhangyuanyuan/Desktop/Term4/4976ASP.NET /0916/lab/Views/File/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(251, 21, true);
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
