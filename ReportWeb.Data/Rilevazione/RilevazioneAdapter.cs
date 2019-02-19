﻿using ReportWeb.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWeb.Data.Rilevazione
{
    public class RilevazioneAdapter : ReportWebAdapterBase
    {
        public RilevazioneAdapter(System.Data.IDbConnection connection, IDbTransaction transaction) :
            base(connection, transaction)
        { }

        public void FillUSR_PRD_RESOURCESF(RilevazioniDS ds, string BARCODE)
        {

            string query = @"SELECT * FROM gruppo.USR_PRD_RESOURCESF WHERE BARCODE = $P{BARCODE}";

            ParamSet ps = new ParamSet();
            ps.AddParam("BARCODE", DbType.String, BARCODE);

            using (DbDataAdapter da = BuildDataAdapter(query, ps))
            {
                da.Fill(ds.USR_PRD_RESOURCESF);
            }
        }

        public void FillRW_TEMPI_APERTI(RilevazioniDS ds, string BARCODE)
        {

            string query = @"SELECT * FROM RW_TEMPI WHERE APERTO = 1 AND BARCODE_UTENTE = $P{BARCODE}";

            ParamSet ps = new ParamSet();
            ps.AddParam("BARCODE", DbType.String, BARCODE);

            using (DbDataAdapter da = BuildDataAdapter(query, ps))
            {
                da.Fill(ds.RW_TEMPI);
            }
        }

        public void FillRW_TEMPI_APERTI_PER_UTENTE(RilevazioniDS ds, string UTENTE)
        {

            string query = @"SELECT * FROM RW_TEMPI WHERE APERTO = 1 AND UTENTE = $P{UTENTE}";

            ParamSet ps = new ParamSet();
            ps.AddParam("UTENTE", DbType.String, UTENTE);

            using (DbDataAdapter da = BuildDataAdapter(query, ps))
            {
                da.Fill(ds.RW_TEMPI);
            }
        }

        public void FillRW_TEMPI_LAVORAZIONI(RilevazioniDS ds)
        {
            string query = @"SELECT * FROM RW_TEMPI_LAVORAZIONI ORDER BY SEQUENZA";

            using (DbDataAdapter da = BuildDataAdapter(query))
            {
                da.Fill(ds.RW_TEMPI_LAVORAZIONI);
            }
        }

        public void FillRW_TEMPI_REPARTI(RilevazioniDS ds)
        {
            string query = @"SELECT * FROM RW_TEMPI_REPARTI ORDER BY REPARTO, UTENTE";

            using (DbDataAdapter da = BuildDataAdapter(query))
            {
                da.Fill(ds.RW_TEMPI_REPARTI);
            }
        }


        public void UpdateRegistrazioneDS(string tablename, RilevazioniDS ds)
        {
            string query = string.Format(CultureInfo.InvariantCulture, "SELECT * FROM {0}", tablename);

            using (DbDataAdapter a = BuildDataAdapter(query))
            {
                a.ContinueUpdateOnError = false;
                DataTable dt = ds.Tables[tablename];
                DbCommandBuilder cmd = BuildCommandBuilder(a);
                a.UpdateCommand = cmd.GetUpdateCommand();
                a.DeleteCommand = cmd.GetDeleteCommand();
                a.InsertCommand = cmd.GetInsertCommand();
                a.Update(dt);
            }
        }
    }
}
