#pragma checksum "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76687932edb6cde72f137cffe692e44ccd036d22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Reservation), @"mvc.1.0.view", @"/Views/Reservation/Reservation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/Reservation.cshtml", typeof(AspNetCore.Views_Reservation_Reservation))]
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
#line 1 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/_ViewImports.cshtml"
using SjediBa;

#line default
#line hidden
#line 2 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/_ViewImports.cshtml"
using SjediBa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76687932edb6cde72f137cffe692e44ccd036d22", @"/Views/Reservation/Reservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0df0b4e190489e8f40fcad2efbdd912db6fe1b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Reservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("booking"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
  
    ViewData["Title"] = "Događaji";

#line default
#line hidden
            BeginContext(44, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(51, 17, false);
#line 5 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 7 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
    
    List<EventModel> events = new List<EventModel>();
    

#line default
#line hidden
            BeginContext(147, 516, true);
            WriteLiteral(@"
<div class=""clearfix"">
    <div class=""form-group float-right"">
        <div>
            <i class=""fa fa-search position-absolute pt-2 pl-3""></i>
            <input type=""text"" class=""form-control pl-5"" id=""search"" placeholder=""Search"">
        </div>
    </div>
    <table class=""float-left w-100"">
        <tr>
            <th>ID</th>
            <th>Naziv</th>
            <th>Lokacija</th>
            <th>Datum</th>
            <th>Vrijeme</th>
            <th>Organizator</th>
        </tr>
");
            EndContext();
#line 28 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
         foreach (var e in events)
        {

#line default
#line hidden
            BeginContext(710, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(749, 14, false);
#line 31 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
               Write(e.EventModelId);

#line default
#line hidden
            EndContext();
            BeginContext(763, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(791, 6, false);
#line 32 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
               Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(797, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(825, 20, false);
#line 33 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
               Write(e.SpaceModel.Address);

#line default
#line hidden
            EndContext();
            BeginContext(845, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(873, 35, false);
#line 34 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
               Write(e.StartDate.ToString("dd. MM. yy."));

#line default
#line hidden
            EndContext();
            BeginContext(908, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(936, 31, false);
#line 35 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
               Write(e.StartDate.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(967, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(995, 17, false);
#line 36 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
               Write(e.SpaceModel.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 38 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
                       var json = Newtonsoft.Json.JsonConvert.SerializeObject(e); 

#line default
#line hidden
            BeginContext(1126, 113, true);
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#bookingPopup\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1239, "\"", 1271, 3);
            WriteAttributeValue("", 1249, "SetCurrentEvent(", 1249, 16, true);
#line 39 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
WriteAttributeValue("", 1265, json, 1265, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1270, ")", 1270, 1, true);
            EndWriteAttribute();
            BeginContext(1272, 111, true);
            WriteLiteral(">\r\n                        Rezerviši\r\n                    </button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 44 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
        }

#line default
#line hidden
            BeginContext(1394, 744, true);
            WriteLiteral(@"    </table>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""bookingPopup"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalLabel"">Rezerviši događaj</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""mb-3"">
                    <span class=""h3"" id=""eventName""></span><br>
                </div>
                ");
            EndContext();
            BeginContext(2138, 1624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76687932edb6cde72f137cffe692e44ccd036d2211623", async() => {
                BeginContext(2206, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 64 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
                     if(true)
                    {

#line default
#line hidden
                BeginContext(2262, 804, true);
                WriteLiteral(@"                        <div class=""form-group row"">
                            <label for=""name"" class=""col-form-label col-sm-2"">Ime i prezime:</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Ime i prezime"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""date"" class=""col-form-label col-sm-2"">Datum rodjenja:</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" name=""date"" id=""date"" placeholder=""Datum rodjenja"">
                            </div>
                        </div>
");
                EndContext();
#line 78 "/home/dzan/Desktop/MyStuff/Fakultet/OOAD/Grupa1-Sjedi.ba/Implementacija/SjediBa/SjediBa/Views/Reservation/Reservation.cshtml"
                    }

#line default
#line hidden
                BeginContext(3089, 249, true);
                WriteLiteral("                    <div class=\"form-group row\">\r\n                        <div class=\"col-sm-6\">\r\n                            <select class=\"form-control\" name=\"sector\" id=\"section\" onclick=\"SetSeats(); SetPrice()\">\r\n                                ");
                EndContext();
                BeginContext(3338, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76687932edb6cde72f137cffe692e44ccd036d2213737", async() => {
                    BeginContext(3355, 6, true);
                    WriteLiteral("Sektor");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3370, 234, true);
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"col-sm-6\">\r\n                            <select class=\"form-control\" name=\"seat\" id=\"seat\">\r\n                                ");
                EndContext();
                BeginContext(3604, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76687932edb6cde72f137cffe692e44ccd036d2215430", async() => {
                    BeginContext(3621, 8, true);
                    WriteLiteral("Sjedište");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3638, 117, true);
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3762, 382, true);
            WriteLiteral(@"
                <span id=""seatPrice""> </span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""$('#booking').submit()"">Rezerviši</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Odustani</button>
            </div>
        </div>
    </div>
</div>");
            EndContext();
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