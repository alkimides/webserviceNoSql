#pragma checksum "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecd85800ff58b2a39162a8e6995f40fe1727eaf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication2.Pages.Pages_partidospoliticos), @"mvc.1.0.razor-page", @"/Pages/partidospoliticos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/partidospoliticos.cshtml", typeof(WebApplication2.Pages.Pages_partidospoliticos), null)]
namespace WebApplication2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd85800ff58b2a39162a8e6995f40fe1727eaf9", @"/Pages/partidospoliticos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4718e4ee95f72dfba8bdbf5667cb1798984a79e6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_partidospoliticos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
  
    ViewData["Title"] = "partidospoliticos";

#line default
#line hidden
            BeginContext(113, 65, true);
            WriteLiteral("\r\n<h2>partidospoliticos</h2>\r\n\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n    ");
            EndContext();
            BeginContext(178, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d34b1f7ed649b98977702ef7ce8923", async() => {
                BeginContext(184, 12, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(203, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(211, 4056, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8779063a8a4f35a9d829c25be10bfc", async() => {
                BeginContext(217, 681, true);
                WriteLiteral(@"

        <div class=""container"">
            <div class=""tab tab-1"">
            <!--tabla html para la web-->
            <table id=""tablaPartidos"" class=""table"" cellpadding=""0"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th style=""width:150px"">Nombre</th>
                        <th style=""width:150px"">Siglas</th>
                        <th style=""width:150px"">Descripcion</th>
                        <th style=""width:150px"">Posicion</th>
                        <th style=""width:150px"">Votantes</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 36 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                     foreach (var partidos in Model.partidospoliticos)
                    {

#line default
#line hidden
                BeginContext(993, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1056, 15, false);
#line 39 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                           Write(partidos.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(1071, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1111, 15, false);
#line 40 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                           Write(partidos.Siglas);

#line default
#line hidden
                EndContext();
                BeginContext(1126, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1166, 20, false);
#line 41 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                           Write(partidos.Descripcion);

#line default
#line hidden
                EndContext();
                BeginContext(1186, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1226, 17, false);
#line 42 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                           Write(partidos.Posicion);

#line default
#line hidden
                EndContext();
                BeginContext(1243, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1283, 17, false);
#line 43 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                           Write(partidos.Votantes);

#line default
#line hidden
                EndContext();
                BeginContext(1300, 138, true);
                WriteLiteral("</td>\r\n                            <td><input type=\"button\" value=\"Remove\" onclick=\"Remove(this)\" /></td>\r\n                        </tr>\r\n");
                EndContext();
#line 46 "E:\restdb\webserviceNoSql-master\WebApplication2\Pages\partidospoliticos.cshtml"
                    }

#line default
#line hidden
                BeginContext(1461, 675, true);
                WriteLiteral(@"                </tbody>
                <tfoor>
                    <tr>
                        <td><input type=""text"" id=""txtNombre"" /></td>
                        <td><input type=""text"" id=""txtSiglas"" /></td>
                        <td><input type=""text"" id=""txtDescripcion"" /></td>
                        <td><input type=""text"" id=""txtPosicion"" /></td>
                        <td><input type=""text"" id=""txtVotantes"" /></td>
                        <td><input type=""button"" id=""btnAdd"" value=""Add"" onclick=""crearPartido()"" /></td>
                    </tr>
                </tfoor>
            </table>
        </div>
        </div>

        <br />

");
                EndContext();
                DefineSection("Scripts", async() => {
                    BeginContext(2162, 2085, true);
                    WriteLiteral(@"
            <script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
            <script type=""text/javascript"" src=""https://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js""></script>
            <script type=""text/javascript"">
                //añadimos partido politico mediante POST
                function crearPartido() {

                    var data = JSON.stringify({
                        ""Nombre"": txtNombre.value,
                        ""Siglas"": txtSiglas.value,
                        ""Descripcion"": txtDescripcion.value,
                        ""Posicion"": txtPosicion.value,
                        ""Votantes"" : txtVotantes.value,
                    });

                    var api = new XMLHttpRequest();
                    api.withCredentials = false;

                    api.addEventListener(""readystatechange"", function () {

                        if (this.readyState == 4) {
                            console.log(");
                    WriteLiteral(@"this.responseText);
                        }

                    });

                    api.open(""POST"",""https://politics-a056.restdb.io/rest/partidospoliticos"");
                    api.setRequestHeader(""content-type"", ""application/json"");
                    api.setRequestHeader(""x-apikey"", ""5de58f974658275ac9dc21e9"");
                    api.setRequestHeader(""cache-control"", ""no-cache"");

                    api.send(data);



                }

                function borrarPartido(value) {
                    var data = null;

                    var api = new XMLHttpRequest();

                    api.withCredentials = false;

                    api.addEventListener(""readystatechange"", function () {

                        if (this.readyState == 4) {
                            console.log(this.responseText);
                            let datos = JSON.parse(this.responseText);
                        }


                    });
                }
                ");
                    WriteLiteral("\r\n            </script>\r\n            ");
                    EndContext();
                }
                );
                BeginContext(4250, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4267, 17, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Pages.partidospoliticosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication2.Pages.partidospoliticosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication2.Pages.partidospoliticosModel>)PageContext?.ViewData;
        public WebApplication2.Pages.partidospoliticosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
