#pragma checksum "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b6a227e35df69c2116bffd8bb018ccf7f509aaa"
// <auto-generated/>
#pragma warning disable 1591
namespace PieShop.UI.Pages.TaskList
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/tasks")]
    public partial class TaskList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "tasks");
            __builder.AddAttribute(2, "class", "widget");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, "Tasks");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "submit");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor"
                                             AddTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn btn-primary edit-btn float-right");
            __builder.AddContent(10, "Add Task");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-striped");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<thead>\r\n            <tr>\r\n                <th scope=\"col\">Title</th>\r\n                <th scope=\"col\">Description</th>\r\n                <th scope=\"col\">Status</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 14 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor"
             foreach (var task in Tasks)
            { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 17 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor"
                     task.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 18 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor"
                     task.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 19 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor"
                     task.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 22 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\TaskList\TaskList.razor"
            
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
