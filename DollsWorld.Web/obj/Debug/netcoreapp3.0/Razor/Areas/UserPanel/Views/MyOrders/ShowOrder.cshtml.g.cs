#pragma checksum "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f293e52769391d24675a69d29ea40a274a687c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_MyOrders_ShowOrder), @"mvc.1.0.view", @"/Areas/UserPanel/Views/MyOrders/ShowOrder.cshtml")]
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
#line 1 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
using DollsWorld.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f293e52769391d24675a69d29ea40a274a687c", @"/Areas/UserPanel/Views/MyOrders/ShowOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_MyOrders_ShowOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DollsWorld.DataLayer.Entities.Order.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/UserPanel/MyOrders/UseDiscount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
  
        ViewData["Title"] = "ShowOrder";
    int sumOrder = Model.OrderSum;
    string discountType = ViewBag.typeDiscount.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">دنیای عروسک ها</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> نمایش فاکتور </li>
        </ul>
    </nav>
</div>

<main>
    <div class=""container"">
        <div class=""user-account"">
            <div class=""row"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2f293e52769391d24675a69d29ea40a274a687c5093", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"col-md-9 col-sm-8 col-xs-12\">\r\n                    <section class=\"user-account-content\">\r\n                        <header><h1> فاکتور شما </h1></header>\r\n");
#nullable restore
#line 29 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                         if (ViewBag.finaly == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-success\">\r\n                                فاکتور با موفقیت پرداخت گردید\r\n                            </div>\r\n");
#nullable restore
#line 34 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>دوره</th>
                                    <th>تعداد</th>
                                    <th>قیمت</th>
                                    <th>جمع</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 45 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                             foreach (var item in Model.OrderDetails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1832, "\"", 1863, 2);
            WriteAttributeValue("", 1839, "/ShowCourse/", 1839, 12, true);
#nullable restore
#line 49 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 1851, item.Course, 1851, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 49 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                                                      Write(item.Course.CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 52 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                   Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 54 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                    Write((item.Count * item.Price).ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 59 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                           if (!Model.IsFinaly)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <tr>\r\n                                  <td colspan=\"3\" class=\"text-left\">کد تخفیف</td>\r\n                                  <td>\r\n                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f293e52769391d24675a69d29ea40a274a687c10508", async() => {
                WriteLiteral("\r\n                                          <input type=\"hidden\" name=\"orderid\"");
                BeginWriteAttribute("value", " value=\"", 2806, "\"", 2828, 1);
#nullable restore
#line 66 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 2814, Model.OrderId, 2814, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                          <input type=""text"" name=""code"" class=""form-control""/>
                                          <input type=""submit"" class=""btn btn-primary btn-block"" style=""margin-top: 5px"" value=""اعمال""/>
                                      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                       if (discountType != "")
                                      {
                                          switch (discountType)
                                          {
                                              case "Success":
                                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                  <div class=\"alert alert-success\">\r\n                                                      <p class=\"text-muted\">کد با موفقیت اعمال شد</p>\r\n                                                  </div>\r\n");
#nullable restore
#line 79 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                  break;
                                              }
                                              case "ExpierDate":
                                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                  <div class=\"alert alert-danger\">\r\n                                                      <p class=\"text-muted\">تاریخ کد به اتمام رسیده است</p>\r\n                                                  </div>\r\n");
#nullable restore
#line 86 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                  break;
                                              }
                                              case "NotFound":
                                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                  <div class=\"alert alert-warning\">\r\n                                                      <p class=\"text-muted\">کد معتبر نیست</p>\r\n                                                  </div>\r\n");
#nullable restore
#line 93 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                  break;
                                              }
                                              case "Finished":
                                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                  <div class=\"alert alert-danger\">\r\n                                                      <p class=\"text-muted\">کد به اتمام رسیده است</p>\r\n                                                  </div>\r\n");
#nullable restore
#line 100 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                  break;
                                              }
                                              case "UserUsed":
                                              {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                  <div class=""alert alert-info"">
                                                      <p class=""text-muted"">این کد قبلا توسط شما استفاده شده است</p>
                                                  </div>
");
#nullable restore
#line 107 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                                  break;
                                              }
                                          }
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  </td>\r\n                              </tr>\r\n");
#nullable restore
#line 113 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"3\" class=\"text-left\">جمع کل</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 117 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                               Write(sumOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 120 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                            if (!Model.IsFinaly)
                                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <tr>\r\n                                   <td colspan=\"2\" class=\"text-left\"></td>\r\n                                   <td colspan=\"2\">\r\n");
#nullable restore
#line 125 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                        if (_UserService.BalanceUserWallet(User.Identity.Name) >= sumOrder)
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <a class=\"btn btn-success btn-block\"");
            BeginWriteAttribute("href", " href=\"", 6629, "\"", 6682, 2);
            WriteAttributeValue("", 6636, "/UserPanel/MyOrders/FinalyOrder/", 6636, 32, true);
#nullable restore
#line 127 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 6668, Model.OrderId, 6668, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">تایید فاکتور</a>\r\n");
#nullable restore
#line 128 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                       }
                                       else
                                       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                           <a class=""btn btn-success btn-block"" disabled>تایید فاکتور</a>
                                           <div class=""alert alert-danger"">
                                               موجودی کیف پول شما کافی نمی باشد ، لطفا از طریق این
                                               <a href=""/UserPanel/Wallet"" class=""alert-link"">لینک</a>
                                               اقدام به شارژ حساب کنید
                                           </div>
");
#nullable restore
#line 137 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </td>\r\n                               </tr>\r\n");
#nullable restore
#line 141 "E:\DollsWorld\DollsWorld.Web\Areas\UserPanel\Views\MyOrders\ShowOrder.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DollsWorld.DataLayer.Entities.Order.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
