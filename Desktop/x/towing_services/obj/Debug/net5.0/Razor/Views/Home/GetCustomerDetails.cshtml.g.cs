#pragma checksum "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\GetCustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4d29526c0ddfc111f38be14ef02d8eb26d775f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCustomerDetails), @"mvc.1.0.view", @"/Views/Home/GetCustomerDetails.cshtml")]
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
#line 1 "C:\Users\Q4C\Desktop\x\towing_services\Views\_ViewImports.cshtml"
using towing_services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Q4C\Desktop\x\towing_services\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d29526c0ddfc111f38be14ef02d8eb26d775f6", @"/Views/Home/GetCustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd623dedb35a7c814e5f95f54ad8e3c2c508973a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dal.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p><strong>Name:</strong> ");
#nullable restore
#line 3 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\GetCustomerDetails.cshtml"
                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><strong>Phone:</strong> ");
#nullable restore
#line 4 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\GetCustomerDetails.cshtml"
                      Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><strong>Email:</strong> ");
#nullable restore
#line 5 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\GetCustomerDetails.cshtml"
                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><strong>Address:</strong> ");
#nullable restore
#line 6 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\GetCustomerDetails.cshtml"
                        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><strong>Message:</strong> ");
#nullable restore
#line 7 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\GetCustomerDetails.cshtml"
                        Write(Model.Message_or_inquiry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dal.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
