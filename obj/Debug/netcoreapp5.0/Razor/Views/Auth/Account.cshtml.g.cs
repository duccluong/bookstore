#pragma checksum "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef55c32fb043d3d15d82d274e1c3347a6886864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Account), @"mvc.1.0.view", @"/Views/Auth/Account.cshtml")]
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
#line 1 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\_ViewImports.cshtml"
using book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\_ViewImports.cshtml"
using book.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef55c32fb043d3d15d82d274e1c3347a6886864", @"/Views/Auth/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dd35a86a2649ee4fe97baa6f28501d756792cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("grid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "accountsaveinfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml"
  
    ViewData["Title"] = "Mua hàng";
    List<CartItem> bookCart = Context.Session.Get<List<CartItem>>("cart");
    int countItem = 0;
    int sumPrice = 0;
    foreach (CartItem cartItem in bookCart)
    {
        countItem += cartItem.Count;
        sumPrice += cartItem.Count * cartItem.Book.BookMeta.Price;
    }
    User user = ViewBag.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef55c32fb043d3d15d82d274e1c3347a68868644885", async() => {
                WriteLiteral(@"
    <div id=""checkout_block_address"" class=""checkout_block"">
        <h1 class=""heading__buy"">Địa Chỉ Giao Hàng</h1>
        <div class=""checkout_block-content"">
            <div class=""checkout_block_address_block"">
                <input hidden name=""Id""");
                BeginWriteAttribute("value", " value=\"", 742, "\"", 758, 1);
#nullable restore
#line 20 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml"
WriteAttributeValue("", 750, user.Id, 750, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                <div class=\"input-group-horizontal-shippingaddress\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 859, "\"", 865, 0);
                EndWriteAttribute();
                WriteLiteral(">Họ và tên người nhận</label>\r\n                    <div class=\"input-group-texting\">\r\n                        <input name=\"Name\" required type=\"text\" class=\"input-item\" placeholder=\"Nhập thông tin\"");
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1081, 1);
#nullable restore
#line 24 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml"
WriteAttributeValue("", 1071, user.Name, 1071, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"input-group-horizontal-shippingaddress\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1233, "\"", 1239, 0);
                EndWriteAttribute();
                WriteLiteral(">Email</label>\r\n                    <div class=\"input-group-texting\">\r\n                        <input required name=\"Email\" type=\"email\" class=\"input-item\" placeholder=\"Nhập thông tin\"");
                BeginWriteAttribute("value", " value=\"", 1424, "\"", 1443, 1);
#nullable restore
#line 30 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml"
WriteAttributeValue("", 1432, user.Email, 1432, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"input-group-horizontal-shippingaddress\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1595, "\"", 1601, 0);
                EndWriteAttribute();
                WriteLiteral(">Số Điện Thoại</label>\r\n                    <div class=\"input-group-texting\">\r\n                        <input name=\"PhoneNumber\" required type=\"tel\" pattern=\"[0]{1}[0-9]{9}\" class=\"input-item\"\r\n                            placeholder=\"Format: 0123456789\"");
                BeginWriteAttribute("value", " value=\"", 1856, "\"", 1881, 1);
#nullable restore
#line 37 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml"
WriteAttributeValue("", 1864, user.PhoneNumber, 1864, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"input-group-horizontal-shippingaddress\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 2033, "\"", 2039, 0);
                EndWriteAttribute();
                WriteLiteral(">Địa chỉ nhận hàng</label>\r\n                    <div class=\"input-group-texting\">\r\n                        <input name=\"Address\" required type=\"text\" class=\"input-item\" placeholder=\"Nhập thông tin\"");
                BeginWriteAttribute("value", " value=\"", 2237, "\"", 2258, 1);
#nullable restore
#line 43 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Auth\Account.cshtml"
WriteAttributeValue("", 2245, user.Address, 2245, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <button class=\"btn-buy\"><span>\r\n                        LƯU THÔNG TIN\r\n                    </span></button>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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