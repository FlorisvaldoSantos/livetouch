#pragma checksum "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5c807057273fb930c5e846a1503ab5e57c3fa0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
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
#line 1 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 1 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5c807057273fb930c5e846a1503ab5e57c3fa0e", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(113, 280, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 col-md-offset-0 col-md-6 col-lg-offset-3"">
        <div class=""panel panel-default"">
            <div class=""align-middle text-center HeaderPanel"">
                Carros
            </div>
            <div class=""panel-body"">
");
            EndContext();
#line 15 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
            BeginContext(476, 24, false);
#line 17 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
#line 17 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
                                             ;

#line default
#line hidden
            BeginContext(503, 309, true);
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label for=""email"">Login</label>
                                <input type=""text"" class=""form-control"" id=""Username"" name=""Username""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 812, "\"", 835, 1);
#line 22 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
WriteAttributeValue("", 820, Model.Username, 820, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(836, 2330, true);
            WriteLiteral(@" aria-describedby=""loginHelp"" placeholder=""Digite o login"">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""form-group"">
                                <label for=""exampleInputPassword1"">Senha</label>
                                <input type=""password"" class=""form-control"" id=""Password"" name=""Password"" placeholder=""Digite a senha"">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group form-check"">
                                <label class=""form-check-label"" for=""MaterLogado"">Manter logado</label>
                                <input type=""checkbox"" class=""form-check-input"" id=""MaterLogado"" name=""MaterLogado"">
                            </div>");
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-6 text-right"">
                            <label class=""btn-link"">Esqueci a senha</label>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <button type=""submit"" class=""btn btn-block btn-primary"">Login</button>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-6 text-right"">
                                <label class=""btn-link"">Ainda não é cadastrado?</label>
                            </div>
                            <div class=""col-md-6 text-left"">
                                <label class=""btn-link"">Crie uma conta</label>
                            </div>    
                        </div>
                    </div>
                    <div clas");
            WriteLiteral(@"s=""row"">
                        <div class=""col-md-12"">
                            <div class=""text-center"">
                                <label class=""btn-link"">Ajuda </label>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 67 "C:\Users\Junior\source\repos\WebApplication2\WebApplication2\Views\Login\Login.cshtml"
                }

#line default
#line hidden
            BeginContext(3185, 56, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
