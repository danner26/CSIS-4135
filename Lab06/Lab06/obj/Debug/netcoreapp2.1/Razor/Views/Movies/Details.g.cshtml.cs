#pragma checksum "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d67085fbc8e1369348d40bedb79b6b535677cc5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Details.cshtml", typeof(AspNetCore.Views_Movies_Details))]
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
#line 1 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\_ViewImports.cshtml"
using Lab06;

#line default
#line hidden
#line 2 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\_ViewImports.cshtml"
using Lab06.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d67085fbc8e1369348d40bedb79b6b535677cc5e", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26df96cb2e483c8630d3c2584ccb041689ed4e71", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab06.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(67, 113, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Movie</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(181, 41, false);
#line 14 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(222, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(266, 37, false);
#line 17 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(303, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(347, 47, false);
#line 20 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(394, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(438, 43, false);
#line 23 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(481, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(525, 41, false);
#line 26 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(566, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(610, 37, false);
#line 29 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(691, 41, false);
#line 32 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(732, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(776, 37, false);
#line 35 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(857, 42, false);
#line 38 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(943, 38, false);
#line 41 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(981, 89, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\n    <dl class=\"dl-horizontal\">\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1070, "\"", 1118, 1);
#line 46 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1076, Html.DisplayFor(model => model.PosterURL), 1076, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1119, 70, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n        </dd>\r\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1189, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fdfad430c314c0896c58cd1621cc48a", async() => {
                BeginContext(1235, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "X:\GitHub\CSIS4135\Lab06\Lab06\Views\Movies\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1243, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1250, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c3011df7e743849cf7286bac9289c7", async() => {
                BeginContext(1272, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1288, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab06.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
