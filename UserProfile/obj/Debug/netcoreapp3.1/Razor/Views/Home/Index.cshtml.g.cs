#pragma checksum "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55285863c3b6c815dfc927a5de4473e1818b3539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\_ViewImports.cshtml"
using UserProfile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\_ViewImports.cshtml"
using UserProfile.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Home\Index.cshtml"
using UserProfile.Views.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55285863c3b6c815dfc927a5de4473e1818b3539", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d558dc02eed058555517d224234c02a6be22865", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


    IList<BlogModel> blogs = new List<BlogModel>();
    UserDetails aa = new UserDetails
    {

        userName = "Pickachu",
        alias = "pickachuAlias",
        website = "pickachu.ca",
        socialUrl = "friends.com/pickachu",
        email = "pickachu@gmail.com",
        dob = DateTime.Parse("1989-3-12"),

    };

    blogs.Add(new BlogModel
    {
        Name = "Who",
        Author = new UserDetails { userName = "Pickachu", email = "pickachu@gmail.com" },
        Content = "Corona in Peel Region",
        Slug = "Covid"
    });
    blogs.Add(new BlogModel
    {
        Name = "Food",
        Author = new UserDetails { userName = "Tom", email = "tom@gmail.com" },
        Content = "New Outlet Starbuck Got Opened",
        Slug = "GDP"
    });

    blogs.Add(new BlogModel
    {
        Name = "Health",
        Author = new UserDetails { userName = "Jerry", email = "jerry@gmail.com" },
        Content = "Corona in Peel Region",
        Slug = "Covid"
    });


    blogs.Add(new BlogModel
    {
        Name = "WorldBank",
        Author = new UserDetails { userName = "Tweety", email = "tweety@gmail.com" },
        Content = "",
        Slug = "Covid"
    });






#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 65 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Home\Index.cshtml"
Write(await Html.RenderComponentAsync<BlogList>(RenderMode.ServerPrerendered, new BlogList { ModelList = blogs }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\navne\source\repos\UserProfileBlogs\UserProfile\Views\Home\Index.cshtml"
                                                                                                                  

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
