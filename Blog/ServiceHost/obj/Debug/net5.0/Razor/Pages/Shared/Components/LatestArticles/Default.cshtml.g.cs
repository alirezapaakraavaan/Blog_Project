#pragma checksum "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb1d4b65f7424f760901c3db7af71f0e61ac5cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.LatestArticles.Pages_Shared_Components_LatestArticles_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/LatestArticles/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.LatestArticles
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
#line 1 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb1d4b65f7424f760901c3db7af71f0e61ac5cb", @"/Pages/Shared/Components/LatestArticles/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_LatestArticles_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_BlogQuery.Contracts.Article.ArticleQueryModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""page-title"" class=""page-title-parallax page-title-center text-dark""
         style=""background-image: url(~/Theme/assets/images/parallax/page-title-parallax.jpg);"">
    <div class=""container"">
        <div class=""page-title col-md-8"">
            <h1>وبلاگ علیرضا پاکروان</h1>
            <h5>به وبلاگ علیرضا پاکروان خوش آمدید</h5>
        </div>
    </div>
</section>
<section class=""content"">
    <div class=""container"">
        <div class=""row"">
            <!-- Blog post-->
            <div class=""post-content post-modern col-md-9"">
                <!-- Blog image post-->
");
#nullable restore
#line 18 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                 foreach (var article in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"post-item\">\r\n                        <div class=\"post-image\">\r\n                            <a href=\"#\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fb1d4b65f7424f760901c3db7af71f0e61ac5cb4258", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
AddHtmlAttributeValue("", 920, article.PictureAlt, 920, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
AddHtmlAttributeValue("", 948, article.Title, 948, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 969, "~/Theme/assets/images/blog/", 969, 27, true);
#nullable restore
#line 23 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
AddHtmlAttributeValue("", 996, article.Picture, 996, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""post-content-details"">
                            <div class=""post-title"">
                                <h3>
                                    <a href=""#"">");
#nullable restore
#line 29 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                           Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h3>\r\n                            </div>\r\n                            <div class=\"post-description\">\r\n                                <p>");
#nullable restore
#line 33 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                              Write(article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <div class=""post-read-more"">
                                    <a class=""read-more"" href=""blog-post.html"">
                                        read more
                                        <i class=""fa fa-long-arrow-right""></i>
                                    </a>
                                </div>
                            </div>
                        </div>

                        <div class=""post-meta"">
                            <div class=""post-date"">
                                <span class=""post-comments-number"">");
#nullable restore
#line 45 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                                                              Write(article.PublishDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>

                            <div class=""post-comments"">
                                <a href=""#"">
                                    <i class=""fa fa-comments-o""></i>
                                    <span class=""post-comments-number"">324</span>
                                </a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 56 "D:\PROGRAMING\C#\Core\Blog\Code\Blog\ServiceHost\Pages\Shared\Components\LatestArticles\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- pagination nav -->
                <div class=""text-center"">
                    <div class=""pagination-wrap"">
                        <ul class=""pagination"">
                            <li>
                                <a aria-label=""Previous"" href=""#"">
                                    <span aria-hidden=""true""><i class=""fa fa-angle-left""></i></span>

                                </a>
                            </li>
                            <li>
                                <a href=""#"">1</a>
                            </li>
                            <li>
                                <a href=""#"">2</a>
                            </li>
                            <li>
                                <a href=""#"">3</a>
                            </li>
                            <li>
                                <a href=""#"">4</a>
                            </li>
                            <li>
                                <a href=""#"">5");
            WriteLiteral(@"</a>
                            </li>
                            <li>
                                <a aria-label=""Next"" href=""#"">
                                    <span aria-hidden=""true""><i class=""fa fa-angle-right""></i></span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- END: Blog post-->
            <!-- Sidebar-->
            <div class=""sidebar sidebar-modern col-md-3"">
                <!--widget newsletter-->
                <div class=""widget clearfix widget-newsletter"">
                    <script type=""text/javascript"">
                        jQuery(""#widget-subscribe-form-sidebar"").validate({
                            submitHandler: function (form) {
                                jQuery(form).ajaxSubmit({
                                    dataType: 'json',
                                    success: function (text) {
     ");
            WriteLiteral(@"                                   if (text.response == 'success') {
                                            $.notify({
                                                message: ""You have successfully subscribed to our mailing list.""
                                            }, {
                                                type: 'success'
                                            });
                                            $(form)[0].reset();

                                        } else {
                                            $.notify({
                                                message: text.message
                                            }, {
                                                type: 'warning'
                                            });
                                        }
                                    }
                                });
                            }
                        });

                    </script>
");
            WriteLiteral(@"                </div>
                <!--end: widget newsletter-->
                <!--widget tags -->
                <div class=""widget clearfix widget-tags"">
                    <h4 class=""widget-title"">Tags</h4>
                    <div class=""tags"">
                        <a href=""#"">Design</a>
                        <a href=""#"">Portfolio</a>
                        <a href=""#"">Digital</a>
                        <a href=""#"">Branding</a>
                        <a href=""#"">HTML</a>
                        <a href=""#"">Clean</a>
                        <a href=""#"">Peace</a>
                        <a href=""#"">Love</a>
                        <a href=""#"">CSS3</a>
                        <a href=""#"">jQuery</a>
                    </div>
                </div>
                <!--end: widget tags -->
                <!--widget blog articles-->
                <div class=""widget clearfix widget-blog-articles"">
                    <h4 class=""widget-title"">From our Blog</h4>
           ");
            WriteLiteral(@"         <ul class=""list-posts list-medium"">
                        <li>
                            <a href=""#"">Printing and typesetting</a>
                            <small>Jun 18 2015</small>
                        </li>
                        <li>
                            <a href=""#"">Lorem Ipsum has been the industry's</a><small>Jun 18 2015</small>
                        </li>
                        <li>
                            <a href=""#"">Ipsum and typesetting</a><small>Jun 18 2015</small>
                        </li>
                        <li>
                            <a href=""#"">Specimen book</a><small>Jun 18 2015</small>
                        </li>

                    </ul>
                </div>
                <!--end: widget blog articles-->
                <!--widget contact us-->
                <div class=""widget clearfix widget-contact-us"" style=""background-image: url('~/Theme/assets/images/world-map.png'); background-position: 50% 55px; background-repe");
            WriteLiteral(@"at: no-repeat"">
                    <h4 class=""widget-title"">Contact us</h4>
                    <ul class=""list-large list-icons"">
                        <li>
                            <i class=""fa fa-map-marker""></i>
                            <strong>Address:</strong> 795 Folsom Ave, Suite 600
                            <br>San Francisco, CA 94107
                        </li>
                        <li><i class=""fa fa-phone""></i><strong>Phone:</strong> (123) 456-7890 </li>
                        <li>
                            <i class=""fa fa-envelope""></i><strong>Email:</strong> <a href=""mailto:first.last@example.com"">first.last@example.com</a>
                        </li>
                        <li>
                            <i class=""fa fa-clock-o""></i>Monday - Friday: <strong>08:00 - 22:00</strong>
                            <br>Saturday, Sunday: <strong>Closed</strong>
                        </li>
                    </ul>
                </div>
                <!--end");
            WriteLiteral(": widget contact us-->\r\n            </div>\r\n            <!-- END: Sidebar-->\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_BlogQuery.Contracts.Article.ArticleQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
