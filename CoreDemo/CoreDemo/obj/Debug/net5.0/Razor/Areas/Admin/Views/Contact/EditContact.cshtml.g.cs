#pragma checksum "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7003edab987c107e3488404fd3d7072901f5082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_EditContact), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/EditContact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7003edab987c107e3488404fd3d7072901f5082", @"/Areas/Admin/Views/Contact/EditContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c878a4dde8217cd85fc7e8addac3066483a2a7de", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_EditContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
  
    ViewData["Title"] = "EditContact";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
  
    ViewData["Title"] = "AddContact";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">İletişim Düzenle</h4>\r\n");
#nullable restore
#line 16 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
             using (Html.BeginForm("EditContact", "Contact", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Contact ID</label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextBoxFor(x => x.ContactID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Yazar Adı</label>\r\n                    ");
#nullable restore
#line 24 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextBoxFor(x => x.ContactUserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.ValidationMessageFor(x => x.ContactUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>İletişim Maili</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextAreaFor(x => x.ContactMail, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.ValidationMessageFor(x => x.ContactMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>İletişim Hakkında</label>\r\n                    ");
#nullable restore
#line 34 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextAreaFor(x => x.ContactSubject, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.ValidationMessageFor(x => x.ContactSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>İletişim Mesajı</label>\r\n                    ");
#nullable restore
#line 39 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextAreaFor(x => x.ContactMessage, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.ValidationMessageFor(x => x.ContactMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>İletişim Tarihi</label>\r\n                    ");
#nullable restore
#line 44 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextAreaFor(x => x.ContactDate, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.ValidationMessageFor(x => x.ContactDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>İletişim Durumu</label>\r\n                    ");
#nullable restore
#line 49 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.TextAreaFor(x => x.ContactStatus, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
               Write(Html.ValidationMessageFor(x => x.ContactStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary me-2\">Güncelle</button>\r\n");
#nullable restore
#line 53 "C:\Users\busra\Downloads\CoreDemo2\CoreDemo\CoreDemo\Areas\Admin\Views\Contact\EditContact.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591