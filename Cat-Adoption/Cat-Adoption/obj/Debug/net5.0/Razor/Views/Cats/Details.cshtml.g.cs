#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1123d402d037e0a36a4bca603c7231f815dad222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cats_Details), @"mvc.1.0.view", @"/Views/Cats/Details.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\_ViewImports.cshtml"
using Cat_Adoption;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\_ViewImports.cshtml"
using Cat_Adoption.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1123d402d037e0a36a4bca603c7231f815dad222", @"/Views/Cats/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f9d8f91849c1c051dee082d0ddb990b263ea21", @"/Views/_ViewImports.cshtml")]
    public class Views_Cats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
   var c = (CatModel)ViewData["Cat"];
    var o = (OwnerModel)ViewData["Owner"];
    var l = (LocationModel)ViewData["Location"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-6\">\r\n\r\n    <div id=\"card\" class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 318, "\"", 332, 1);
#nullable restore
#line 9 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
WriteAttributeValue("", 324, c.image, 324, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                              Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"font-weight-bold\">age:</h5>\r\n            <p class=\"card-text\"> ");
#nullable restore
#line 12 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                             Write(c.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h5 class=\"font-weight-bold\">description:</h5>\r\n            <p class=\"card-text align-content-center\">  ");
#nullable restore
#line 14 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                                                   Write(c.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h5 class=\"font-weight-bold\">gender:</h5>\r\n            <p class=\"card-text\">  ");
#nullable restore
#line 16 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                              Write(c.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h5 class=\"font-weight-bold\">vaccination:</h5>\r\n            <p class=\"card-text\">  ");
#nullable restore
#line 18 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                              Write(c.vaccination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h5 class=\"font-weight-bold\">Address:</h5>\r\n            <p class=\"card-text\">  ");
#nullable restore
#line 20 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                              Write(l.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-sm-6\">\r\n\r\n    <div id=\"card\" class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1189, "\"", 1203, 1);
#nullable restore
#line 30 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
WriteAttributeValue("", 1195, o.image, 1195, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n            <h5 class=\"card-title\">Owner: ");
#nullable restore
#line 31 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                                     Write(o.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"font-weight-bold\">Details:</h5>\r\n            <p class=\"card-text\"> phone: ");
#nullable restore
#line 33 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                                    Write(o.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text align-content-center\">  age: ");
#nullable restore
#line 34 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                                                        Write(o.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">  gender: ");
#nullable restore
#line 35 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                                      Write(o.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">  email: ");
#nullable restore
#line 36 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
                                     Write(o.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"d-grid gap-2\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1654, "\"", 1682, 2);
            WriteAttributeValue("", 1661, "/Adopter/Create/", 1661, 16, true);
#nullable restore
#line 42 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project03_CRUD_With_ASP.NET_MVC\Cat-Adoption\Cat-Adoption\Views\Cats\Details.cshtml"
WriteAttributeValue("", 1677, c.id, 1677, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-info\">Adopt Me</button></a>\r\n</div>\r\n\r\n\r\n\r\n");
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