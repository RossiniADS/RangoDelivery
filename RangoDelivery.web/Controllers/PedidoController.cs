using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using System.IO;

namespace RangoDelivery.web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        private IHttpContextAccessor _httpContextAccessor;
        private IWebHostEnvironment _webHostEnvironment;

        public PedidoController(IPedidoRepositorio pedidoRepositorio,
            IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _pedidoRepositorio = pedidoRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_pedidoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            try
            {
                _pedidoRepositorio.Adicionar(pedido);
                return Created("api/pedido", pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("enviarArquivo")]
        public IActionResult EnviarArquivo()
        {
            try
            {
                var formFile = _httpContextAccessor.HttpContext.Request.Form.Files[0];
                var nomeArquivo = formFile.FileName;
                var extensao = nomeArquivo.Split(".").Last();
                string novoNomeArquivo = GerarNovoNomeArquivo(nomeArquivo, extensao);
                var pastaArquivos = _webHostEnvironment.WebRootPath + "\\arquivos\\";
                var nomeCompleto = pastaArquivos + novoNomeArquivo;

                using (var streamArquivo = new FileStream(nomeCompleto, FileMode.Create))
                {
                    formFile.CopyTo(streamArquivo);
                }

                return Json(novoNomeArquivo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        private static string GerarNovoNomeArquivo(string nomeArquivo, string extensao)
        {
            var arrayNomeCompacto = Path.GetFileNameWithoutExtension(nomeArquivo).Take(10).ToArray();
            var novoNomeArquivo = new string(arrayNomeCompacto).Replace(" ", "-");
            novoNomeArquivo = $"{novoNomeArquivo}_{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.{extensao}";
            return novoNomeArquivo;
        }
    }
}
