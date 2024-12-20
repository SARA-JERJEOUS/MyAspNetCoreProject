#pragma checksum "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c3eb63c287fa1d73f84dac23995a0192c56b28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c3eb63c287fa1d73f84dac23995a0192c56b28", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd623dedb35a7c814e5f95f54ad8e3c2c508973a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dal.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--");
            WriteLiteral(@"@model Dal.Order
-->
<!-- CSS للتصميم -->
<!--<style>
    body {
        background: linear-gradient(45deg, #8e3d3d, #3b003b);
    }

    /* تنسيق العنوان والجدول */
    h2, h3 {
        color: white;
        font-size: 28px;
        text-align: center;
        margin-bottom: 20px;
    }

    table {
        background: #272727;
        color: white;
        border-radius: 10px;
        overflow: hidden;
        box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.5);
    }

    th, td {
        padding: 12px 20px;
        text-align: left;
        border-bottom: 1px solid #444;
    }

    th {
        background: #4c4c4c;
        font-weight: bold;
    }

    tr:last-child td {
        border-bottom: none;
    }

    .table-hover tr:hover {
        background-color: #505050;
        transition: background 0.3s ease;
    }

    /* زر العودة */
    .btn-back {
        background-color: #0b2644;
        color: white;
        font-size: 18px;
        padding: 10px 20px;
    ");
            WriteLiteral(@"    border-radius: 8px;
        text-decoration: none;
        transition: all 0.3s ease;
    }

    .btn-back:hover {
        background-color: #173a61;
        transform: translateY(-3px);
    }

    /* تنسيق السهم للقائمة */
    .nav-link.dropdown-toggle::after {
        content: ' ▼';
        font-size: 12px;
        margin-left: 5px;
    }

    /* تنسيق نص السائق */
    .driver-details {
        font-size: 18px;
        color: #f8f9fa;
        background-color: #333333;
        padding: 15px;
        border-radius: 10px;
        margin: 20px 0;
        box-shadow: 0px 3px 10px rgba(0, 0, 0, 0.3);
    }
</style>-->
<!-- العنوان -->
<!--<h2>Order Details</h2>-->
<!-- زر العودة إلى القائمة -->
<!--<div class=""d-flex justify-content-end mb-4"">
    <a asp-action=""Index"" class=""btn-back"">Back to List</a>
</div>-->
<!-- تفاصيل الطلب -->
<!--<table class=""table table-hover"">
    <tbody>
        <tr>
            <th>Order ID</th>
            <td>");
#nullable restore
#line 90 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
           Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Order ETA</th>\r\n            <td>");
#nullable restore
#line 94 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
           Write(Model.ETA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Customer Name</th>\r\n            <td>");
#nullable restore
#line 98 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
           Write(Model.Customer_orders.FirstOrDefault()?.Customers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Vehicle Type</th>\r\n            <td>");
#nullable restore
#line 102 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
           Write(Model.VehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Status</th>\r\n            <td>");
#nullable restore
#line 106 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
           Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>-->\r\n<!-- تفاصيل السائق المعين -->\r\n<!--<h3>Assigned Driver</h3>\r\n<div class=\"driver-details\">\r\n    ");
            WriteLiteral("@if (Model.Order_Drivers.Any())\r\n    {\r\n        <p><strong>Driver:</strong> ");
            WriteLiteral("@Model.Order_Drivers.First().Drivers.UserName</p>\r\n        <p><strong>Status:</strong> ");
            WriteLiteral("@(Model.Order_Drivers.First().Drivers.IsAvailable ? \"Available\" : \"Not Available\")</p>\r\n        <p><strong>Vehicle Type:</strong> ");
            WriteLiteral("@Model.Order_Drivers.First().Drivers.VehicleType</p>\r\n    }\r\n    else\r\n    {\r\n        <p>No driver assigned yet.</p>\r\n    }\r\n</div>-->\r\n");
            WriteLiteral(@"

<style>
    body {
        background: #f0f0f0;
    }

    h2, h3 {
        color: green;
        font-size: 40px;
        text-align: center;
        margin: 30px;
    }

    table {
        background: #272727;
        color: white;
        border-radius: 10px;
        overflow: hidden;
        box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.5);
    }

    th, td {
        padding: 12px 20px;
        text-align: left;
        border-bottom: 1px solid #444;
        font-size: 30px
    }

    th {
        background: #4c4c4c;
        font-weight: bold;
        font-size:30px
    }

    tr:last-child td {
        border-bottom: none;
    }

    .table-hover tr:hover {
        background-color: #505050;
        transition: background 0.3s ease;
    }





    .btn-success {
        font-size: 1.60rem;
        background: linear-gradient(145deg, #6eaf4a, #4c9c3e); /* تدرج لوني للزر */
        color: white; /* النص باللون الأبيض */
        border: 2px solid #4c9c3e; ");
            WriteLiteral(@"/* إضافة حد رفيع */
        padding: 12px 24px; /* المسافات حول النص */
        border-radius: 30px; /* زوايا مستديرة بشكل أكبر */
        box-shadow: 3px 3px 6px rgba(0, 0, 0, 0.1), -3px -3px 6px rgba(255, 255, 255, 0.1); /* إضافة ظل ناعم */
        cursor: pointer; /* تغيير المؤشر عند المرور على الزر */
        transition: all 0.4s ease-in-out; /* إضافة تأثيرات انسيابية */
    }

        .btn-success:hover {
            background: linear-gradient(145deg, #4c9c3e, #6eaf4a); /* عكس التدرج اللوني عند التمرير */
            box-shadow: 6px 6px 12px rgba(0, 0, 0, 0.15), -6px -6px 12px rgba(255, 255, 255, 0.15); /* زيادة الظلال */
            transform: translateY(-3px); /* رفع الزر قليلاً عند التمرير */
        }

        .btn-success:active {
            background: #4c9c3e; /* لون ثابت عند الضغط */
            box-shadow: inset 2px 2px 5px rgba(0, 0, 0, 0.2); /* تغيير الظلال لتأثير الضغط */
            transform: translateY(0); /* العودة إلى وضع الزر الطبيعي */
        }

        .btn-succ");
            WriteLiteral("ess:focus {\r\n            outline: none; /* إزالة الحدود عند التركيز */\r\n            box-shadow: 0 0 0 4px rgba(0, 123, 255, 0.5); /* إضافة تأثير ظل عند التركيز */\r\n        }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 768px) {
        button {
            font-size: 0.9rem;
            padding: 8px 16px;
            white-space: nowrap;
        }
    }

    a:hover {
        color: white !important
    }

    .driver-details {
        font-size: 40px;
        color: #f8f9fa;
        background-color: #6eaf4a;
        padding: 70px;
        border-radius: 10px;
        margin: 20px 0;
        text-align:center;
        box-shadow: 0px 3px 10px rgba(0, 0, 0, 0.3);
    }
</style>

<div class=""container"">


    <h2>Order Details</h2>

    <div class=""d-flex justify-content-end mb-4"">
        <a href=""/Home/DashboardAdmin?section=order-management"" class=""btn btn-success""> Back to order</a>
    </div>

    <table class=""table table-hover"">
        <tbody>
            <tr>
                <th>Order ID</th>
                <td>");
#nullable restore
#line 239 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
               Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Order ETA</th>\r\n                <td>");
#nullable restore
#line 243 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
               Write(Model.ETA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Customer Name</th>\r\n                <td>");
#nullable restore
#line 247 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
               Write(Model.Customer_orders.FirstOrDefault()?.Customers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Vehicle Type</th>\r\n                <td>");
#nullable restore
#line 251 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
               Write(Model.VehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <th>Status</th>\r\n                <td>");
#nullable restore
#line 255 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
               Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <h3> Driver Details</h3>\r\n    <div class=\"driver-details \" >\r\n");
#nullable restore
#line 262 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
         if (Model.Order_Drivers.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><strong>Driver:</strong> ");
#nullable restore
#line 264 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
                                   Write(Model.Order_Drivers.First().Drivers.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><strong>Status:</strong> ");
#nullable restore
#line 265 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
                                    Write(Model.Order_Drivers.First().Drivers.IsAvailable ? "Available" : "Not Available");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><strong>Vehicle Type:</strong> ");
#nullable restore
#line 266 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
                                         Write(Model.Order_Drivers.First().Drivers.VehicleType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 267 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No driver assigned yet.</p>\r\n");
#nullable restore
#line 271 "C:\Users\Q4C\Desktop\x\towing_services\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dal.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591