#pragma checksum "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2161da7ce3c400cacf9430084b75991b779b235b"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\_Imports.razor"
using CA3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
using CA3;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Reviews : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>SEARCH MOVIE REVIEWS</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                  searchForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                                              callApi

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "name");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                                      searchForm.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchForm.Name = __value, searchForm.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => searchForm.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.AddMarkupContent(16, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n");
#nullable restore
#line 17 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
 if (reviews != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Review Author</th>\r\n                <th>Title</th>\r\n                <th>Summary</th>\r\n                <th>Link</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(23, "tbody");
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 30 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
             foreach (var review in reviews.results)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "            ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 34 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.display_title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 35 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.byline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 36 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.headline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "   \r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 37 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.summary_short

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 38 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.link.url

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 43 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 46 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
       
    private SearchForm searchForm = new SearchForm();
    Review reviews;
    private async Task callApi()
    {

        var response = await Http.GetStringAsync("https://api.nytimes.com/svc/movies/v2/reviews/search.json?critics-pick=Y&opening-date=1990-01-01&order=by-title&publication-date=1930-01-01%3B2020-01-01&query="+searchForm.Name+"&api-key=JA5osVzynnO1QMnjyzcOBwGQJbQAhVpA");
        reviews = Newtonsoft.Json.JsonConvert.DeserializeObject<Review>(response);


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
