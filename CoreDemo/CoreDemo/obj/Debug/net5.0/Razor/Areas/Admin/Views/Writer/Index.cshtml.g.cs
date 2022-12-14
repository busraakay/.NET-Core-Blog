#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a63095ae0718efc44deab83a8859eae73d1da475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
#line 1 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63095ae0718efc44deab83a8859eae73d1da475", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c878a4dde8217cd85fc7e8addac3066483a2a7de", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Writer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar Listesi</h4>
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th> # </th>
                            <th> Ad?? Soyad?? </th>
                            <th> Hakk??nda </th>
                            <th> Resim </th>
                            <th> Mail </th>
                            <th> Aktif Yap </th>
                            <th> Pasif Yap </th>
                            <th> D??zenle </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 28 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 31 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                                Write(item.WriterID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 32 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                                Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 33 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                                Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                               Write(item.WriterImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                               Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                 <td><a");
            BeginWriteAttribute("href", " href=\"", 1436, "\"", 1485, 3);
            WriteAttributeValue("", 1443, "/Admin/Writer/WriterActive/", 1443, 27, true);
#nullable restore
#line 36 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
WriteAttributeValue("", 1470, item.WriterID, 1470, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1484, "/", 1484, 1, true);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Se??ilen Yazar Aktif Edildi.\');\"\r\n                                     class=\"btn btn-inverse-success btn-rounded\">Aktif Yap</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1684, "\"", 1734, 3);
            WriteAttributeValue("", 1691, "/Admin/Writer/WriterPassive/", 1691, 28, true);
#nullable restore
#line 38 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
WriteAttributeValue("", 1719, item.WriterID, 1719, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1733, "/", 1733, 1, true);
            EndWriteAttribute();
            WriteLiteral(" \r\n                                       id=\"DeleteBtn\" onclick=\"return confirm(\'Se??ilen Yazar Aktif Edildi.\');\" class=\"btn btn-inverse-danger btn-rounded\">Pasif Yap</a></td>\r\n                                  <td><a");
            BeginWriteAttribute("href", " href=\"", 1952, "\"", 1999, 3);
            WriteAttributeValue("", 1959, "/Admin/Writer/EditWriter/", 1959, 25, true);
#nullable restore
#line 40 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
WriteAttributeValue("", 1984, item.WriterID, 1984, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1998, "/", 1998, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-inverse-warning btn-rounded\">D??zenle</a></td>    \r\n                                   </tr>\r\n");
#nullable restore
#line 42 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            ");
#nullable restore
#line 48 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Writer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
