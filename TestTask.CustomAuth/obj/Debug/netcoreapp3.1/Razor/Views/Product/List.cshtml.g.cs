#pragma checksum "C:\Users\i-dim\source\repos\TestTask.CustomAuth\TestTask.CustomAuth\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d9a7be9a2789815262820dff49f5f923b52ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\i-dim\source\repos\TestTask.CustomAuth\TestTask.CustomAuth\Views\_ViewImports.cshtml"
using TestTask.CustomAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\i-dim\source\repos\TestTask.CustomAuth\TestTask.CustomAuth\Views\_ViewImports.cshtml"
using TestTask.CustomAuth.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d9a7be9a2789815262820dff49f5f923b52ef7", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f5d90350060427aa66e01781714dddf43515d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\i-dim\source\repos\TestTask.CustomAuth\TestTask.CustomAuth\Views\Product\List.cshtml"
 foreach (var p in Model.Products)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\i-dim\source\repos\TestTask.CustomAuth\TestTask.CustomAuth\Views\Product\List.cshtml"
Write(Html.Partial("ProductSummary", p));

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\i-dim\source\repos\TestTask.CustomAuth\TestTask.CustomAuth\Views\Product\List.cshtml"
                                      
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591