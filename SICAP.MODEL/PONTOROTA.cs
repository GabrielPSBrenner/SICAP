using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class PONTOROTA
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(PONTOROTA oPONTOROTA, DataContext MyDb)
        {
            MyDb.PONTOROTAs.InsertOnSubmit(oPONTOROTA);
        }

        public static void Incluir(PONTOROTA oPONTOROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oPONTOROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(PONTOROTA oPONTOROTA, DataContext MyDb)
        {
            MyDb.PONTOROTAs.Attach(oPONTOROTA, true);
        }

        public static void Alterar(PONTOROTA oPONTOROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oPONTOROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pPRCodigoPontoControle, int pPRCodigoRota, string pPRTipoPontoControle, DataContext MyDB)
        {
            PONTOROTA oPONTOROTA = default(PONTOROTA);
            var res = from p in MyDB.PONTOROTAs where p.PRCodigoPontoControle == pPRCodigoPontoControle && p.PRCodigoRota == pPRCodigoRota && p.PRTipoPontoControle.Equals(pPRTipoPontoControle) select p;
            if (res.Count() > 0)
            {
                oPONTOROTA = res.First();
                MyDB.PONTOROTAs.DeleteOnSubmit(oPONTOROTA);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pPRCodigoPontoControle, int pPRCodigoRota, string pPRTipoPontoControle)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            PONTOROTA oPONTOROTA = default(PONTOROTA);
            var res = from p in db.PONTOROTAs where p.PRCodigoPontoControle == pPRCodigoPontoControle && p.PRCodigoRota == pPRCodigoRota && p.PRTipoPontoControle.Equals(pPRTipoPontoControle) select p;
            if (res.Count() > 0)
            {
                oPONTOROTA = res.First();
                db.PONTOROTAs.DeleteOnSubmit(oPONTOROTA);
                db.SubmitChanges();
                db.Dispose();
            }
            else
            {
                db.Dispose();
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
            db.Dispose();
        }

        public static void Excluir(PONTOROTA oPONTOROTA, DataContext MyDb)
        {
            MyDb.PONTOROTAs.Attach(oPONTOROTA);
            MyDb.PONTOROTAs.DeleteOnSubmit(oPONTOROTA);
        }
        public static void Excluir(PONTOROTA oPONTOROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oPONTOROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<PONTOROTA> ListarTodos(DataContext MyDB)
        {
            List<PONTOROTA> oLista = new List<PONTOROTA>();
            var res = from p in MyDB.PONTOROTAs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<PONTOROTA> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }

        public static List<PONTOROTA> ListarPontosDaRota(int Codigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.PONTOROTAs where p.PRCodigoRota == Codigo select p;
            var retorno = res.ToList();
            db.Dispose();
            return retorno;
        }


        public static PONTOROTA SelecionaPK(int pPRCodigoPontoControle, int pPRCodigoRota, string pPRTipoPontoControle, DataContext MyDB = null)
        {
            DataContext db = default(DataContext);

            if ((MyDB != null))
            {
                db = MyDB;
            }
            else
            {
                db = new DataContext(MyGlobal.ConnectionString);
            }
            PONTOROTA oPONTOROTA = default(PONTOROTA);
            var res = (from p in db.PONTOROTAs where p.PRCodigoPontoControle == pPRCodigoPontoControle && p.PRCodigoRota == pPRCodigoRota && p.PRTipoPontoControle.Equals(pPRTipoPontoControle) select p).ToList();
            if (res.Count() > 0)
            {
                oPONTOROTA = res.First();
            }
            else
            {
                db.Dispose();
                throw new Exception("Não foi possível selecionar o ítem, porque o mesmo não existe na base de dados.");
            }
            if (MyDB == null)
            {
                db.Dispose();
            }
            return oPONTOROTA;
        }

        #endregion

    }
}
