#pragma checksum "E:\DollsWorld\DollsWorld.Web\Views\Home\onlinePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15eb34e3afad440796b97c68aba76d84157f8fa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_onlinePayment), @"mvc.1.0.view", @"/Views/Home/onlinePayment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15eb34e3afad440796b97c68aba76d84157f8fa2", @"/Views/Home/onlinePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_onlinePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\DollsWorld\DollsWorld.Web\Views\Home\onlinePayment.cshtml"
  
    ViewData["Title"] = "نتیجه پرداخت";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">دنیای عروسک ها</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">نتیجه پرداخت</li>
    </ul>
</nav>

<div class=""container"">
");
#nullable restore
#line 16 "E:\DollsWorld\DollsWorld.Web\Views\Home\onlinePayment.cshtml"
     if (ViewBag.IsSuccess == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <h2>پرداخت با موفقیت انجام شد</h2>\r\n            <p> کد پیگیری : ");
#nullable restore
#line 20 "E:\DollsWorld\DollsWorld.Web\Views\Home\onlinePayment.cshtml"
                       Write(ViewBag.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 22 "E:\DollsWorld\DollsWorld.Web\Views\Home\onlinePayment.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <h2>پرداخت با شکست مواجه شد</h2>\r\n           \r\n        </div>\r\n");
#nullable restore
#line 29 "E:\DollsWorld\DollsWorld.Web\Views\Home\onlinePayment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
