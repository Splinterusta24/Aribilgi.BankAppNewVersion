#pragma checksum "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dd7a167eb188570c49a5639c0d6ea234a3d55ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\_ViewImports.cshtml"
using Aribilgi.BankApp.Web.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd7a167eb188570c49a5639c0d6ea234a3d55ed", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4cd493a1a54d900a9d1a7736f54cacf6d1554b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/SendMoney"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Aribilgi.BankApp.Web.TagHelpers.GetBankAccountCount __Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6\">\n        <h3>Kullanıcı Bilgileri</h3>\n        <p>Kullanıcının Adı : ");
#nullable restore
#line 8 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Kullanıcının Soyadı : ");
#nullable restore
#line 9 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
                            Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Kullanıcının Hesap Sayısı :  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getAccountCount", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dd7a167eb188570c49a5639c0d6ea234a3d55ed5235", async() => {
                WriteLiteral(" ");
            }
            );
            __Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount = CreateTagHelper<global::Aribilgi.BankApp.Web.TagHelpers.GetBankAccountCount>();
            __tagHelperExecutionContext.Add(__Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount);
#nullable restore
#line 10 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
__Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount.ApplicationUserId = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("application-user-id", __Aribilgi_BankApp_Web_TagHelpers_GetBankAccountCount.ApplicationUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </p>\n\n    </div>\n\n    <div class=\"col-md-6\">\n        <h3>Yeni Hesap Ekle</h3>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dd7a167eb188570c49a5639c0d6ea234a3d55ed6796", async() => {
                WriteLiteral(@"

            <div class=""mb-3 form-group"">
                <label>Hesap Numarası</label>
                <input type=""number"" class=""form-control"" name=""AccountNumber"" />
            </div>

            <div class=""mb-3 form-group"">
                <label>Hesap Bakiyesi</label>
                <input type=""number"" class=""form-control"" name=""Balance"" />
            </div>

            <input name=""ApplicationUserId""");
                BeginWriteAttribute("value", " value=\"", 913, "\"", 930, 1);
#nullable restore
#line 28 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 921, Model.Id, 921, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"d-none\" />\n\n            <div class=\"mb-3 form-group\">\n                <button type=\"submit\" class=\"btn btn-success\">Hesap Oluştur</button>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""col-md-12"">

        <h3>Kullanıcının Hesapları</h3>
        <table class=""table table-hover table-bordered"">
            <thead>
                <tr>
                    <th>
                        Hesap No
                    </th>
                    <th>
                        Hesap Bakiyesi
                    </th>
                    <th>
                        Transfer Et
                    </th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 55 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
                  
                    foreach (Account item in Model.Accounts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 59 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
                           Write(item.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 60 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
                           Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td> \n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1920, "\"", 1954, 3);
            WriteAttributeValue("", 1930, "OpenModalPopup(", 1930, 15, true);
#nullable restore
#line 62 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 1945, item.Id, 1945, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1953, ")", 1953, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-success\">Transfer Et </a> \n                            <a");
            BeginWriteAttribute("href", " href=\"", 2031, "\"", 2072, 2);
            WriteAttributeValue("", 2038, "/Account/Detail?AccountId=", 2038, 26, true);
#nullable restore
#line 63 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 2064, item.Id, 2064, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-primary ml-1\">Hesap Detayı</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 66 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Account\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>
        </table>
    </div>
   
</div>


<div class=""modal fade"" id=""mdlTransferPopup"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Para Transfer Ekranı</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dd7a167eb188570c49a5639c0d6ea234a3d55ed12953", async() => {
                WriteLiteral(@"
             

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label>Aktarılacak Hesap No</label>
                        <input class=""form-control"" name=""toAccount"" />
                    </div>

                    <div class=""form-group"">
                        <label>Aktarılacak Tutar</label>
                        <input class=""form-control"" name=""amount"" />
                    </div>

                    <input id=""txtFromAccountId"" name=""fromAccount"" class=""d-none"" />


                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                    <button type=""submit"" class=""btn btn-primary"">Transfer Et</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591