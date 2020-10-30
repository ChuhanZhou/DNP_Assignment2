#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\Pages\UserInformation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1dc935b989d32467fe3f3655dee90fb45d2f193"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Assignment2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\_Imports.razor"
using Assignment2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\Pages\UserInformation.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\Pages\UserInformation.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\Pages\UserInformation.razor"
using global::Assignment2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserInformation")]
    public partial class UserInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "D:\学习资料\VIA\(DNP)\C#\DNP1\DNP_Assignment2\Pages\UserInformation.razor"
       
    private static string userName;
    private string error;
    private User newUser;
    private User oldUser;
    private string confirmPassword;
    private bool succeed;

    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            InitInfo();
        }
        else
        {
            NavigationManager.NavigateTo("");
        }
    }
    
    private void InitInfo()
    {
        newUser = new User
        {
            UserName = userName,
            Password = null
        };
        oldUser = new User
        {
            UserName = userName,
            Password = null
        };
        confirmPassword = null;
        succeed = false;
        error = null;
    }

    public static void SetInfo(string newUserName)
    {
        userName = newUserName;
    }

    private void ChangePassword()
    {
        if (!string.IsNullOrEmpty(newUser.Password))
        {
            if (newUser.Password==confirmPassword)
            {
                error = ModelManager.UpdatePassword(oldUser,newUser);
            }
            else
            {
                error = "Please write a correct confirm password.";
            }
        }
        else
        {
            error = "Please write a username and password.";
        }
        if (error==null)
        {
            succeed = true;
        }
    }

    private void Logout()
    {
        userName = null;
        MainLayout.Logout();
        NavigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591
