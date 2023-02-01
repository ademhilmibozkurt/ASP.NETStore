#pragma checksum "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca18d1dc76f5c4acce0f5b29bc99656bc4cb757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyStore.Pages.Clients.Pages_Clients_Create), @"mvc.1.0.razor-page", @"/Pages/Clients/Create.cshtml")]
namespace MyStore.Pages.Clients
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
#line 1 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\_ViewImports.cshtml"
using MyStore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca18d1dc76f5c4acce0f5b29bc99656bc4cb757", @"/Pages/Clients/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f20bcdfab133b6ecc62fd859baf09c01713465", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<br>\r\n<h2> New Client </h2>\r\n\r\n");
#nullable restore
#line 10 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
 if(Model.errorMessage.Length >0)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n        <strong>");
#nullable restore
#line 13 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n     </div>\r\n");
#nullable restore
#line 16 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<forn method=\"POST\">\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Name</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 583, "\"", 613, 1);
#nullable restore
#line 22 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 591, Model.clientInfo.name, 591, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Email</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"email\"");
            BeginWriteAttribute("value", " value=\"", 833, "\"", 864, 1);
#nullable restore
#line 29 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 841, Model.clientInfo.email, 841, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Phone</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"phone\"");
            BeginWriteAttribute("value", " value=\"", 1084, "\"", 1115, 1);
#nullable restore
#line 36 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 1092, Model.clientInfo.phone, 1092, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Address</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"address\"");
            BeginWriteAttribute("value", " value=\"", 1339, "\"", 1372, 1);
#nullable restore
#line 43 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 1347, Model.clientInfo.address, 1347, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 47 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
     if (Model.successMessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row-mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                    <strong>");
#nullable restore
#line 52 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
                       Write(Model.successMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 57 "D:\projects\C#\ProjectStore\MyStore\MyStore\Pages\Clients\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
        </div>
    </div>
</forn>

</br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStore.Pages.Clients.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.CreateModel>)PageContext?.ViewData;
        public MyStore.Pages.Clients.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
