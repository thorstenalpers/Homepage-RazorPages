#pragma checksum "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c45b545673e6f583f31d3c0ea43853b40104c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Homepage.Web.Pages.Pages_Kenntnisse), @"mvc.1.0.razor-page", @"/Pages/Kenntnisse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Kenntnisse.cshtml", typeof(Homepage.Web.Pages.Pages_Kenntnisse), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c45b545673e6f583f31d3c0ea43853b40104c1a", @"/Pages/Kenntnisse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eebae0e7917f9437895b3a2616e50c0f566a788", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Kenntnisse : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
  
    ViewData["Title"] = "ThorstenAlpers.de - Kenntnisse";

#line default
#line hidden
            BeginContext(97, 23, true);
            WriteLiteral("<h2>Kenntnisse</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
   
    int i = 0;

#line default
#line hidden
#line 11 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
 foreach (var skill in @Model.Kenntnisse)
{
    i = i+1;


#line default
#line hidden
            BeginContext(206, 153, true);
            WriteLiteral("    <div class=\"progressbar-container pb-2\">\r\n        <div class=\"row w-100\">\r\n            <div class=\"col-11\">\r\n                <div class=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 359, "\"", 378, 2);
            WriteAttributeValue("", 364, "progressbar_", 364, 12, true);
#line 18 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
WriteAttributeValue("", 376, i, 376, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(379, 18, true);
            WriteLiteral(" data-percentage=\"");
            EndContext();
            BeginContext(398, 11, false);
#line 18 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
                                                                         Write(skill.Value);

#line default
#line hidden
            EndContext();
            BeginContext(409, 28, true);
            WriteLiteral("\">\r\n                    <h6>");
            EndContext();
            BeginContext(438, 10, false);
#line 19 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
                   Write(skill.Name);

#line default
#line hidden
            EndContext();
            BeginContext(448, 130, true);
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-1\">\r\n                <div class=\"progressbar-text\">");
            EndContext();
            BeginContext(579, 11, false);
#line 23 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
                                         Write(skill.Value);

#line default
#line hidden
            EndContext();
            BeginContext(590, 57, true);
            WriteLiteral("%</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\thor\source\repos\Homepage\src\Homepage.Web\Pages\Kenntnisse.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KenntnisseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KenntnisseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KenntnisseModel>)PageContext?.ViewData;
        public KenntnisseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591