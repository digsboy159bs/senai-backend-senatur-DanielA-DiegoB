using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.DataBaseFirst.Domains
{
    public partial class StatusViagem
    {
        public StatusViagem()
        {
            Pacotes = new HashSet<Pacotes>();
        }

        public int IdStatusViagem { get; set; }
        public string TituloStatus { get; set; }

        public ICollection<Pacotes> Pacotes { get; set; }
    }
}
