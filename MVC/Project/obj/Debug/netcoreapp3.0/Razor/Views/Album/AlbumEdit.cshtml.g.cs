#pragma checksum "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa985222a6efb98a77b31cc1fcf2faa654c5b9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_AlbumEdit), @"mvc.1.0.view", @"/Views/Album/AlbumEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa985222a6efb98a77b31cc1fcf2faa654c5b9a7", @"/Views/Album/AlbumEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4e172a66a2c409f13199468497d829b5703e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_AlbumEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChinookProject.Shared.Album>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
  
    ViewData["Title"] = "Edit Album";


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Album</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">        \r\n        <h4>Album Details</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 13 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n            <div class=\"form-group\">\r\n                <p>");
#nullable restore
#line 15 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
              Write(Html.LabelFor(model => model.AlbumID));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 15 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
                                                      Write(ViewBag.AlbumID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                ");
#nullable restore
#line 16 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
           Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 18 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
               Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            <div class=\"form-group\"> \r\n                ");
#nullable restore
#line 22 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
           Write(Html.LabelFor(model => model.ArtistID,htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">                \r\n                    ");
#nullable restore
#line 24 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
               Write(Html.DropDownListFor(model => model.ArtistID, new SelectList(ViewBag.artistList, "ArtistID","Name"), "-Select Artist", htmlAttributes: new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
               Write(Html.ValidationMessageFor(model => model.ArtistID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           
                </div>
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Update"" class=""btn btn-primary"" />
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 35 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 37 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumEdit.cshtml"
   Write(Html.ActionLink("Cancel", "AlbumView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChinookProject.Shared.Album> Html { get; private set; }
    }
}
#pragma warning restore 1591
