using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valinet.Dominio.Entidades;

namespace Valinet.Web.Upload
{
    public interface IArquivoService
    {
        Task SalvarArquivos(List<IFormFile> arquivos);
        Task<IList<Arquivo>> ObterArquivos();
    }
}
