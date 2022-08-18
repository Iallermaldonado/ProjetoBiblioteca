

using Biblioteca.Models;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult CadastrarUsuario()
        {
             Autenticacao.CheckLogin(this);
             Autenticacao.verificaSeUsuarioEAdmin(this);
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario user)
        {
            user.Senha = Criptografia.TextoCriptografado(user.Senha);
           new UsuarioService().Inserir(user);
            return RedirectToAction("ListaUsuarios");
        }


        public IActionResult ListaUsuarios()
        {
             Autenticacao.CheckLogin(this);
             Autenticacao.verificaSeUsuarioEAdmin(this);
            return View(new UsuarioService().Listar());
        }

        public IActionResult EditarUsuario(int id)
        {
             Autenticacao.CheckLogin(this);
             Autenticacao.verificaSeUsuarioEAdmin(this);
             Usuario u = new UsuarioService().Listar(id);
             return View(u);
        }
        [HttpPost]
        public IActionResult EditarUsuario(Usuario userEditado)
        {
            Autenticacao.CheckLogin(this);
             Autenticacao.verificaSeUsuarioEAdmin(this);
            new UsuarioService().Editar(userEditado);  
            return RedirectToAction("ListaUsuarios");
        }
        

           public IActionResult ExcluirUsuario(int id)
        {
             Autenticacao.CheckLogin(this);
             Autenticacao.verificaSeUsuarioEAdmin(this);
             new UsuarioService().Excluir(id);

            return RedirectToAction("ListaUsuarios");
        }


        
        public IActionResult Permissao()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
        
        
        
         public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","Home");
        }

    }
}