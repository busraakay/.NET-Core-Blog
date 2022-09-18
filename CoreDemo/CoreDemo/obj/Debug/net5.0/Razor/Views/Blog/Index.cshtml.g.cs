#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba13182ee3aed813501597da345208225064acc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba13182ee3aed813501597da345208225064acc4", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""py-5 bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <h1>Bloglar</h1>
            </div>
        </div>
    </div>
</div>

<div class=""site-section bg-white"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 mb-4\">\n                    <div class=\"entry2\">\n                        <a");
            BeginWriteAttribute("href", " href=\"", 592, "\"", 629, 2);
            WriteAttributeValue("", 599, "/Blog/BlogReadAll/", 599, 18, true);
#nullable restore
#line 24 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 617, item.BlogID, 617, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 635, "\"", 656, 1);
#nullable restore
#line 24 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 641, item.BlogImage, 641, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid rounded\"></a>\n                        <div class=\"excerpt\">\n                            <span class=\"post-category text-white bg-primary mb-3\">");
#nullable restore
#line 26 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n                            <h2><a");
            BeginWriteAttribute("href", " href=\"", 900, "\"", 937, 2);
            WriteAttributeValue("", 907, "/Blog/BlogReadAll/", 907, 18, true);
#nullable restore
#line 28 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 925, item.BlogID, 925, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                            <div class=\"post-meta align-items-center text-left clearfix\">\n                                <figure class=\"author-figure mb-0 mr-3 float-left\"><img");
            BeginWriteAttribute("src", " src=\"", 1141, "\"", 1171, 1);
#nullable restore
#line 30 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1147, item.Writer.WriterImage, 1147, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid\"></figure>\n                                <span class=\"d-inline-block mt-1\"><a href=\"#\">");
#nullable restore
#line 31 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                         Write(item.Writer.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\n                                <span>&nbsp;-&nbsp; ");
#nullable restore
#line 32 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                Write(((DateTime)item.BlogCreateDate).ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </div>\n\n                            <p>");
#nullable restore
#line 35 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                          Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1637, "\"", 1674, 2);
            WriteAttributeValue("", 1644, "/Blog/BlogReadAll/", 1644, 18, true);
#nullable restore
#line 36 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1662, item.BlogID, 1662, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Devamını Oku</a></p>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 40 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""row text-center pt-5 border-top"">
            <div class=""col-md-12"">
                <div class=""custom-pagination"">
                    <span>1</span>
                    <a href=""#"">2</a>
                    <a href=""#"">3</a>
                    <a href=""#"">4</a>
                    <span>...</span>
                    <a href=""#"">15</a>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591