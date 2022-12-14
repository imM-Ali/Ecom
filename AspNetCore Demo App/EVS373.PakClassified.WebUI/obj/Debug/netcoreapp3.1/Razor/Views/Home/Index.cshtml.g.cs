#pragma checksum "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fbf37512f9d15a75a9dff6b519dc4898c8fd481"
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
#line 1 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\_ViewImports.cshtml"
using EVS373.UsersMgt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\_ViewImports.cshtml"
using EVS373.PakClassified.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\_ViewImports.cshtml"
using EVS373.PakClassified.WebUI.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbf37512f9d15a75a9dff6b519dc4898c8fd481", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59d762d9455dbe727c1167fe9153586d28b1bac1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "nav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "advertizements", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Nav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_OthersLayout.cshtml";


    List<EVS373.PakClassified.Advertizement> latestAds = (List<EVS373.PakClassified.Advertizement>)ViewData["LatestApprovedAds"];
    List<EVS373.PakClassified.Advertizement> mylist = new List<EVS373.PakClassified.Advertizement>();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
  
    User currentUser = Context.Session.Get<User>(Constants.CURRENT_USER);
    string img = "0";
    if (currentUser.Image != null)
    {
        img = Convert.ToBase64String(currentUser.Image);
    }

    List<EVS373.PakClassified.AdvertizementCategory> cats = (List<EVS373.PakClassified.AdvertizementCategory>)ViewData["Categories"];
    List<EVS373.PakClassified.AdvertizementCategory> subcats = (List<EVS373.PakClassified.AdvertizementCategory>)ViewData["SubCategories"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .abc {
        background-image: url('/./img/back.jpg');
        background-repeat: no-repeat;
        background-position: center;
        position: relative;
    }

    .myimg {
        max-height: 300px;
    }

        .myimg img {
            object-fit: contain;
        }
</style>
<!-- Hero Section Begin -->
<section class=""hero-section"" style=""margin-bottom:50px"">
    <div class=""hero-items owl-carousel"">
        <div class=""single-hero-items set-bg"" data-setbg=""/./img/hero-5.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-5"">                        
                        <h1>PakClassifieds</h1>
                        <p style=""color:white"">
                           Everything you need.
                        </p>
                        <a href=""#"" class=""primary-btn"">Shop Now</a>
                    </div>
                </div>
                <div class=""off-card"">
                    ");
            WriteLiteral(@"<h2><span><i class=""fa fa-tags"" style=""font-size: xxx-large""></i></span></h2>
                </div>
            </div>
        </div>
        <div class=""single-hero-items set-bg"" data-setbg=""/./img/hero-6.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-5"">                        
                        <h1>PakClassifieds</h1>
                        <p>
                            Everything you need.
                        </p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbf37512f9d15a75a9dff6b519dc4898c8fd4818643", async() => {
                WriteLiteral("Shop Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""off-card"">
                    <h2><span><i class=""fa fa-tags"" style=""font-size: xxx-large""></i></span></h2>
                </div>
            </div>
        </div>
    </div>
</section>
");
#nullable restore
#line 77 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
   int count = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
 foreach (var item in cats)
{
    if (count % 2 == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section class=""man-banner spad"">
            <div class=""container-fluid"">
                <div class=""row d-flex align-items-center"">

                    <div class=""col-lg-8"">
                       
                                <div class=""product-slider owl-carousel"">
");
#nullable restore
#line 89 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                     foreach (var ad in latestAds)
                                    {
                                        if (ad.Category.Parent.Name == item.Name)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""product-item"">
                                                <div class=""pi-pic"">
                                                    <div class=""myimg"">
                                                        <img");
            BeginWriteAttribute("src", " src=\"", 3649, "\"", 3736, 2);
            WriteAttributeValue("", 3655, "data:image/jpg;base64,", 3655, 22, true);
#nullable restore
#line 96 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3677, Convert.ToBase64String(ad.Images.FirstOrDefault().Content), 3677, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3737, "\"", 3743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </div>                                                  
                                                   
                                                    <ul>                                                        
                                                        <li class=""quick-view"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbf37512f9d15a75a9dff6b519dc4898c8fd48112879", async() => {
                WriteLiteral("+ Quick View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                                                                                                         WriteLiteral(ad.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                                        
                                                    </ul>
                                                </div>
                                                <div class=""pi-text"">
                                                    <div class=""catagory-name"">");
#nullable restore
#line 105 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                                          Write(ad.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <a href=\"#\">\r\n                                                        <h5>");
#nullable restore
#line 107 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                       Write(ad.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                    </a>
                                                    <div class=""product-price"">                                                        
                                                        Rs.");
#nullable restore
#line 110 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                      Write(ad.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                      </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 114 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                           \r\n                        \r\n                    </div>\r\n                    <div class=\"col-lg-3  offset-lg-1\">\r\n");
            WriteLiteral("                        <div class=\"product-large abc\">\r\n                            <h2>");
#nullable restore
#line 125 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbf37512f9d15a75a9dff6b519dc4898c8fd48118101", async() => {
                WriteLiteral("Discover More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                                           WriteLiteral(item.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cname"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cname", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 132 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"women-banner spad\">\r\n            <div class=\"container-fluid\">\r\n                <div class=\"row d-flex align-items-center\">\r\n                    <div class=\"col-lg-3\">\r\n");
            WriteLiteral("                        <div class=\"product-large abc\">\r\n                            <h2>");
#nullable restore
#line 142 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fbf37512f9d15a75a9dff6b519dc4898c8fd48121552", async() => {
                WriteLiteral("Discover More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                                           WriteLiteral(item.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cname"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cname", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-8 offset-lg-1\">                        \r\n                        <div class=\"product-slider owl-carousel\">\r\n");
#nullable restore
#line 148 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                             foreach (var ad in latestAds)
                            {
                                if (ad.Category.Parent.Name == item.Name)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"product-item\">\r\n                                        <div class=\"pi-pic\">\r\n                                            <div class=\"myimg\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 7038, "\"", 7125, 2);
            WriteAttributeValue("", 7044, "data:image/jpg;base64,", 7044, 22, true);
#nullable restore
#line 155 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 7066, Convert.ToBase64String(ad.Images.FirstOrDefault().Content), 7066, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7126, "\"", 7132, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>                                            
                                            <ul>                                               
                                                <li class=""quick-view""><a class=""myquick"" data-index=""");
#nullable restore
#line 158 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                                                                 Write(ad.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"javascript:void(0)\" ");
            WriteLiteral(@">+ Quick View</a></li>
                                                 </ul>
                                        </div>
                                        <div class=""pi-text"">
                                            <div class=""catagory-name"">");
#nullable restore
#line 162 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                                                  Write(ad.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <a href=\"#\">\r\n                                                <h5>");
#nullable restore
#line 164 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                               Write(ad.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            </a>\r\n                                            <div class=\"product-price\">\r\n                                               Rs.");
#nullable restore
#line 167 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                             Write(ad.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                \r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 171 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 180 "C:\Users\Ali\Desktop\almost final\AspNetCore Demo App\EVS373.PakClassified.WebUI\Views\Home\Index.cshtml"

    }
    count++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
