#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc3d9e5df6a27147d5501e0083306e83cfb5424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc3d9e5df6a27147d5501e0083306e83cfb5424", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac82c3bbfca83888214775683b20655a0c3863c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazarın Blogları</h4>
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>
                                #
                            </th>
                            <th>
                                Blog Başlığı
                            </th>
                            <th>
                                Oluşturma Tarihi
                            </th>
                            <th>
                                Kategori
                            </th>
                            <th>
                                Durum
                            </th>
                            <th>
                                Sil
                            </th>
                            <th>
    ");
            WriteLiteral("                            Düzenle\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                         foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 44 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <td>\r\n                                ");
#nullable restore
#line 47 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 50 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                            Write(((DateTime)item.BlogCreateDate).ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 53 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2149, "\"", 2185, 2);
            WriteAttributeValue("", 2156, "/Blog/DeleteBlog/", 2156, 17, true);
#nullable restore
#line 59 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 2173, item.BlogID, 2173, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\" class=\"btn btn-danger\">Sil</a>\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2400, "\"", 2434, 2);
            WriteAttributeValue("", 2407, "/Blog/EditBlog/", 2407, 15, true);
#nullable restore
#line 62 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 2422, item.BlogID, 2422, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <a href=\"/Blog/BlogAdd/\" class=\"btn btn-success m-2\">Yeni Blog Oluştur</a>\r\n        </div>\r\n    </div>\r\n</div>");
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