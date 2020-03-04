using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webs.Domain.Contracts;
using Webs.Domain.Entities;

namespace Webs.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost("VerificarUsuario")]
        public IActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
			try
			{
                var usuarioRet = _usuarioRepositorio.Obter(usuario.Email, usuario.Senha);
                if (usuarioRet != null)
                    return Ok(usuarioRet);

                return BadRequest("Usuário ou senha inválido");
            }
			catch (Exception ex)
			{
                return BadRequest(ex.ToString());
			}
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}