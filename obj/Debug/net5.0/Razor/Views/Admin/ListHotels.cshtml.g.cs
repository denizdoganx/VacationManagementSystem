#pragma checksum "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363af32bd9fae2ac5add219f88b0a43ea2ff7d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListHotels), @"mvc.1.0.view", @"/Views/Admin/ListHotels.cshtml")]
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
#line 1 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\_ViewImports.cshtml"
using VacationManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\_ViewImports.cshtml"
using VacationManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\_ViewImports.cshtml"
using VacationManagementSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363af32bd9fae2ac5add219f88b0a43ea2ff7d64", @"/Views/Admin/ListHotels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19f9feb0fb39d336f72a3ec63974213d84f379d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListHotels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hotel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
  
    ViewBag.Title = "HotelAdminPanel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
  
    Layout = "~/Views/Shared/_HotelAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Total Room Number</th>\r\n        <th>Total Star Number</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
           Write(item.totalRoomNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
           Write(item.totalStarNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 611, "\"", 648, 2);
            WriteAttributeValue("", 618, "/Admin/UpdateHotel?id=", 618, 22, true);
#nullable restore
#line 30 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
WriteAttributeValue("", 640, item.ID, 640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Update</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\deniz\source\repos\VacationManagementSystem\Views\Admin\ListHotels.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hotel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
