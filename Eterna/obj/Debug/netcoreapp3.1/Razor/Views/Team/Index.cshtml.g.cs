#pragma checksum "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5681cbfd21ff6a63c876ca7700722073cd839c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Eterna.Views.Team.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
namespace Eterna.Views.Team
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
#line 2 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/_ViewImports.cshtml"
using Eterna.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5681cbfd21ff6a63c876ca7700722073cd839c59", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75cd9031fecbfe2feb42e2252775735b7c6ee8b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamVm>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


    <main id=""main"">

        <!-- ======= Breadcrumbs ======= -->
        <section id=""breadcrumbs"" class=""breadcrumbs"">
            <div class=""container"">

                <ol>
                    <li><a href=""index.html"">Home</a></li>
                    <li>Team</li>
                </ol>
                <h2>Team</h2>

            </div>
        </section><!-- End Breadcrumbs -->
        <!-- ======= Team Section ======= -->
        <section id=""team"" class=""team"">
            <div class=""container"">

                <div class=""row"">
");
#nullable restore
#line 24 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml"
                     foreach (var team in Model.Teams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\n                            <div class=\"member\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5681cbfd21ff6a63c876ca7700722073cd839c594255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 814, "~/assets/img/team/", 814, 18, true);
#nullable restore
#line 28 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml"
AddHtmlAttributeValue("", 832, team.Image, 832, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                <h4>");
#nullable restore
#line 29 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml"
                               Write(team.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <span>");
#nullable restore
#line 30 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml"
                                 Write(team.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                <p>\n                                    ");
#nullable restore
#line 32 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml"
                               Write(team.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </p>\n                                <div class=\"social\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1187, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1261, "\"", 1268, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1343, "\"", 1350, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1426, "\"", 1433, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 42 "/Users/seymur/Desktop/BackEnd/17.11.2022_Homework/Eterna/Views/Team/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n\n            </div>\n        </section><!-- End Team Section -->\n\n    </main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamVm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
