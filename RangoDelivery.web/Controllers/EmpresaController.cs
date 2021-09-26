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
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;
        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_empresaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarEmpresa")]
        public IActionResult VerificarEmpresa([FromBody] Empresa empresa)
        {
            try
            {
                var empresaRetorno = _empresaRepositorio.Obter(empresa.Email, empresa.Senha);

                if (empresaRetorno != null)
                {
                    return Ok(empresaRetorno);
                }
                return BadRequest("Empresa ou senha inválidos");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Empresa empresa)
        {
            try
            {
                var empresaCadastrada = _empresaRepositorio.Obter(empresa.Email);
                if (empresaCadastrada != null)
                {
                    return BadRequest("Empresa já cadastrado no sistema");
                }
                empresa.UrlFoto = "Vazio";
                empresa.Cnpj = "49968878988";
                empresa.NumeroEndereco = "98";
                empresa.RazaoSocial = "123456";


                _empresaRepositorio.Adicionar(empresa);
                //return Created("empresa", empresa);

                 return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
