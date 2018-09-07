﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWeb.Models.ALE
{

    public class GruppoModel
    {
        public List<AddebitoModel> Dettagli { get; set; }
        public string NotaAddebito { get; set; }
        public string LavoranteCodice { get; set; }
        public string LavoranteDescrizione { get; set; }
        public bool Aperto { get; set; }
        public decimal IDALEGRUPPO { get; set; }
        public bool AddebitoAnnulabile{ get; set; }
    }

    public class GruppoValorizzatoModel
    {
        public List<ValorizzatoModel> Dettagli { get; set; }
        public string NotaValorizzazione { get; set; }
        public string LavoranteCodice { get; set; }
        public string LavoranteDescrizione { get; set; }
        public bool Aperto { get; set; }
        public decimal IDALEGRUPPO { get; set; }
        public bool ValorizzazioneAnnullabile { get; set; }

    }

}
