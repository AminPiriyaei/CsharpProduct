#pragma checksum "D:\Project_New_Product\Products.Web\Products.Web_App\Views\Productts\_SuccessEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdfd99bf56c6000c2ed9a8b6337751395b767a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productts__SuccessEmail), @"mvc.1.0.view", @"/Views/Productts/_SuccessEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Productts/_SuccessEmail.cshtml", typeof(AspNetCore.Views_Productts__SuccessEmail))]
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
#line 1 "D:\Project_New_Product\Products.Web\Products.Web_App\Views\_ViewImports.cshtml"
using Products.Web_App;

#line default
#line hidden
#line 2 "D:\Project_New_Product\Products.Web\Products.Web_App\Views\_ViewImports.cshtml"
using Products.Web_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdfd99bf56c6000c2ed9a8b6337751395b767a7e", @"/Views/Productts/_SuccessEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c8e04840b3c6b373424e5e6dbd43e9412c2a7c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Productts__SuccessEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Project_New_Product\Products.Web\Products.Web_App\Views\Productts\_SuccessEmail.cshtml"
 if (ViewBag.IsSuccess)
{

#line default
#line hidden
            BeginContext(30, 106, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <p>عملیات ارسال ایمیل با موفقیت انجام شد </p>\r\n    </div>\r\n");
            EndContext();
#line 7 "D:\Project_New_Product\Products.Web\Products.Web_App\Views\Productts\_SuccessEmail.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(148, 103, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <p>عملیات ارسال ایمیل با مشکل روبرو شد </p>\r\n    </div>\r\n");
            EndContext();
#line 13 "D:\Project_New_Product\Products.Web\Products.Web_App\Views\Productts\_SuccessEmail.cshtml"
}

#line default
#line hidden
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