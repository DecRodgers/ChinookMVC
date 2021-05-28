#pragma checksum "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829afa026ada18c130771193bb2b7b362af07444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_AlbumView), @"mvc.1.0.view", @"/Views/Album/AlbumView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829afa026ada18c130771193bb2b7b362af07444", @"/Views/Album/AlbumView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4e172a66a2c409f13199468497d829b5703e1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Album_AlbumView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ChinookMVC.Models.AlbumViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
  
    ViewData["Title"] = "Albums";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Album Management</h2>
<table class=""table table-responsive table-condensed table-bordered table-striped"">
  <thead class=""thead-inverse"">
    <tr>      
      <th>Album Title</th>      
      <th>Album Artist</th>
      <th></th>
      <th></th>
      <th><a class=""btn btn-primary"" href=""CreateAlbum"">Add Album</a></th> 
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 20 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
 foreach (var item in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>        \r\n        <td>");
#nullable restore
#line 23 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
       Write(item.viewAlbum.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>        \r\n        <td>");
#nullable restore
#line 24 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
       Write(item.viewArtist.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>        \r\n        <td>");
#nullable restore
#line 25 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
       Write(Html.ActionLink("Details", "AlbumDetail", new { id=item.viewAlbum.AlbumID }, new { @class = "btn btn-info"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
       Write(Html.ActionLink("Edit", "AlbumEdit", new { id=item.viewAlbum.AlbumID }, new { @class = "btn btn-success"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>          \r\n        <td><a href=\"#\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1197, "\"", 1245, 3);
            WriteAttributeValue("", 1207, "ConfirmDelete(", 1207, 14, true);
#nullable restore
#line 27 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
WriteAttributeValue("", 1221, item.viewAlbum.AlbumID, 1221, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1244, ")", 1244, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n      </tr>\r\n");
#nullable restore
#line 29 "D:\Dropbox\Education\University\Computing Science Year 3\FINISHED\B00371286 IS CourseworkTwo\CourseworkTwo\Project\Views\Album\AlbumView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </tbody>
</table>

    <div class=""modal fade"" id=""myModal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                  <h5 class=""modal-title"">Delete Album</h5>
                    <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>                    
                </div>
                <div class=""modal-body"">
                    <p>Are you sure you want to remove this Album?</p>
                </div>
                <div class=""modal-footer"">
                    <a href=""#"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</a>
                    <a href=""#"" class=""btn btn-danger"" onclick=""DeleteAlbum()"">Confirm</a>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("    <input type=\"hidden\" id=\"hiddenAlbumID\" />\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
        var ConfirmDelete = function (AlbumID) {
            $(""#hiddenAlbumID"").val(AlbumID);
            $(""#myModal"").modal('show');
        }
        var DeleteAlbum = function () {
            var albID = $(""#hiddenAlbumID"").val();
            $.ajax({
                type: ""POST"",
                url: ""/Album/DeleteSelectedAlbum"",
                data: { id: albID },
                success: function (result) {
                    $(""#myModal"").modal(""hide"");
                     window.location.reload();    //added this to refresh page after deleting album               
                }
            })
        }
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ChinookMVC.Models.AlbumViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591