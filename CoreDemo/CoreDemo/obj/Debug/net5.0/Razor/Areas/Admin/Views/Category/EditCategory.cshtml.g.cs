#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff812ac5f8745806ff95651814ca39822bf5009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_EditCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/EditCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff812ac5f8745806ff95651814ca39822bf5009", @"/Areas/Admin/Views/Category/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c878a4dde8217cd85fc7e8addac3066483a2a7de", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
  
    ViewData["Title"] = "EditCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Kategori Düzenle</h4>\r\n");
#nullable restore
#line 16 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
             using (Html.BeginForm("EditCategory", "Category", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Kategori ID</label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
               Write(Html.TextBoxFor(x => x.CategoryID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Kategori Adı</label>\r\n                    ");
#nullable restore
#line 24 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
               Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
               Write(Html.ValidationMessageFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Kategori Açıklaması</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
               Write(Html.TextAreaFor(x => x.CategoryDescription, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
               Write(Html.ValidationMessageFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary me-2\">Güncelle</button>\r\n");
#nullable restore
#line 33 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Category\EditCategory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591