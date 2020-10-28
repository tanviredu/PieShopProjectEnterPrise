#pragma checksum "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42057802c8079c35e00b047e2ee0969993308ec9"
// <auto-generated/>
#pragma warning disable 1591
namespace PieShop.UI.Pages.SurveyDetails
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using PieShop.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\PieShopProjectEnterPrise\PieShop.UI\_Imports.razor"
using PieShop.UI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/survey/{SurveyId}")]
    public partial class SurveyDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "entity-edit");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 4 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
     if (Survey == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 7 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <h1 class=\"page-title\">Survey Details</h1>\r\n            </div>\r\n        </div>\r\n        <br>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xs-12 col-sm-6");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<div class=\"card-header\">\r\n                        Question and Description\r\n                    </div>\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "class", "card-title");
            __builder.AddContent(22, 
#nullable restore
#line 23 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                                Survey.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "card-text");
            __builder.AddContent(26, 
#nullable restore
#line 24 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                              Survey.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-xs-12 col-sm-6");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.AddMarkupContent(37, "<div class=\"card-header\">\r\n                        Quick Stats\r\n                    </div>\r\n                    ");
            __builder.OpenElement(38, "ul");
            __builder.AddAttribute(39, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(40, "\r\n                        \r\n                        ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "list-group-item");
            __builder.AddContent(43, "Average Rating: ");
            __builder.AddContent(44, 
#nullable restore
#line 35 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                                                     AverageRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "list-group-item");
            __builder.AddContent(48, "Highest Rating: ");
            __builder.AddContent(49, 
#nullable restore
#line 36 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                                                     HighestRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "list-group-item");
            __builder.AddContent(53, "Lowest Rating: ");
            __builder.AddContent(54, 
#nullable restore
#line 37 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                                                    LowestRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "list-group-item");
            __builder.AddContent(58, "Number of Responses: ");
            __builder.AddContent(59, 
#nullable restore
#line 38 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                                                          Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-12");
            __builder.AddMarkupContent(70, "\r\n                <br>\r\n                ");
            __builder.AddMarkupContent(71, "<h3>Answers</h3>\r\n                ");
            __builder.OpenElement(72, "table");
            __builder.AddAttribute(73, "class", "table table-striped");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, "<thead>\r\n                        <tr>\r\n                            <th>Id</th>\r\n                            <th>Response</th>\r\n                            <th>Rating</th>\r\n                        </tr>\r\n                    </thead>\r\n                    ");
            __builder.OpenElement(76, "tbody");
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 56 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                         foreach (var answer in Survey.Answers)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                            ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 59 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                     answer.AnswerId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 60 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                     answer.Response

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.OpenElement(87, "td");
            __builder.AddContent(88, 
#nullable restore
#line 61 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                                     answer.Rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 63 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 68 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\SurveyDetails\SurveyDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
