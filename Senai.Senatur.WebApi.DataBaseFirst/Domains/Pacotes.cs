using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.DataBaseFirst.Domains
{
    public partial class Pacotes
    {
        public int IdPacote { get; set; }
        public string NomePacote { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataIda { get; set; }
        public DateTime? DataVolta { get; set; }
        public decimal? Valor { get; set; }
        public string NomeCidade { get; set; }
        public int? IdStatusViagem { get; set; }

        public StatusViagem IdStatusViagemNavigation { get; set; }
    }
}
