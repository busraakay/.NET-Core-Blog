#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1b2381f6c41b4f12d83105804fbe8b59d903cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b2381f6c41b4f12d83105804fbe8b59d903cf2", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Blog Düzenle</h4>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
             using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Blog ID</label>\r\n                    ");
#nullable restore
#line 16 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.TextBoxFor(x => x.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Blog Başlığı</label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.ValidationMessageFor(x => x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Blog Görseli</label>\r\n                    ");
#nullable restore
#line 25 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Blog Küçük Görsel</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Kategorisi</label>\r\n                    ");
#nullable restore
#line 33 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Blog İçeriği</label>\r\n                    ");
#nullable restore
#line 37 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.TextAreaFor(x => x.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
               Write(Html.ValidationMessageFor(x => x.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-success mr-2\">Güncelle</button>\r\n");
#nullable restore
#line 41 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
