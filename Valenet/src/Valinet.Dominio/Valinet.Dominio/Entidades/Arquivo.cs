using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valinet.Dominio.Entidades
{
    public class Arquivo
    {
        public Arquivo(string url, string formato)
        {
            Url = url;
            Formato = formato;
        }
        public string Url { get; private set; }
        public string Formato { get; private set; }
    }
}
