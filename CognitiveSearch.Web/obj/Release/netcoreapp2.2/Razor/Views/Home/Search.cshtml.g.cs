#pragma checksum "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94751e2b05f9351254ace94e637f87022860571c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Search.cshtml", typeof(AspNetCore.Views_Home_Search))]
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
#line 1 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\_ViewImports.cshtml"
using CognitiveSearch.Web;

#line default
#line hidden
#line 2 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\_ViewImports.cshtml"
using CognitiveSearch.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94751e2b05f9351254ace94e637f87022860571c", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c88f331fca975061b5114e04af26a2c25892e03", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 108, true);
            WriteLiteral("<!-- Copyright (c) Microsoft Corporation. All rights reserved.\r\n     Licensed under the MIT License. -->\r\n\r\n");
            EndContext();
#line 4 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search Results";
    ViewData["Path"] = "Home / Search Results";

#line default
#line hidden
            BeginContext(207, 59, true);
            WriteLiteral("\r\n<!-- Pass controller data to view -->\r\n<script>\r\n    q = ");
            EndContext();
            BeginContext(267, 43, false);
#line 11 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Home\Search.cshtml"
   Write(Html.Raw(Json.Serialize(TempData["query"])));

#line default
#line hidden
            EndContext();
            BeginContext(310, 18, true);
            WriteLiteral(";\r\n    searchId = ");
            EndContext();
            BeginContext(329, 46, false);
#line 12 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Home\Search.cshtml"
          Write(Html.Raw(Json.Serialize(TempData["searchId"])));

#line default
#line hidden
            EndContext();
            BeginContext(375, 39, true);
            WriteLiteral(";\r\n    applicationInstrumentationKey = ");
            EndContext();
            BeginContext(415, 67, false);
#line 13 "D:\AIPlatform\end-to-end-solutions\kma\src\Web UI Template\CognitiveSearch.Web\Views\Home\Search.cshtml"
                               Write(Html.Raw(Json.Serialize(TempData["applicationInstrumentationKey"])));

#line default
#line hidden
            EndContext();
            BeginContext(482, 2508, true);
            WriteLiteral(@";
</script>

<!--Details Modal-->
<div class=""modal"" id=""details-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div id=""details-modal-body"" class=""modal-body"">
                <div class=""row"" style=""height: 100%;"">
                    <div class=""modal-control-group"">
                        <span id=""prev-control"" class=""modal-control""><span class=""ms-Icon ms-Icon--ChevronLeftMed""></span></span>
                        <span id=""next-control"" class=""modal-control""><span class=""ms-Icon ms-Icon--ChevronRightMed""></span></span>
                        <span id=""close-control"" class=""modal-control"" data-dismiss=""modal""><span class=""ms-Icon ms-Icon--Clear""></span></span>
                    </div>
                    <div id=""details-pivot"" class=""ms-Pivot col-md-8"">
                        <ul id=""details-pivot-links"" class=""ms-Pivot-links""></ul>
                        <div id=""de");
            WriteLiteral(@"tails-pivot-content"">
                        </div>
                    </div>
                    <div id=""tags-panel"" class=""col-md-4"">
                        <div id=""transcript-search-box"" class=""ms-SearchBox"">
                            <input class=""ms-SearchBox-field"" type=""text"" value="""" id=""transcript-search-input"" placeholder=""Search..."">
                            <label class=""ms-SearchBox-label"">
                                <span class=""ms-SearchBox-icon ms-Icon ms-Icon--Search""></span>
                            </label>
                            <div class=""ms-CommandButton ms-SearchBox-clear ms-CommandButton--noLabel"">
                                <button class=""ms-CommandButton-button"">
                                    <span class=""ms-CommandButton-icon""><span class=""ms-Icon ms-Icon--Clear""></span></span>
                                    <span class=""ms-CommandButton-label""></span>
                                </button>
                            </div>
");
            WriteLiteral(@"                        </div>
                        <div id=""details-viewer"" style=""display:none""></div>
                        <div id=""tag-viewer""></div>
                        <hr />
                        <div id=""reference-viewer""></div>
                    </div>
                    <input id=""result-id"" type=""hidden"" />
                </div>
            </div>
        </div>
    </div>
</div>

<!--Search, Filters, and Facets-->
");
            EndContext();
            BeginContext(4626, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5624, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.ApplicationInsights.AspNetCore.JavaScriptSnippet JavaScriptSnippet { get; private set; }
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
