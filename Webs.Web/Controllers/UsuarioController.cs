using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webs.Domain.Entities;

namespace Webs.Web.Controllers
{
    [Route("api/[Controller]")]
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