#pragma checksum "D:\univer\Project\Expedition\Excursion\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c905309ff8d6f843c48fe9a5a67f7e045caf7919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
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
#line 1 "D:\univer\Project\Expedition\Excursion\Views\_ViewImports.cshtml"
using Excursion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\univer\Project\Expedition\Excursion\Views\_ViewImports.cshtml"
using Excursion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c905309ff8d6f843c48fe9a5a67f7e045caf7919", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c550beab476b575405722b0c3903c59b7091eea", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("map-s"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Map", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"wrap\">\r\n\r\n\r\n\r\n    <span id=\"contents\"></span>\r\n");
#nullable restore
#line 8 "D:\univer\Project\Expedition\Excursion\Views\Gallery\Index.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c905309ff8d6f843c48fe9a5a67f7e045caf79194284", async() => {
                WriteLiteral("<button id=\"btn-id-foot\">ДІЗНАТИСЬ БІЛЬШЕ</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\univer\Project\Expedition\Excursion\Views\Gallery\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""gallery-section"" id=""gallerys"">
        <div class=""container"">
            <div class=""row"">
                <div class=""section-title"">
                    <h1>Галерея</h1>
                </div>
            </div>
            <div class=""row"">
                <div class=""gallery-item "" onclick=""openModal();currentSlide(1)"">
                    <div class=""gallery-item-inner"">
                        <img src=""images/students_erasmus_1.jpg"" alt=""service"">
                        <div class=""overlay"">
                            <h4>Учасники програм</h4>
                        </div>
                    </div>
                </div>

                <div class=""gallery-item"">
                    <div class=""gallery-item-inner"" onclick=""openModal();currentSlide(3)"">
                        <img src=""images/erasmus_4.png"" alt=""service"">
                        <div class=""overlay"">
                            <h4>Зустріч з переможцями Erasmus+</h4>
                   ");
            WriteLiteral(@"     </div>
                    </div>
                </div>
                <div class=""gallery-item"">
                    <div class=""gallery-item-inner"" onclick=""openModal();currentSlide(4)"">
                        <img src=""images/erasmus_3.png"" alt=""service"">
                        <div class=""overlay"">
                            <h4>Зустріч з представниками Еразмус-офісу""</h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <div id=""myModal"" class=""modal"">
        <span class=""close cursor"" onclick=""closeModal()"">&times;</span>
        <div class=""modal-content"">

            <div class=""mySlides"">
                <div class=""numbertext"">1 / 4</div>
                <img src=""images/students_erasmus_1.jpg"" style=""width:100%"">
            </div>


            <div class=""mySlides"">
                <div class=""numbertext"">3 / 4</div>
                <img src=""images/erasmus_4.png"" style=""wi");
            WriteLiteral(@"dth:100%"">
            </div>

            <div class=""mySlides"">
                <div class=""numbertext"">4 / 4</div>
                <img src=""images/erasmus_3.png"" style=""width:100%"">
            </div>


            <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
            <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>

            <div class=""caption-container"">
                <p id=""caption""></p>
            </div>

            <div class=""allimg"">
                <div class=""column"">
                    <img class=""demo cursor"" src=""images/students_erasmus_1.jpg"" style=""width:100%"" onclick=""currentSlide(1)""
                         alt=""Учасники програм"">
                </div>

                <div class=""column"">
                    <img class=""demo cursor"" src=""images/erasmus_4.png"" style=""width:100%"" onclick=""currentSlide(3)""
                         alt=""Зустріч з переможцями Erasmus+"">
                </div>
                <div class=""column"">
           ");
            WriteLiteral(@"         <img class=""demo cursor"" src=""images/erasmus_3.png"" style=""width:100%"" onclick=""currentSlide(4)""
                         alt=""Зустріч з представниками Еразмус-офісу"">
                </div>
            </div>
        </div>
    </div>

</div>");
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
