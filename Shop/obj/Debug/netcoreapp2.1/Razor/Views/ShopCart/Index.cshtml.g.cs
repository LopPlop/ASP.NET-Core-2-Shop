#pragma checksum "C:\Users\Bruh\source\repos\Shop\Shop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2de2df210035f5cde89bd46d9617659fdd12efeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShopCart/Index.cshtml", typeof(AspNetCore.Views_ShopCart_Index))]
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
#line 1 "C:\Users\Bruh\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Bruh\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de2df210035f5cde89bd46d9617659fdd12efeb", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f9a5568f5fb23693536e8341b43baa6f4162fb", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 25, true);
            WriteLiteral("<div class=\"container\">\r\n");
            EndContext();
#line 3 "C:\Users\Bruh\source\repos\Shop\Shop\Views\ShopCart\Index.cshtml"
     foreach(var el in Model._shopCart.listShopItems){

#line default
#line hidden
            BeginContext(107, 79, true);
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>????????????????????:</b> ");
            EndContext();
            BeginContext(187, 12, false);
#line 5 "C:\Users\Bruh\source\repos\Shop\Shop\Views\ShopCart\Index.cshtml"
                          Write(el._car.name);

#line default
#line hidden
            EndContext();
            BeginContext(199, 33, true);
            WriteLiteral("<br />\r\n            <b>????????:</b> ");
            EndContext();
            BeginContext(233, 27, false);
#line 6 "C:\Users\Bruh\source\repos\Shop\Shop\Views\ShopCart\Index.cshtml"
                    Write(el._car.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(260, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 8 "C:\Users\Bruh\source\repos\Shop\Shop\Views\ShopCart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(285, 89, true);
            WriteLiteral("    <hr />\r\n    <div class=\"btn btn-danger\" asp-controller=\"Order\">????????????????</div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
