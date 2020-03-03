using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webs.Domain.Entities;

namespace Webs.Web.Controllers
{
    public class UsuarioController : Controller
    {

        [HttpPost("VerificarUsuario")]
        public IActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
			try
			{
                if (usuario.Email == "julio@teste" && usuario.Senha == "123")
                    return Ok(usuario);

                return BadRequest("Usuário ou senha inválido");
            }
			catch (Exception ex)
			{
                return BadRequest(ex.ToString());
			}
        }

    }
}