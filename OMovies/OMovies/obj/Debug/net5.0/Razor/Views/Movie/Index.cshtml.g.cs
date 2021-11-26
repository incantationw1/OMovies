#pragma checksum "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "516b28e75c8f5335d76730e1fc21241a7b4948b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\_ViewImports.cshtml"
using OMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\_ViewImports.cshtml"
using OMovies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516b28e75c8f5335d76730e1fc21241a7b4948b7", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b55fdc03c6f058bef10a97d02800a48c623daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OMovies.ViewModels.MoviesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/dist/css/jquery.dataTables.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/dist/js/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = Model.PageTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "516b28e75c8f5335d76730e1fc21241a7b4948b74499", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://use.fontawesome.com/releases/v5.15.4/css/all.css\" integrity=\"sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm\" crossorigin=\"anonymous\">\r\n");
            WriteLiteral(@"
<h1>Popular Movies</h1>

<table id=""movies"" class=""table table-hover"" data-order=""[]"">
    <thead>
        <tr>
            <th>Title</th>
            <th>Original Language</th>
            <th>Release Date</th>
            <th>Vote Average</th>
            <th>Vote Count</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
         foreach (var movie in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a href=\"javascript:void(0)\" class=\"movie\" data-id=\"");
#nullable restore
#line 25 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
                                                                   Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 25 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
                                                                              Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
               Write(movie.OriginalLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
               Write(movie.ReleaseDateString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
               Write(movie.VoteAverage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
               Write(movie.VoteCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div id=""movie-modal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
");
#nullable restore
#line 40 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
                 if (User.Identity != null && User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <button id=""add-favorite"" class=""btn d-none"">
                        <i class=""far fa-heart not-hearted""></i>
                    </button>
                    <button id=""remove-favorite"" class=""btn d-none"">
                        <i class=""fas fa-heart hearted""></i>
                    </button>
");
#nullable restore
#line 48 "C:\Users\Incantation\source\repos\OMoviesRepo\OMovies\OMovies\Views\Movie\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row justify-content-center"">
                    <img id=""movie-poster""");
            BeginWriteAttribute("src", " src=\"", 2169, "\"", 2175, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
                <br />
                <strong>Original Title: </strong><span id=""movie-original-title""></span>
                <br />
                <strong>Overview: </strong><span id=""movie-overview""></span>
                <br />
                <strong>Vote Average: </strong><span id=""movie-vote-average""></span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "516b28e75c8f5335d76730e1fc21241a7b4948b710793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        var movieId;

        $(function () {
            $('#movies').dataTable({});

            $("".movie"").click(function () {
                movieId = $(this).data(""id"");

                $.ajax({
                    url: `/Movies/GetMovie?id=${movieId}`,
                    type: ""GET"",
                    contentType: ""application/json""
                }).done(function (result) {
                    $(""#movie-modal"").find("".modal-title"").text(result[""title""]);
                    $(""#movie-poster"").attr(""src"", result[""poster_path""]);
                    $(""#movie-original-title"").text(result[""original_title""]);
                    $(""#movie-overview"").text(result[""overview""]);
                    $(""#movie-vote-average"").text(result[""vote_average""]);

                    if (result[""isFavorite""]) {
                        $(""#remove-favorite"").removeClass(""d-none"");
                        $(""#add-favorite"").addClass(""d-none"");
                    } else {
    ");
                WriteLiteral(@"                    $(""#add-favorite"").removeClass(""d-none"");
                        $(""#remove-favorite"").addClass(""d-none"");
                    }
                    $(""#movie-modal"").modal(""show"");
                }).fail(function () {
                    alert(""An unexpected error has occurred."");
                });
            });

            $(""#remove-favorite"").click(function () {
                $.ajax({
                    url: `/Movies/RemoveFavorite?id=${movieId}`,
                    type: ""POST"",
                    contentType: ""application/json""
                }).done(function () {
                    $(""#remove-favorite"").addClass(""d-none"");
                    $(""#add-favorite"").removeClass(""d-none"");
                }).fail(function () {
                    alert(""An unexpected error has occurred."");
                });
            });

            $(""#add-favorite"").click(function () {
                $.ajax({
                    url: `/Movies/AddFavorite?id=${");
                WriteLiteral(@"movieId}`,
                    type: ""POST"",
                    contentType: ""application/json""
                }).done(function () {
                    $(""#remove-favorite"").removeClass(""d-none"");
                    $(""#add-favorite"").addClass(""d-none"");
                }).fail(function () {
                    alert(""An unexpected error has occurred."");
                });
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OMovies.ViewModels.MoviesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
