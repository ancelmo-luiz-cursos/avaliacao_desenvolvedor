using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;

namespace Valinet.Web.Upload
{
    public class ArquivoService : IArquivoService
    {
        private static IList<Arquivo> _arquivos = new List<Arquivo>();

        private readonly IConfiguration _configuration;

        public ArquivoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IList<Arquivo>> ObterArquivos()
        {
            return await Task.Run(() =>
            {
                return _arquivos;
            });
        }

        public async Task SalvarArquivos(List<IFormFile> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                string fileName = CriarNomeArquivdo(arquivo.FileName);
                string fileFormat = ObterFormadoArquivo(fileName);

                byte[] bytesFile = ConvertFileInByteArray(arquivo);

                string directory = CriarPathArquivo(fileName);
                await System.IO.File.WriteAllBytesAsync(directory, bytesFile);

                var url = ObterUrlArquivo(fileName);
                _arquivos.Add(new Arquivo(url, fileFormat));
            }
        }

        private string CriarNomeArquivdo(string nome)
        {
            var novoNome = (Guid.NewGuid().ToString() + "_" + nome).ToLower();
            novoNome = novoNome.Replace("-", "");

            return novoNome;
        }

        private string ObterFormadoArquivo(string nomeArquivo)
        {
            var formato = nomeArquivo.Split(".").Last();
            return "." + formato;
        }

        private string CriarPathArquivo(string nomeArquivo)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), _configuration["Directories:Files"], nomeArquivo);
        }

        private string ObterUrlArquivo(string nomeArquivo)
        {
            var baseUrl = _configuration["Directories:BaseUrl"];

            var fileUrl = _configuration["Directories:Files"]
                .Replace("wwwroot", "")
                .Replace("\\", "");

            return (baseUrl + "/" + fileUrl + "/" + nomeArquivo);
        }

        private byte[] ConvertFileInByteArray(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
