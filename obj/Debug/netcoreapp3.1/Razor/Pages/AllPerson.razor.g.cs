#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705be22c737d27034b2ab7deb37e58f4b79dabcc"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment2_Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using DNP_Assignment2_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\_Imports.razor"
using DNP_Assignment2_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
using DNP_Assignment2_Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
using DNP_Assignment2_Client.Models.List;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
using DNP_Assignment2_Client.Models.Unit;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllPerson")]
    public partial class AllPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Person List</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "float: left");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<p style=\"float: left;position: relative;top: 8px\">\r\n            Key word:\r\n        </p>\r\n        ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "class", "form-control selectpicker");
            __builder.AddAttribute(10, "style", "float: left;position: relative;width:auto;height: 32px;top: 4px");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                                          ChangeKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                 searchKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchKeyWord = __value, searchKeyWord));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 17 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
             foreach (var keyWord in KeyWordList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, 
#nullable restore
#line 19 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         keyWord

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 20 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 23 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
     switch (searchKeyWord)
    {
        case "All":
            break;
        case "Id":

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "float: left");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(28, "\r\n                    :    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "number");
            __builder.AddAttribute(31, "min", "0");
            __builder.AddAttribute(32, "style", "width:150px");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                  searchInfo1

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 33 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            break;
        case "Name":

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "float: left");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(44, "\r\n                    First name:");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "style", "width:150px");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                              searchInfo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "style", "float: left");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(58, "\r\n                    Last name:");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "text");
            __builder.AddAttribute(61, "style", "width:150px");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                             searchInfo2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo2 = __value, searchInfo2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 45 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            break;
        case "Age":
        case "Height":
        case "Weight":

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "style", "float: left");
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(73, "\r\n                    From:");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "number");
            __builder.AddAttribute(76, "min", "0");
            __builder.AddAttribute(77, "style", "width:150px");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                  searchInfo1

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "style", "float: left");
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "p");
            __builder.AddAttribute(87, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(88, "\r\n                    to:");
            __builder.OpenElement(89, "input");
            __builder.AddAttribute(90, "type", "number");
            __builder.AddAttribute(91, "min", "0");
            __builder.AddAttribute(92, "style", "width:150px");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                searchInfo2

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo2 = __value, searchInfo2, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 59 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            break;
        case "Sex":

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "            ");
            __builder.OpenElement(99, "select");
            __builder.AddAttribute(100, "class", "form-control selectpicker");
            __builder.AddAttribute(101, "style", "float: left;position: relative;width:auto;height: 32px;top: 4px");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                                             SearchByKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                      searchInfo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenElement(106, "option");
            __builder.AddContent(107, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "option");
            __builder.AddContent(110, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "option");
            __builder.AddContent(113, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
#nullable restore
#line 66 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            break;
        case "Job":

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "            ");
            __builder.OpenElement(117, "select");
            __builder.AddAttribute(118, "class", "form-control selectpicker");
            __builder.AddAttribute(119, "style", "float: left;position: relative;width:auto;height: 32px;top: 4px");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                                             SearchByKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                      searchInfo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "option");
            __builder.AddContent(125, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 70 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                 foreach (string job in Adult.ValidJob)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                    ");
            __builder.OpenElement(128, "option");
            __builder.AddContent(129, 
#nullable restore
#line 72 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                             job

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n");
#nullable restore
#line 73 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 75 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            break;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
     if (searchKeyWord != "All" && searchKeyWord != "Sex" && searchKeyWord != "Job")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "        ");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "class", "btn-primary");
            __builder.AddAttribute(136, "style", "float: left;position: relative;width:auto;left: 10px;height: 32px;top: 4px;border-radius: 5px");
            __builder.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                                                                                                                                    SearchByKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(138, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n");
#nullable restore
#line 80 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(143, "\r\n    ");
            __builder.OpenElement(144, "p");
            __builder.AddAttribute(145, "style", "color: red");
            __builder.AddMarkupContent(146, "\r\n        ");
            __builder.AddContent(147, 
#nullable restore
#line 84 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
         error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(148, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
            __builder.OpenElement(151, "div");
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 88 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
     if (showList==null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "        ");
            __builder.AddMarkupContent(154, "<p>       \r\n            <em>Loading...</em>\r\n        </p>\r\n");
#nullable restore
#line 93 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
    }
    else if (showList.GetCount()==0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "        ");
            __builder.AddMarkupContent(156, "<p>       \r\n            <em>Can\'t find any person.</em>\r\n        </p>\r\n");
#nullable restore
#line 99 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
    }
    else 
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "        ");
            __builder.OpenElement(158, "table");
            __builder.AddAttribute(159, "class", "table");
            __builder.AddMarkupContent(160, "        \r\n            ");
            __builder.AddMarkupContent(161, @"<thead>
            <tr>
                <th>Id</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Age</th>
                <th>Height(m)</th>
                <th>Weight(kg)</th>
                <th>Sex</th>
                <th>Update</th>
                <th>Delete</th>
            </tr>
            </thead>        
            ");
            __builder.OpenElement(162, "tbody");
            __builder.AddMarkupContent(163, "\r\n");
#nullable restore
#line 117 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
             foreach (var person in showList.persons)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(164, "                ");
            __builder.OpenElement(165, "tr");
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.OpenElement(167, "td");
            __builder.AddContent(168, 
#nullable restore
#line 120 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                    ");
            __builder.OpenElement(170, "td");
            __builder.AddContent(171, 
#nullable restore
#line 121 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                    ");
            __builder.OpenElement(173, "td");
            __builder.AddContent(174, 
#nullable restore
#line 122 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                    ");
            __builder.OpenElement(176, "td");
            __builder.AddContent(177, 
#nullable restore
#line 123 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                    ");
            __builder.OpenElement(179, "td");
            __builder.AddContent(180, 
#nullable restore
#line 124 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                    ");
            __builder.OpenElement(182, "td");
            __builder.AddContent(183, 
#nullable restore
#line 125 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                    ");
            __builder.OpenElement(185, "td");
            __builder.AddContent(186, 
#nullable restore
#line 126 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                         person.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                    ");
            __builder.OpenElement(188, "td");
            __builder.AddMarkupContent(189, "\r\n                        ");
            __builder.OpenElement(190, "button");
            __builder.AddAttribute(191, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                            () => UpdatePerson(person)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(192, "\r\n                            <i class=\"oi oi-spreadsheet\" style=\"color: black\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                    ");
            __builder.OpenElement(195, "td");
            __builder.AddMarkupContent(196, "\r\n                        ");
            __builder.OpenElement(197, "button");
            __builder.AddAttribute(198, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
                                            () => RemovePerson(person)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(199, "\r\n                            <i class=\"oi oi-delete\" style=\"color: red\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
#nullable restore
#line 138 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(203, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n");
#nullable restore
#line 141 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2_Client\Pages\AllPerson.razor"
       
    private static readonly List<string> KeyWordList = new[]
    {
        "All","Id","Name","Age","Height","Weight","Sex","Job"
    }.ToList();
    private AdultList allAdult;
    private ChildList allChild;
    private PersonList showList;
    private string error;
    private string searchKeyWord;
    private string searchInfo1;
    private string searchInfo2;
    private string historyKeyWord;
    
    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            error = null;
            searchKeyWord = KeyWordList[0];
            historyKeyWord = searchKeyWord;
            showList = new PersonList();
            await InitShowList();
        }
        else
        {
            NavigationManager.NavigateTo("");
        }
    }

    private async Task InitShowList()
    {
        allAdult = await ModelManager.GetAllAdultAsync();
        allChild = await ModelManager.GetAllChildAsync();
        showList = new PersonList();
        foreach (var adult in allAdult.adults)
        {
            showList.AddPerson(adult);
        }
        foreach (var child in allChild.childs)
        {
            showList.AddPerson(child);
        }
    }

    private async Task ChangeKeyWord()
    {
        if (historyKeyWord!=searchKeyWord)
        {
            error = null;
            switch (searchKeyWord)
            {
                case "All":
                    break;
                case "Id":
                    searchInfo1 = "0";
                    searchInfo2 = null;
                    break;
                case "Name":
                    searchInfo1 = null;
                    searchInfo2 = null;
                    break;
                case "Age":
                    searchInfo1 = "0";
                    searchInfo2 = "125";
                    break;
                case "Height":
                    searchInfo1 = "1";
                    searchInfo2 = "250";
                    break;
                case "Weight":
                    searchInfo1 = "30";
                    searchInfo2 = "250";
                    break;
                case "Sex":
                    searchInfo1 = "All";
                    searchInfo2 = null;
                    break;
                case "Job":
                    searchInfo1 = "All";
                    searchInfo2 = null;
                    break;
            }
            await SearchByKeyWord();
        }
        historyKeyWord = searchKeyWord;
    }
    
    private async Task SearchByKeyWord()
    {
        error = null;
        await InitShowList();
        switch (searchKeyWord)
        {
            case "All":
                break;
            case "Id":
                if (!string.IsNullOrEmpty(searchInfo1))
                {
                    Person target = null;
                    try
                    {
                        target = showList.GetPersonById(int.Parse(searchInfo1));
                    }
                    catch (Exception e)
                    {
                        error = "Id is a number.";
                    }
                    showList = new PersonList();
                    showList.AddPerson(target);
                }
                break;
            case "Name":
                if (!string.IsNullOrEmpty(searchInfo1))
                {
                    showList = showList.GetPersonListByFirstName(searchInfo1);
                }
                if (!string.IsNullOrEmpty(searchInfo2))
                {
                    showList = showList.GetPersonListByLastName(searchInfo2);
                }
                break;
            case "Age":
                CheckSearchInfo(searchKeyWord,0,125);
                showList = showList.GetPersonListByAge(float.Parse(searchInfo1), float.Parse(searchInfo2));
                break;
            case "Height":
                CheckSearchInfo(searchKeyWord,1,250);
                showList = showList.GetPersonListByHeight(float.Parse(searchInfo1), float.Parse(searchInfo2));
                break;
            case "Weight":
                CheckSearchInfo(searchKeyWord,30,250);
                showList = showList.GetPersonListByWeight(float.Parse(searchInfo1), float.Parse(searchInfo2));
                break;
            case "Sex":
                if (searchInfo1!="All")
                {
                    showList = showList.GetPersonListBySex(searchInfo1);
                }
                break;
            case "Job":
                if (searchInfo1!="All")
                {
                    showList = new PersonList();
                    foreach (var adult in allAdult.GetAdultListByJob(searchInfo1).adults)
                    {
                        showList.AddPerson(adult);
                    }
                }
                break;
        }
    }

    private void CheckSearchInfo(string keyword,int min, int max)
    {
        try
        {
            if (string.IsNullOrEmpty(searchInfo1))
            {
                searchInfo1 = "" + min;
            }
            else if(float.Parse(searchInfo1)<min||float.Parse(searchInfo1)>max)
            {
                searchInfo1 = "" + min;
            }
            if (string.IsNullOrEmpty(searchInfo2))
            {
                searchInfo2 = "" + max;
            }
            else if(float.Parse(searchInfo2)<min||float.Parse(searchInfo2)>max)
            {
                searchInfo2 = "" + max;
            }
            else if (float.Parse(searchInfo2)<float.Parse(searchInfo1))
            {
                searchInfo2 = "" + float.Parse(searchInfo1);
            }
            
        }
        catch (Exception e)
        {
            error = keyword + " is a number.";
        }
    }

    private void UpdatePerson(Person targetPerson)
    {
        NavigationManager.NavigateTo("UpdatePerson");
        if (allAdult.GetAdultById(targetPerson.Id)!=null)
        {
            Pages.UpdatePerson.setInfo(allAdult.GetAdultById(targetPerson.Id));
        }
        else
        {
            Pages.UpdatePerson.setInfo(allChild.GetChildById(targetPerson.Id));
        }
        
    }

    private async Task RemovePerson(Person targetPerson)
    {
        await ModelManager.RemovePersonAsync(targetPerson);
        await InitShowList();
        await SearchByKeyWord();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591
