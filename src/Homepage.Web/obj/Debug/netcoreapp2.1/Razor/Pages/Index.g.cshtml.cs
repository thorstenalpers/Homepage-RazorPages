#pragma checksum "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86c32ef06775650180fc99aeae20c1043d2b502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Homepage.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Homepage.Web.Pages.Pages_Index), null)]
namespace Homepage.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\_ViewImports.cshtml"
using Homepage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86c32ef06775650180fc99aeae20c1043d2b502", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eebae0e7917f9437895b3a2616e50c0f566a788", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "ThorstenAlpers.de - Über mich";

#line default
#line hidden
            BeginContext(91, 693, true);
            WriteLiteral(@"

<div class=""container text-center"" id=""particles-text"">
    <div class=""row"">
        <div class=""col"">
            <p class=""big-text"">Hi!</p>
        </div>
    </div>
    <div class=""row justify-content-md-center"">
        <div class=""col-md-auto"">
            <p class=""big-text"">Ich bin <span class=""text-dark font-weight-bold typed-text""></span></p>
        </div>
    </div>
</div>

<div id=""particles-js"" />

<div class=""wrapper"">
    <div class=""snow layer1 a""></div>
    <div class=""snow layer1""></div>
    <div class=""snow layer2 a""></div>
    <div class=""snow layer2""></div>
    <div class=""snow layer3 a""></div>
    <div class=""snow layer3""></div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
