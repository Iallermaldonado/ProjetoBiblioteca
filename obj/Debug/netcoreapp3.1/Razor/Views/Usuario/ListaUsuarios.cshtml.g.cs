#pragma checksum "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c279eaa578fc88c1c606ddfa6919651f017ac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaUsuarios.cshtml")]
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
#line 1 "C:\Users\ialle\Desktop\biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ialle\Desktop\biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c279eaa578fc88c1c606ddfa6919651f017ac5", @"/Views/Usuario/ListaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 7 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n\r\n        <tr >\r\n\r\n            <th scope=\"row\">Nome</th>\r\n\r\n            <th scope=\"row\">Login</th>\r\n\r\n            <th scope=\"row\">Tipo</th>\r\n\r\n        </tr>\r\n\r\n    </thead>\r\n\r\n\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
         foreach (Usuario u in Model)

        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 37 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 39 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
             if(u.Tipo==Usuario.ADMIN)

            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Administrador</td>\r\n");
#nullable restore
#line 46 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"

            }

            else

            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Padrão</td>\r\n");
#nullable restore
#line 54 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 737, "\"", 766, 2);
            WriteAttributeValue("", 744, "EditarUsuario?id=", 744, 17, true);
#nullable restore
#line 59 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 761, u.Id, 761, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 835, 2);
            WriteAttributeValue("", 812, "ExcluirUsuario?id=", 812, 18, true);
#nullable restore
#line 61 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 830, u.Id, 830, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\ialle\Desktop\biblioteca\Views\Usuario\ListaUsuarios.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n\r\n\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
