#pragma checksum "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5760ccd7e3dc212e6d1f340b90191e51795a9667"
// <auto-generated/>
#pragma warning disable 1591
namespace PieShop.UI.Pages.EmployeeDetails
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-detail");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "page-title");
            __builder.AddContent(5, "Details for ");
            __builder.AddContent(6, 
#nullable restore
#line 3 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                        employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 3 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                            employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
#nullable restore
#line 5 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
      
        var leadingFormat = "00000";
        //var a = Employee.EmployeeId.ToString("00000");
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-12 row");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-2");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 13 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                        $"https://gillcleerenpluralsight.blob.core.windows.net/person/{employee.EmployeeId}.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-10 row");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-xs-12 col-sm-8");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group row");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddMarkupContent(31, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-8");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "class", "form-control-plaintext");
            __builder.AddContent(38, 
#nullable restore
#line 20 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                           employee.EmployeeId.ToString(leadingFormat)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group row");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-sm-8");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "label");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "readonly", true);
            __builder.AddAttribute(52, "class", "form-control-plaintext");
            __builder.AddContent(53, 
#nullable restore
#line 27 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group row");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-sm-8");
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "label");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "readonly", true);
            __builder.AddAttribute(67, "class", "form-control-plaintext");
            __builder.AddContent(68, 
#nullable restore
#line 34 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n                ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group row");
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.AddMarkupContent(75, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-sm-8");
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "label");
            __builder.AddAttribute(80, "type", "text");
            __builder.AddAttribute(81, "readonly", true);
            __builder.AddAttribute(82, "class", "form-control-plaintext");
            __builder.AddContent(83, 
#nullable restore
#line 41 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "form-group row");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.AddMarkupContent(90, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col-sm-8");
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "label");
            __builder.AddAttribute(95, "type", "text");
            __builder.AddAttribute(96, "readonly", true);
            __builder.AddAttribute(97, "class", "form-control-plaintext");
            __builder.AddContent(98, 
#nullable restore
#line 48 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n                ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-group row");
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.AddMarkupContent(105, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                    ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-sm-8");
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.OpenElement(109, "label");
            __builder.AddAttribute(110, "type", "text");
            __builder.AddAttribute(111, "readonly", true);
            __builder.AddAttribute(112, "class", "form-control-plaintext");
            __builder.AddContent(113, 
#nullable restore
#line 55 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n                ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "form-group row");
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.AddMarkupContent(120, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                    ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "col-sm-8");
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.OpenElement(124, "label");
            __builder.AddAttribute(125, "type", "text");
            __builder.AddAttribute(126, "readonly", true);
            __builder.AddAttribute(127, "class", "form-control-plaintext");
            __builder.AddContent(128, 
#nullable restore
#line 62 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n\r\n                ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "form-group row");
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.AddMarkupContent(135, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                    ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "col-sm-8");
            __builder.AddMarkupContent(138, "\r\n                        ");
            __builder.OpenElement(139, "label");
            __builder.AddAttribute(140, "type", "text");
            __builder.AddAttribute(141, "readonly", true);
            __builder.AddAttribute(142, "class", "form-control-plaintext");
            __builder.AddContent(143, 
#nullable restore
#line 69 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n\r\n                ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "form-group row");
            __builder.AddMarkupContent(149, "\r\n                    ");
            __builder.AddMarkupContent(150, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                    ");
            __builder.OpenElement(151, "div");
            __builder.AddAttribute(152, "class", "col-sm-8");
            __builder.AddMarkupContent(153, "\r\n                        ");
            __builder.OpenElement(154, "label");
            __builder.AddAttribute(155, "type", "text");
            __builder.AddAttribute(156, "readonly", true);
            __builder.AddAttribute(157, "class", "form-control-plaintext");
            __builder.AddContent(158, 
#nullable restore
#line 76 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n\r\n                ");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "form-group row");
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.AddMarkupContent(165, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                    ");
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "class", "col-sm-8");
            __builder.AddMarkupContent(168, "\r\n                        ");
            __builder.OpenElement(169, "label");
            __builder.AddAttribute(170, "type", "text");
            __builder.AddAttribute(171, "readonly", true);
            __builder.AddAttribute(172, "class", "form-control-plaintext");
            __builder.AddContent(173, 
#nullable restore
#line 83 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n\r\n                ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "form-group row");
            __builder.AddMarkupContent(179, "\r\n                    ");
            __builder.AddMarkupContent(180, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n                    ");
            __builder.OpenElement(181, "div");
            __builder.AddAttribute(182, "class", "col-sm-8");
            __builder.AddMarkupContent(183, "\r\n\r\n");
#nullable restore
#line 91 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                         if (employee.Smoker)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(184, "                            ");
            __builder.AddMarkupContent(185, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>\r\n");
#nullable restore
#line 94 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(186, "                            ");
            __builder.AddMarkupContent(187, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>\r\n");
#nullable restore
#line 98 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"

                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(188, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n\r\n                ");
            __builder.OpenElement(191, "div");
            __builder.AddAttribute(192, "class", "form-group row");
            __builder.AddMarkupContent(193, "\r\n                    ");
            __builder.AddMarkupContent(194, "<label class=\"col-sm-4 col-form-label\">Job category</label>\r\n                    ");
            __builder.OpenElement(195, "div");
            __builder.AddAttribute(196, "class", "col-sm-8");
            __builder.AddMarkupContent(197, "\r\n                        ");
            __builder.OpenElement(198, "label");
            __builder.AddAttribute(199, "type", "text");
            __builder.AddAttribute(200, "readonly", true);
            __builder.AddAttribute(201, "class", "form-control-plaintext");
            __builder.AddContent(202, 
#nullable restore
#line 106 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    JobCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n\r\n                ");
            __builder.OpenElement(206, "div");
            __builder.AddAttribute(207, "class", "form-group row");
            __builder.AddMarkupContent(208, "\r\n                    ");
            __builder.AddMarkupContent(209, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                    ");
            __builder.OpenElement(210, "div");
            __builder.AddAttribute(211, "class", "col-sm-8");
            __builder.AddMarkupContent(212, "\r\n                        ");
            __builder.OpenElement(213, "label");
            __builder.AddAttribute(214, "type", "text");
            __builder.AddAttribute(215, "readonly", true);
            __builder.AddAttribute(216, "class", "form-control-plaintext");
            __builder.AddContent(217, 
#nullable restore
#line 113 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n\r\n                ");
            __builder.OpenElement(221, "div");
            __builder.AddAttribute(222, "class", "form-group row");
            __builder.AddMarkupContent(223, "\r\n                    ");
            __builder.AddMarkupContent(224, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                    ");
            __builder.OpenElement(225, "div");
            __builder.AddAttribute(226, "class", "col-sm-8");
            __builder.AddMarkupContent(227, "\r\n                        ");
            __builder.OpenElement(228, "label");
            __builder.AddAttribute(229, "type", "text");
            __builder.AddAttribute(230, "readonly", true);
            __builder.AddAttribute(231, "class", "form-control-plaintext");
            __builder.AddContent(232, 
#nullable restore
#line 120 "D:\PieShopProjectEnterPrise\PieShop.UI\Pages\EmployeeDetails\EmployeeDetails.razor"
                                                                                    employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(233, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(238, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
