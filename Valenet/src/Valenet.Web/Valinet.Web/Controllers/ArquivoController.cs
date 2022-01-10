using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valinet.Web.Upload;

namespace Valinet.Web.Controllers
{
    public class ArquivoController : Controller
    {
        private readonly IArquivoService _arquivoService;

        public ArquivoController(IArquivoService arquivoService)
        {
            _arquivoService = arquivoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(List<IFormFile> arquivos)
        {
            try
            {
                if (arquivos.Count > 0)
                {
                    await _arquivoService.SalvarArquivos(arquivos);
                    return View();
                }
                else
                {
                    return StatusCode(204, "Nenhum arquivo enviado!");
                }
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

    }
}
