#pragma checksum "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45db51ffec67fe95e20d34ff5c5933dcddb24700"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\_ViewImports.cshtml"
using Taste.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\_ViewImports.cshtml"
using Taste.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Taste.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45db51ffec67fe95e20d34ff5c5933dcddb24700", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622620b0c396d70bf10b423d9a3b706c343fc3e7", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fce9b92883193f8af4c6a690b260ded89965e5da", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Potvrda registracije";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-white\">");
#nullable restore
#line 7 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 8 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <br>
    <p class=""text-white"">
        Ova aplikacija trenutno nema pravog pošiljaoca e-pošte, pogledajte <a href=""https://aka.ms/aspaccountconf"">ovaj dokument</a> kako konfigurisati pravog pošiljaoca e-pošte.
        Obično bi se ovo poslalo e-poštom: <a id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 473, "\"", 507, 1);
#nullable restore
#line 14 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 480, Model.EmailConfirmationUrl, 480, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <br>Kliknite ovde da potvrdite svoj profil. </a>\n    </p>\n");
#nullable restore
#line 16 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-white\">\n\n            Proverite svoju e-poštu da biste potvrdili svoj nalog.\n</p>\n");
#nullable restore
#line 23 "C:\Users\Dell\Desktop\DIPLOMSKI\FoodOrderingServiceFinal\Taste\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
