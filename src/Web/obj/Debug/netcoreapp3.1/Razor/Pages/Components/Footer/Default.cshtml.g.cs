#pragma checksum "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c320b4f29c5eb17793e0649037333a9f6ede2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Web.Pages.Components.Footer.Pages_Components_Footer_Default), @"mvc.1.0.view", @"/Pages/Components/Footer/Default.cshtml")]
namespace Web.Pages.Components.Footer
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
#line 1 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c320b4f29c5eb17793e0649037333a9f6ede2c", @"/Pages/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa38aebda82e56481e5d8ce57c87ccbb709bbb6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewComponents.FooterViewComponent.FooterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
  
    void _renderText(string content)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
         Write(content);

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                             
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ================== Footer ================== -->
<footer class=""border-top footer text-muted"">
    <div class=""container-fluid bg-black white pt-5 pb-3 px-5"">
        <div class=""container"">
            <div class=""row section"">
                <div class=""col-12 col-lg-4 mb-3"">
                    <h4>Thông tin liên hệ</h4>
                    <hr class=""w-50 mb-3 ml-0 white"">
");
#nullable restore
#line 16 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                     if (Model.InfoShop?.Email !=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"middle-inline\">\n                            <i class=\"big-icon las la-envelope pr-1\"></i>\n                            <span id=\"email\"> ");
#nullable restore
#line 19 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                                _renderText(Model.InfoShop?.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </p>\n");
#nullable restore
#line 21 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                     if (Model.Phones?.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <p class=""middle-inline"">
                            <div class=""float-left pr-1"">
                                <i class=""big-icon las la-phone-volume pr-1""></i>
                            </div>
                            <div class=""float-right w-75"">
");
#nullable restore
#line 28 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                 foreach (var item in Model.Phones)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 30 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                  Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 31 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n                            <span class=\"float-clear\"></span>\n                            </p>\n");
#nullable restore
#line 35 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                     if (Model.Addresses?.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <p class=""middle-inline"">
                            <div class=""float-left pr-2"">
                                <i class=""big-icon las la-map-marked""></i>
                            </div>
                            <div class=""float-right w-75"">
");
#nullable restore
#line 42 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                 foreach (var item in Model.Addresses)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 44 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                  Write(item.AddressStore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 45 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n                            <span class=\"float-clear\"></span>\n                            </p>\n");
#nullable restore
#line 49 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"col-12 col-lg-4 mb-3\">\n                    <h4>Theo dõi chúng tôi</h4>\n                    <hr class=\"w-50 mb-3 ml-0 white\">\n");
#nullable restore
#line 54 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                     if (Model.Socials?.Count > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                             foreach (var item in Model.Socials)
                            {
                                string name = item.Name.ToLower();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"middle-inline\">\n                                <i");
            BeginWriteAttribute("class", " class=\"", 2752, "\"", 2786, 5);
            WriteAttributeValue("", 2760, "big-icon", 2760, 8, true);
            WriteAttributeValue(" ", 2768, "lab", 2769, 4, true);
            WriteAttributeValue(" ", 2772, "la-", 2773, 4, true);
#nullable restore
#line 60 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
WriteAttributeValue("", 2776, name, 2776, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2781, "pr-1", 2782, 5, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n                                <a id=\"fb\"");
            BeginWriteAttribute("href", " href=\"", 2835, "\"", 2852, 1);
#nullable restore
#line 61 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
WriteAttributeValue("", 2842, item.Link, 2842, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2853, "\"", 2871, 1);
#nullable restore
#line 61 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
WriteAttributeValue("", 2861, item.Name, 2861, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                                                           Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </p>\n");
#nullable restore
#line 63 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""col-12 col-lg-4"">
                    <h4>Google map</h4>
                    <hr class=""w-50 mb-3 ml-0 white"">
                    <iframe class=""border"" style=""height: 80%; width: auto;""
                        src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.5309563354476!2d106.66729411536586!3d10.770586092325527!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752edddb818ebf%3A0xfc8c05045f47a3d8!2zVHJ1bmcgVMOibSBUaMawxqFuZyBN4bqhaSBW4bqhbiBI4bqhbmg!5e0!3m2!1svi!2s!4v1610962388345!5m2!1svi!2s""
                        frameborder=""0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 3581, "\"", 3599, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"false\" tabindex=\"0\"></iframe>\n                </div>\n            </div>\n            <div class=\"row section align-items-center\">\n                <div class=\"col-12 col-lg-8 mb-3\">\n                    <h3 class=\"mb-3\">");
#nullable restore
#line 76 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                       
                            _renderText(Model.InfoShop?.Name);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p class=\"pr-5\">");
#nullable restore
#line 79 "/home/toan/Documents/Sources/watch-shop/src/Web/Pages/Components/Footer/Default.cshtml"
                                      
                            _renderText(Model.InfoShop?.SeoDescription);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""col-12 col-lg-4"">
                    <div class=""img"">
                        <img width=""200"" src=""./images/unnamed.png"">
                    </div>
                </div>
            </div>
            <p class=""text-center text-sub mb-0"">&copy;Copyright, by vtoan, 2021</p>
        </div>
    </div>
</footer>
<!-- ==================  End-Footer ================== -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewComponents.FooterViewComponent.FooterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
