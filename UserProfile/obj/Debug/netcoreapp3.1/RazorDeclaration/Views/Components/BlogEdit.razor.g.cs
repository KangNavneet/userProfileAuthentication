#pragma checksum "C:\Users\navne\OneDrive\Documents\GitHub\userProfileAuthentication\UserProfile\Views\Components\BlogEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fca6a57eec42255d37f042e7e74e1b46c0bb6f3e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UserProfile.Views.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\navne\OneDrive\Documents\GitHub\userProfileAuthentication\UserProfile\Views\Components\BlogEdit.razor"
using UserProfile.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\navne\OneDrive\Documents\GitHub\userProfileAuthentication\UserProfile\Views\Components\BlogEdit.razor"
using UserProfile.Views.Components;

#line default
#line hidden
#nullable disable
    public partial class BlogEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\navne\OneDrive\Documents\GitHub\userProfileAuthentication\UserProfile\Views\Components\BlogEdit.razor"
       

    private BlogModel _blog = new BlogModel();
    protected string url
    {
        get
        {
            return baseUrl;
        }
    }

    protected string buttonMode
    {
        get
        {
            if (_blog.Id < 1)
            {
                return "Create New Post";
            }
            else
            {
                return "Update Post";
            }


        }
    }

    [Parameter]
    public BlogModel blog
    {
        set
        {
            _blog = value;

        }

        get
        {
            return _blog;
        }


    }

    [Parameter]
    public string baseUrl { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
