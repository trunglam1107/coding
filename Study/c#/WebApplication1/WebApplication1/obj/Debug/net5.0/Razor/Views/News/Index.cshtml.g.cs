#pragma checksum "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bb3f0450e9f3d3e168b042f96f336ee07438479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bb3f0450e9f3d3e168b042f96f336ee07438479", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApplication1.Controllers.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
  
    ViewData["Title"] = "News Homepage";
    Layout = "_Layout";

    //var articles = ViewBag.Article;

    //var articles = ViewData["Articles"] as List<WebApplication1.Controllers.Article>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    News Listing\r\n</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Title</th>\r\n            <th>Content</th>\r\n            <th>Author</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
         foreach (var article in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
               Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
               Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
               Write(article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
               Write(article.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "D:\Coding\Study\c#\WebApplication1\WebApplication1\Views\News\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApplication1.Controllers.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
