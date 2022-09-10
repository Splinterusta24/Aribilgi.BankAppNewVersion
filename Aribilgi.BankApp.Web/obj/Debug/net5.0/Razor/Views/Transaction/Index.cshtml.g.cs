#pragma checksum "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0f5701ca701b83291525d3e66d73558e4cbd58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
using Aribilgi.BankApp.Web.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
using Aribilgi.BankApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0f5701ca701b83291525d3e66d73558e4cbd58", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4cd493a1a54d900a9d1a7736f54cacf6d1554b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TransactionDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">


        <table class=""table table-hover table-bordered"">

            <thead>
                <tr>
                    <th>Gönderen Hesap</th>
                    <th>Alan Hesap</th>
                    <th>İşlem Tutarı</th>
                    <th>İşlem Statüsü</th>
                    <th>İşlem Tarihi</th>
                    <th></th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 25 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                  
                    foreach (TransactionDTO item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                           Write(item.FromAccount.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                           Write(item.ToAccount.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                           Write(item.Statu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                           Write(item.TransactionTime.ToString("dd-MM-yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 35 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                                  
                                    if (item.Statu == TransactionStatu.Beklemede)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1352, "\"", 1483, 6);
            WriteAttributeValue("", 1359, "/Transaction/Reject?TransactionId=", 1359, 34, true);
#nullable restore
#line 38 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1393, item.Id, 1393, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1401, "&FromAccountId=", 1401, 15, true);
#nullable restore
#line 38 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1416, item.FromAccountId, 1416, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1435, "&Amount=", 1435, 8, true);
#nullable restore
#line 38 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1443, item.Amount.ToString().Replace(",","."), 1443, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Reddet</a>\r\n                                        <a class=\"btn-sm btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1566, "\"", 1695, 6);
            WriteAttributeValue("", 1573, "/Transaction/Confirm?TransactionId=", 1573, 35, true);
#nullable restore
#line 39 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1608, item.Id, 1608, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1616, "&ToAccountId=", 1616, 13, true);
#nullable restore
#line 39 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1629, item.ToAccount.Id, 1629, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1647, "&Amount=", 1647, 8, true);
#nullable restore
#line 39 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
WriteAttributeValue("", 1655, item.Amount.ToString().Replace(",","."), 1655, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Onayla</a>\r\n");
#nullable restore
#line 40 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                               \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\ARIBILGI\Desktop\Aribilgi.BankApp-master\Aribilgi.BankApp.Web\Views\Transaction\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TransactionDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
