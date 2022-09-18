#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ff0d4fb43f273eb3d70f43ee09c18389a20e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ff0d4fb43f273eb3d70f43ee09c18389a20e0a", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c878a4dde8217cd85fc7e8addac3066483a2a7de", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yorum Listesi</h4>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th> # </th>
                            <th> Adı Soyadı </th>
                            <th> Başlık </th>
                            <th> Açıklama </th>
                            <th> Puan </th>
                            <th> Tarih </th>
                            <th> Blog </th>
                            <th> Aktif Yap </th>
                            <th> Pasif Yap </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 32 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 33 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 34 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 35 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 36 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.BlogScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 37 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 38 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                                Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1654, "\"", 1706, 3);
            WriteAttributeValue("", 1661, "/Admin/Comment/CommentActive/", 1661, 29, true);
#nullable restore
#line 40 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 1690, item.CommentID, 1690, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1705, "/", 1705, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Seçilen Yorum Aktif Edildi.');""
                                       class=""btn btn-inverse-success btn-rounded"">Aktif Yap</a>
                                </td>
                                <td>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1979, "\"", 2033, 3);
            WriteAttributeValue("", 1986, "/Admin/Comment/CommenttPassive/", 1986, 31, true);
#nullable restore
#line 44 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2017, item.CommentID, 2017, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2032, "/", 2032, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                       id=""DeleteBtn"" onclick=""return confirm('Seçilen Yorum Pasif Edildi.');"" class=""btn btn-inverse-danger btn-rounded"">Pasif Yap</a>
                                </td>
                               
                            </tr>
");
#nullable restore
#line 49 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 55 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Comment\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591