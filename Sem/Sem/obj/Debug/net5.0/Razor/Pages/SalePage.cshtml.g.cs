#pragma checksum "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sem.Pages.Pages_SalePage), @"mvc.1.0.razor-page", @"/Pages/SalePage.cshtml")]
namespace Sem.Pages
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
#line 1 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\_ViewImports.cshtml"
using Sem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
using Sem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105aa5c485e08a86bcf431f3df1d7d986c9ce0fa", @"/Pages/SalePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f08ad16086f4a1cbc43a94eb182421b50a4f41", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_SalePage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partials/SaleAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AboutImmovable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-5 registerbtn font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Удалить"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Authorization", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Shared/_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
  
    ViewData["Title"] = "Продажа";

    if (HttpContext.Items["user"] is User)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-light text-left\">Мои недвижимости на продажу</h1>\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa7590", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n");
            WriteLiteral("        <div id=\"ImmovableForSale\">\r\n");
#nullable restore
#line 17 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
             foreach (var sale in Model.Sales)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row text-light mt-5\">\r\n                    <div class=\"col-lg-5\">\r\n                        <h2 class=\"font-weight-bold\">");
#nullable restore
#line 21 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                Write(sale.Immovable.TypeOfImmovable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa9551", async() => {
                WriteLiteral("\r\n                            <img class=\"img mt-3\"");
                BeginWriteAttribute("src", " src=\"", 731, "\"", 758, 1);
#nullable restore
#line 23 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
WriteAttributeValue("", 737, sale.Immovable.Photo, 737, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"photo\"/>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                        WriteLiteral(sale.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"mr-5 mt-5\">\r\n                        <h5 class=\"font-weight-bold mt-3\">Адрес: </h5>\r\n");
#nullable restore
#line 28 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                         if (sale.Immovable.Building != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                г. ");
#nullable restore
#line 31 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                              Write(sale.Immovable.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ул. ");
#nullable restore
#line 31 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                        Write(sale.Immovable.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                                д. ");
#nullable restore
#line 32 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                              Write(sale.Immovable.House);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 32 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                    Write(sale.Immovable.Building);

#line default
#line hidden
#nullable disable
            WriteLiteral(", кв. ");
#nullable restore
#line 32 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                                                  Write(sale.Immovable.Apartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 34 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                г. ");
#nullable restore
#line 38 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                              Write(sale.Immovable.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ул. ");
#nullable restore
#line 38 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                        Write(sale.Immovable.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                                д. ");
#nullable restore
#line 39 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                              Write(sale.Immovable.House);

#line default
#line hidden
#nullable disable
            WriteLiteral(", кв. ");
#nullable restore
#line 39 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                         Write(sale.Immovable.Apartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 41 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"font-weight-bold mt-3\">Количество комнат: </h5>");
#nullable restore
#line 42 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                                             Write(sale.Immovable.NumberOfRooms);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <h5 class=\"font-weight-bold mt-3\">Площадь: </h5>");
#nullable restore
#line 43 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                                   Write(sale.Immovable.RoomArea);

#line default
#line hidden
#nullable disable
            WriteLiteral(" м\r\n                        <sup>\r\n                            <small>2</small>\r\n                        </sup>\r\n                        <h3 class=\"font-weight-bold mt-3\">Цена: </h3>");
#nullable restore
#line 47 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                                Write(sale.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₽\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa17445", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa17732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                                             WriteLiteral(sale.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"ml-5 mt-5 text-right\">\r\n                        <h5 class=\"font-weight-bold mt-3\">Дата публикации: </h5>");
#nullable restore
#line 53 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
                                                                           Write(sale.PostingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <button type=\"button\" id=\"show-more-sale\" class=\"registerbtn font-weight-bold mt-3\">Показать больше</button>\r\n");
#nullable restore
#line 59 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container text-light text-center\">\r\n            <h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa22727", async() => {
                WriteLiteral("Авторизуйтесь");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(", чтобы выставить недвижимость на продажу</h1>\r\n        </div>\r\n");
#nullable restore
#line 65 "C:\Users\artem\Desktop\Repositories\khamzin_11009\2021\FALL\INF\sem\Sem\Sem\Pages\SalePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "105aa5c485e08a86bcf431f3df1d7d986c9ce0fa24354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</partial>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sem.Pages.SalePage> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sem.Pages.SalePage> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sem.Pages.SalePage>)PageContext?.ViewData;
        public Sem.Pages.SalePage Model => ViewData.Model;
    }
}
#pragma warning restore 1591
