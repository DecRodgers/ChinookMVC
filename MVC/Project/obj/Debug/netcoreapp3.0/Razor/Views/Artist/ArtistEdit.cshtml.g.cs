#pragma checksum "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07fe3d74c4784b0356d226c8d6f9fbd9aeef48ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artist_ArtistEdit), @"mvc.1.0.view", @"/Views/Artist/ArtistEdit.cshtml")]
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
#line 1 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\_ViewImports.cshtml"
using ChinookMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\_ViewImports.cshtml"
using ChinookMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07fe3d74c4784b0356d226c8d6f9fbd9aeef48ee", @"/Views/Artist/ArtistEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4e172a66a2c409f13199468497d829b5703e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Artist_ArtistEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChinookProject.Shared.Artist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
  
    ViewData["Title"] = "Edit Artist";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Artist</h2>\r\n\r\n");
#nullable restore
#line 7 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">        \r\n        <hr />\r\n        ");
#nullable restore
#line 11 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
   Write(Html.HiddenFor(model => model.ArtistID));

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 14 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">                \r\n                ");
#nullable restore
#line 16 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 28 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Artist\ArtistEdit.cshtml"
Write(Html.ActionLink("Cancel", "ArtistView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChinookProject.Shared.Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
