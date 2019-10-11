﻿using ReportWeb.Common.Helpers;
using ReportWeb.Data.Core;
using ReportWeb.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWeb.Data.ALE
{
    public class ALEBusiness : ReportWebBusinessBase
    {
        public ALEBusiness() : base() { }

        [DataContext]
        public void FillUSR_CHECKQ_T(ALEDS ds, string Barcode)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_CHECKQ_T(ds, Barcode);
        }

        [DataContext]
        public void FillUSR_CHECKQ_T(ALEDS ds, List<string> IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_CHECKQ_T(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillUSR_CHECKQ_D(ALEDS ds, string IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_CHECKQ_D(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillUSR_CHECKQ_C(ALEDS ds, List<string> IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_CHECKQ_C(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillUSR_CHECKQ_C(ALEDS ds, string IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_CHECKQ_C(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillUSR_TAB_TIPODIFETTI(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_TAB_TIPODIFETTI(ds);
        }

        [DataContext]
        public void FillUSR_ANA_DIFETTI(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_ANA_DIFETTI(ds);
        }

        [DataContext]
        public void FillTABCAUMGT(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillTABCAUMGT(ds);
        }

        [DataContext]
        public void FillCLIFO(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillCLIFO(ds);
        }

        [DataContext]
        public void FillRW_ALE_RIPGRATUITA(ALEDS ds, string DataInizio, string DataFine)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_RIPGRATUITA(ds, DataInizio, DataFine);
        }

        [DataContext]
        public void NascondiRiga(ALEDS ds, string IDRIPGRATUITA)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.NascondiRiga(ds, IDRIPGRATUITA);
        }

        [DataContext]
        public void FillCLIFO(ALEDS ds, string Codice)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillCLIFO(ds, Codice);
        }

        [DataContext]
        public void FillUSR_PRD_FLUSSO_MOVFASI(ALEDS ds, string IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_PRD_FLUSSO_MOVFASI(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillRW_ALE_FASI_DA_ES_DIBA(ALEDS ds, List<string> IDMAGAZZ)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_FASI_DA_ES_DIBA(ds, IDMAGAZZ);
        }

        [DataContext]
        public void FillRW_ALE_COSTO_MAGAZZ(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_COSTO_MAGAZZ(ds);
        }

        [DataContext]
        public string GetIdMagazzFromIdDettaglio(decimal iddettaglio)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            return a.GetIdMagazzFromIdDettaglio(iddettaglio);
        }

        [DataContext]
        public void FillRW_ALE_DETT_COSTO(ALEDS ds, List<decimal> IDALEDETTAGLIO)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_DETT_COSTO(ds, IDALEDETTAGLIO);
        }

        [DataContext]
        public void FillUSR_PRD_MOVFASI(ALEDS ds, string IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_PRD_MOVFASI(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillUSR_PRD_MOVFASI(ALEDS ds, List<string> IDCHECKQT)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_PRD_MOVFASI(ds, IDCHECKQT);
        }

        [DataContext]
        public void FillMAGAZZ(ALEDS ds, string IDMAGAZZ)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillMAGAZZ(ds, IDMAGAZZ);
        }

        [DataContext]
        public void FillMAGAZZ(ALEDS ds, List<string> IDMAGAZZ)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillMAGAZZ(ds, IDMAGAZZ.Distinct().ToList());
        }

        [DataContext]
        public void FillUSR_PDM_FILES(ALEDS ds, string IDMAGAZZ)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_PDM_FILES(ds, IDMAGAZZ);
        }

        [DataContext]
        public void FillUSR_PDM_FILES(ALEDS ds, List<string> IDMAGAZZ)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_PDM_FILES(ds, IDMAGAZZ.Distinct().ToList());
        }

        [DataContext(true)]
        public void SalvaInserimento(string Azienda, string Barcode, string IDCHECKQT, int Difettosi, int Inseriti, string Lavorante, string Nota, string UIDUSER, bool Mancante, bool scartoDefinitivo)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.InsertRW_ALE_DETTAGLIO(Azienda, Barcode, IDCHECKQT, Difettosi, Inseriti, Lavorante, Mancante, Nota, scartoDefinitivo, UIDUSER);
        }

        [DataContext(true)]
        public void SalvaInserimentoRW_ALE_RIPGRATUITA(string Azienda, string ODL, string UIDUSER, int EstensioneFattura, bool Nascondi)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.InsertRW_ALE_RIPGRATUITA(Azienda, ODL, UIDUSER, EstensioneFattura, Nascondi);
        }

        [DataContext]
        public void FillRW_ALE_DETTAGLIO(ALEDS ds, string STATO)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);

            a.FillRW_ALE_DETTAGLIO(ds, STATO);
        }

        [DataContext]
        public void FillRW_ALE_DETTAGLIOByBarcode(ALEDS ds, string Barcode)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_DETTAGLIOByBarcode(ds, Barcode);
        }
        [DataContext(true)]
        public int CreaGruppo(string NotaAddebito, string Lavorante, string UIDUSER, bool Rilavorazione)
        {
            Int32 id = (int)GetID();
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.InsertRW_ALE_GRUPPO(id, NotaAddebito, Lavorante, UIDUSER, Rilavorazione);
            return id;
        }

        [DataContext(true)]
        public void UpdateRW_ALE_DETTAGLIO(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.UpdateALEDSTable(ds.RW_ALE_DETTAGLIO.TableName, ds);
        }

        [DataContext]
        public void FillRW_ALE_GRUPPO(ALEDS ds, List<decimal> IDALEGRUPPO)
        {
            ALEAdapter a = new Data.ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_GRUPPO(ds, IDALEGRUPPO);
        }

        [DataContext]
        public void FillRW_ALE_GRUPPO(ALEDS ds, decimal IDALEGRUPPO)
        {
            ALEAdapter a = new Data.ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_GRUPPO(ds, IDALEGRUPPO);
        }

        [DataContext(true)]
        public void UpdateRW_ALE_GRUPPO(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.UpdateALEDSTable(ds.RW_ALE_GRUPPO.TableName, ds);
        }
        [DataContext(true)]
        public void UpdateRW_ALE_DETT_COSTO(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.UpdateALEDSTable(ds.RW_ALE_DETT_COSTO.TableName, ds);
        }
        [DataContext(true)]
        public void UpdateRW_ALE_COSTO_MAGAZZ(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.UpdateALEDSTable(ds.RW_ALE_COSTO_MAGAZZ.TableName, ds);
        }
        [DataContext]
        public void FillRW_ALE_GRUPPO(ALEDS ds, bool Aperto)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_GRUPPO(ds, Aperto);
        }

        [DataContext]
        public void FillRW_ALE_DETTAGLIO(ALEDS ds, decimal IDALEGRUPPO)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_DETTAGLIO(ds, IDALEGRUPPO);
        }

        [DataContext]
        public void FillRW_ALE_DETTAGLIO(ALEDS ds, List<decimal> IDALEGRUPPO)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_DETTAGLIO(ds, IDALEGRUPPO);
        }

        [DataContext]
        public void FillRW_ALE_DETTAGLIO(ALEDS ds, string dataInizio, string dataFine, bool SoloMancante)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_DETTAGLIO(ds, dataInizio, dataFine, SoloMancante);
        }

        [DataContext]
        public void FillRW_ALE_DETTAGLIOByPK(ALEDS ds, decimal IdAleDettaglio)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_DETTAGLIOByPK(ds, IdAleDettaglio);
        }

        [DataContext]
        public void FillTABFAS(ALEDS ds)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillTABFAS(ds);
        }

        [DataContext]
        public void FillUSR_PRD_FASI(ALEDS ds, List<string> IDPRDMOVFASE)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillUSR_PRD_FASI(ds, IDPRDMOVFASE);
        }

        [DataContext]
        public void FillRW_ALE_GRUPPOFatturato(ALEDS ds, DateTime DataInizio, DateTime DataFine)
        {
            ALEAdapter a = new ALEAdapter(DbConnection, DbTransaction);
            a.FillRW_ALE_GRUPPOFatturato(ds, DataInizio, DataFine);
        }
    }
}
