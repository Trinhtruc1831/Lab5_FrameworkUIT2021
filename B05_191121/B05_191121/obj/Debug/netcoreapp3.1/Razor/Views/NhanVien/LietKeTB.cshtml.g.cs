#pragma checksum "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a643f437b25c035c51155f163cc31272525b835c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_LietKeTB), @"mvc.1.0.view", @"/Views/NhanVien/LietKeTB.cshtml")]
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
#line 1 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\_ViewImports.cshtml"
using B05_191121;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\_ViewImports.cshtml"
using B05_191121.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a643f437b25c035c51155f163cc31272525b835c", @"/Views/NhanVien/LietKeTB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2867e5e5747ef8c8d179375b2544753cb83c8a8", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_LietKeTB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<B05_191121.Models.NVTBModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/NhanVien/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/NhanVien/View"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
  
    ViewData["Title"] = "Liệt thiết bị được sửa theo nhân viên";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""border-style: solid"">
    <p>Danh sách thiết bị của nhân viên được chọn sửa</p>
    <table border=""1"">
        <tr>
            <th>Mã thiết bị</th>
            <th>Mã căn hộ</th>
            <th>Lần Thứ</th>
            <th>Ngày bảo trì</th>
            <th>Chức năng</th>
        </tr>

");
#nullable restore
#line 16 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
               Write(item.GetType().GetProperty("MaThietBi").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
               Write(item.GetType().GetProperty("MaCanHo").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
               Write(item.GetType().GetProperty("LanThu").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
               Write(item.GetType().GetProperty("NgayBaoTri").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a643f437b25c035c51155f163cc31272525b835c6517", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\"  name=\"manv\"");
                BeginWriteAttribute("value", " value=", 1149, "", 1156, 0);
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
                                                            Write(item.GetType().GetProperty("MaNhanVien").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                        <input type=\"hidden\"  name=\"matb\"");
                BeginWriteAttribute("value", " value=", 1279, "", 1347, 1);
#nullable restore
#line 34 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 1286, item.GetType().GetProperty("MaThietBi").GetValue(item, null), 1286, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\"  name=\"mach\"");
                BeginWriteAttribute("value", " value=", 1407, "", 1473, 1);
#nullable restore
#line 35 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 1414, item.GetType().GetProperty("MaCanHo").GetValue(item, null), 1414, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\"  name=\"lt\"");
                BeginWriteAttribute("value", " value=", 1531, "", 1596, 1);
#nullable restore
#line 36 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 1538, item.GetType().GetProperty("LanThu").GetValue(item, null), 1538, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"submit\" value=\"Delete\" name=\"submit\" id=\"Liet ke\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a643f437b25c035c51155f163cc31272525b835c10177", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"manv\"");
                BeginWriteAttribute("value", " value=", 1841, "", 1910, 1);
#nullable restore
#line 40 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 1848, item.GetType().GetProperty("MaNhanVien").GetValue(item, null), 1848, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"matb\"");
                BeginWriteAttribute("value", " value=", 1969, "", 2037, 1);
#nullable restore
#line 41 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 1976, item.GetType().GetProperty("MaThietBi").GetValue(item, null), 1976, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"mach\"");
                BeginWriteAttribute("value", " value=", 2096, "", 2162, 1);
#nullable restore
#line 42 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 2103, item.GetType().GetProperty("MaCanHo").GetValue(item, null), 2103, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"lt\"");
                BeginWriteAttribute("value", " value=", 2219, "", 2284, 1);
#nullable restore
#line 43 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 2226, item.GetType().GetProperty("LanThu").GetValue(item, null), 2226, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"nbt\"");
                BeginWriteAttribute("value", " value=", 2342, "", 2411, 1);
#nullable restore
#line 44 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
WriteAttributeValue("", 2349, item.GetType().GetProperty("NgayBaoTri").GetValue(item, null), 2349, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"submit\" value=\"View\" name=\"submit\" id=\"Liet ke\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\19521\source\repos\B05_191121\B05_191121\Views\NhanVien\LietKeTB.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<B05_191121.Models.NVTBModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
