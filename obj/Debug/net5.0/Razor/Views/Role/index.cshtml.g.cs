#pragma checksum "D:\asp net core\auditSystem\Views\Role\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fc1653f200378825326c53ba14fbb839d1be3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_index), @"mvc.1.0.view", @"/Views/Role/index.cshtml")]
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
#line 1 "D:\asp net core\auditSystem\Views\_ViewImports.cshtml"
using auditSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp net core\auditSystem\Views\_ViewImports.cshtml"
using auditSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fc1653f200378825326c53ba14fbb839d1be3c", @"/Views/Role/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252105efb29bb4cae056fa7b4fb52d6bd2e673fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
  
    // ViewData["title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">");
#nullable restore
#line 12 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div><!-- /.col -->\r\n                <div class=\"col-sm-6\">\r\n                    <ol class=\"breadcrumb float-sm-right\">\r\n                        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 16 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
                                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->

    <!-- Main content -->
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card card-secondary card-outline"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Informaci??n B??sica</h3>
                        </div>
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-12 text-right mb-4"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fc1653f200378825326c53ba14fbb839d1be3c5704", async() => {
                WriteLiteral("<i\r\n                                            class=\"fa fa-plus-square\"></i> A??adir\r\n                                        nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>
                                            ");
#nullable restore
#line 45 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </th>

                                        <th>
                                            Acciones
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 54 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 59 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
                                           Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 66 "D:\asp net core\auditSystem\Views\Role\index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
