﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReportWeb.Models.JSON
{
    [DataContract]
    public class ALEValorizzaJson
    {
        [DataMember(Name = "IdAleDettaglio")]
        public decimal IdAleDettaglio { get; set; }

        [DataMember(Name = "Prezzo")]
        public decimal? Prezzo{ get; set; }

        [DataMember(Name = "Nota")]
        public string Nota { get; set; }
    }
}
