﻿using ReportWeb.Business;
using ReportWeb.Models.ALE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportWeb.Controllers
{
    public class ALEController : ControllerBase
    {
        // GET: ALE
        public ActionResult Inserimento()
        {
            VerificaAbilitazioneUtenteConUscita(16);
            return View();
        }
        public ActionResult Addebito()
        {
            VerificaAbilitazioneUtenteConUscita(17);


            return View();
        }
        public ActionResult Valorizzazione()
        {
            VerificaAbilitazioneUtenteConUscita(18);
            return View();
        }
        public ActionResult Conferma()
        {
            VerificaAbilitazioneUtenteConUscita(19);
            return View();
        }
        public ActionResult Fatturazione()
        {
            VerificaAbilitazioneUtenteConUscita(20);
            return View();
        }

        public ActionResult CaricaScheda(string Barcode)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            InserimentoModel model = bll.CaricaScheda(Barcode);


            return PartialView("CaricaSchedaPartial", model);
        }

        public ActionResult SalvaInserimento(string Azienda, string Barcode, string IDCHECKQT, int Difettosi, int Inseriti, string Lavorante, string Nota)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.SalvaInserimento(Azienda, Barcode, IDCHECKQT, Difettosi, Inseriti, Lavorante, Nota, ConnectedUser);

            return null;
        }

        public ActionResult CaricaNuoviElementiDaAddebitare()
        {
            ALEBLL bAle = new ALEBLL(RvlImageSite);
            AddebitiModel model = bAle.LeggiSchedeDaAddebitare();

            return PartialView("CaricaNuoviElementiDaAddebitarePartial", model);
        }

        public ActionResult CaricaSchedeNonAddebitate()
        {
            ALEBLL bAle = new ALEBLL(RvlImageSite);
            AddebitiModel model = bAle.LeggiSchedeNonAddebitate();

            return PartialView("CaricaSchedeNonAddebitatePartial", model);
        }

        public ActionResult Addebita(string NotaGruppo, string Lavorante, string Addebiti)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.Addebita(NotaGruppo, Lavorante, Addebiti, ConnectedUser);
            return null;
        }

        public ActionResult NonAddebitare(string NotaGruppo, string Addebiti)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.NonAddebitare(NotaGruppo, Addebiti, ConnectedUser);
            return null;
        }

        public ActionResult ReinserisciDaAddebitare(decimal IdAleDettaglio)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.ReinserisciDaAddebitare(IdAleDettaglio, ConnectedUser);
            return null;
        }

        public ActionResult CaricaGruppiAddebitatiPartial()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoModel> model = bll.LeggiGruppi(ALEStatoDettaglio.ADDEBITATO);
            List<GruppoModel> modelValorizzato = bll.LeggiGruppi(ALEStatoDettaglio.VALORIZZATO);
            List<GruppoModel> modelApprovato = bll.LeggiGruppi(ALEStatoDettaglio.APPROVATO);
            model.AddRange(modelValorizzato);
            model.AddRange(modelApprovato);
            return PartialView("GruppiAddebitatiPartial", model);
        }

        public ActionResult AnnullaAddebito(int IDALEGRUPPO)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.AnnullaAddebita(IDALEGRUPPO);
            return null;
        }

        public ActionResult CaricaGruppiDaValorizzare()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoModel> model = bll.LeggiGruppi(ALEStatoDettaglio.ADDEBITATO);
            return PartialView("GruppiDaValorizzarePartial", model);
        }


        public ActionResult CaricaGruppiValorizzati()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoValorizzatoModel> model = bll.LeggiGruppiValorizzati();
            List<GruppoValorizzatoModel> altri = bll.LeggiAltriGruppiNonValorizzati();
            model.AddRange(altri);
            return PartialView("GruppiValorizzatiPartial", model);
        }

        public ActionResult Valorizza(string IDALEGRUPPO, string Dettagli, string Nota)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.Valorizza(IDALEGRUPPO, Dettagli, Nota, ConnectedUser);
            return null;
        }

        public ActionResult AnnullaValorizzazione(string IDALEGRUPPO)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.AnnullaValorizzazione(IDALEGRUPPO, ConnectedUser);
            return null;
        }

        public ActionResult CaricaGruppiDaApprovare()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoValorizzatoModel> model = bll.LeggiGruppiValorizzati();
            return PartialView("GruppiDaApprovarePartial", model);
        }


        public ActionResult CaricaGruppiApprovati()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoApprovatoModel> model = bll.LeggiGruppiApprovati();
            return PartialView("GruppiApprovatiPartial", model);
        }

        public ActionResult ApprovaGruppo(string IDALEGRUPPO, string Dettagli, string Nota)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.ApprovaGruppo(IDALEGRUPPO, Dettagli, Nota, ConnectedUser);
            return null;
        }

        public ActionResult AnnullaApprovazione(string IDALEGRUPPO)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.AnnullaApprovazione(IDALEGRUPPO, ConnectedUser);
            return null;
        }

        public ActionResult CaricaGruppiFatturati()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoFatturatoModel> model = bll.LeggiGruppiFatturati();
            return PartialView("GruppiFatturatiPartial", model);
        }


        public ActionResult CaricaGruppiDaFatturare()
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            List<GruppoApprovatoModel> model = bll.LeggiGruppiApprovati();
            return PartialView("GruppiDaFatturarePartial", model);
        }

        public ActionResult FatturaGruppo(string IDALEGRUPPO, string Dettagli, string Nota)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.FatturaGruppo(IDALEGRUPPO, Dettagli, Nota, ConnectedUser);
            return null;
        }
        public ActionResult AnnullaFatturazione(string IDALEGRUPPO)
        {
            ALEBLL bll = new ALEBLL(RvlImageSite);
            bll.AnnullaFatturaGruppo(IDALEGRUPPO, ConnectedUser);
            return null;
        }
    }
}