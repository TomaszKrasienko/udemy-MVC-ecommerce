#pragma checksum "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9272737bc52b08fbda0e8517d5952e6b77815e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9272737bc52b08fbda0e8517d5952e6b77815e5", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c674f97b1c3b2a45b6fe325bc7eb90334be63b03", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
  
    ViewData["Title"] = "List of movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 10 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
     foreach (Movie itemMovie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <dic class=""col-md-4 col-xs-6 mb-3"">
            <div class=""card mb-3"" style=""max-width: 540px"">
                <div class=""row g-0"">
                    <dic class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <h5 class=""card-title"">
                                ");
#nullable restore
#line 18 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                           Write(itemMovie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <a class=""text-white float-right""><i class=""bi bi-pencil-square""></i></a>
                            </h5>
                        </div>
                    </dic>
                    <div class=""col-md-6"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 821, "\"", 846, 1);
#nullable restore
#line 24 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
WriteAttributeValue("", 827, itemMovie.ImageUrl, 827, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 860, "\"", 881, 1);
#nullable restore
#line 24 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
WriteAttributeValue("", 866, itemMovie.Name, 866, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                    </div>\n                    <div class=\"col-md-6\">\n                        <dic class=\"card-body\">\n                            <p class=\"card-text\">");
#nullable restore
#line 28 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                            Write(itemMovie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 29 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                                           Write(itemMovie.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 30 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                                             Write(itemMovie.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 31 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                                               Write(itemMovie.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 32 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                                             Write(itemMovie.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"card-text\">\n                                <b>Status</b>\n");
#nullable restore
#line 35 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                 if (DateTime.Now >= @itemMovie.StartDate && DateTime.Now <= @itemMovie.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge btn-success\">Avaiable</span>\n");
#nullable restore
#line 38 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                }
                                else if(DateTime.Now > @itemMovie.EndDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge btn-danger\">Expired</span>\n");
#nullable restore
#line 42 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge btn-primary\">Upcoming</span>\n");
#nullable restore
#line 46 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </p>
                        </dic>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer"">
                            <p class=""card-text"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9272737bc52b08fbda0e8517d5952e6b77815e59806", async() => {
                WriteLiteral("\n                                    <i class=\"bi bi-eye-fill\"></i> Details\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                                                                                      WriteLiteral(itemMovie.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                                <a class=\"btn btn-success text-white\"><i class=\"bi-cart-plus-fill\"></i>Add to cart (Price ");
#nullable restore
#line 56 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
                                                                                                                     Write(itemMovie.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\n                            </p>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </dic>\n");
#nullable restore
#line 63 "/Users/mac/Documents/PrivateGitRepos/Udemy_MVC_eCommerce/eTickets/eTickets/Views/Movies/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
