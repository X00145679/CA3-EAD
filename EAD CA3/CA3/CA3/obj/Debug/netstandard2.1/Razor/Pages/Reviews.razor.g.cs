#pragma checksum "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe00a1abd28d45ccd57b4a7413d9970cd785ecea"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reviews")]
    public partial class Reviews : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>SEARCH NEW YORK TIMES MOVIE REVIEWS</h1>\r\n");
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
                __builder2.AddMarkupContent(15, "\r\n    <br>\r\n    <br>\r\n    ");
                __builder2.OpenElement(16, "label");
                __builder2.AddMarkupContent(17, "\r\n        Critics Choice:\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(18);
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                                    searchForm.critic

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchForm.critic = __value, searchForm.critic))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => searchForm.critic));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    <br>\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(24, "<button type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n");
#nullable restore
#line 25 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
 if (reviews != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table table-dark");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Review Author</th>\r\n                <th>Title</th>\r\n                <th>Summary</th>\r\n                <th>Link</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(31, "tbody");
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 38 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
             foreach (var review in reviews.results)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 42 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.display_title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 43 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.byline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 44 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.headline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "   \r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 45 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                     review.summary_short

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "href", 
#nullable restore
#line 46 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
                              review.link.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, "link");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 51 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 54 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\stuff\projects\CA3-EAD\EAD CA3\CA3\CA3\Pages\Reviews.razor"
       
    private SearchForm searchForm = new SearchForm();
    Review reviews;
    private char critics;
    private string APIKEY = "JA5osVzynnO1QMnjyzcOBwGQJbQAhVpA";
    private async Task callApi()
    {
        try
        {
            if (searchForm.critic)
                critics = 'Y';
            else
                critics = 'N';
            var response = await Http.GetStringAsync("https://api.nytimes.com/svc/movies/v2/reviews/search.json?critics-pick="+critics+"&opening-date=1990-01-01&order=by-title&publication-date=1930-01-01%3B2020-01-01&query=" + searchForm.Name + "&api-key="+APIKEY);
            reviews = Newtonsoft.Json.JsonConvert.DeserializeObject<Review>(response);
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: "+e);
        }



    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
