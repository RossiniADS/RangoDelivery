using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_clienteRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarCliente")]
        public IActionResult VerificarCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente.Email == "rossini.g.r.alves@gmail.com" && cliente.Senha == "1234")
                {
                    return Ok(cliente);
                }
                return BadRequest("Cliente ou senha inválidos");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Adicionar(cliente);
                return Created("cliente", cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
