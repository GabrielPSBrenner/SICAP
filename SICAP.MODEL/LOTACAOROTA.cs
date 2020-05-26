using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class LOTACAOROTA
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(LOTACAOROTA oLOTACAOROTA, DataContext MyDb)
        {
            MyDb.LOTACAOROTAs.InsertOnSubmit(oLOTACAOROTA);
        }

        public static void Incluir(LOTACAOROTA oLOTACAOROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oLOTACAOROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(LOTACAOROTA oLOTACAOROTA, DataContext MyDb)
        {
            MyDb.LOTACAOROTAs.Attach(oLOTACAOROTA, true);
        }

        public static void Alterar(LOTACAOROTA oLOTACAOROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oLOTACAOROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pLRCodigo, DataContext MyDB)
        {
            LOTACAOROTA oLOTACAOROTA = default(LOTACAOROTA);
            var res = from p in MyDB.LOTACAOROTAs where p.LRCodigo == pLRCodigo select p;
            if (res.Count() > 0)
            {
                oLOTACAOROTA = res.First();
                MyDB.LOTACAOROTAs.DeleteOnSubmit(oLOTACAOROTA);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pLRCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            LOTACAOROTA oLOTACAOROTA = default(LOTACAOROTA);
            var res = from p in db.LOTACAOROTAs where p.LRCodigo == pLRCodigo select p;
            if (res.Count() > 0)
            {
                oLOTACAOROTA = res.First();
                db.LOTACAOROTAs.DeleteOnSubmit(oLOTACAOROTA);
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

        public static void Excluir(LOTACAOROTA oLOTACAOROTA, DataContext MyDb)
        {
            MyDb.LOTACAOROTAs.Attach(oLOTACAOROTA);
            MyDb.LOTACAOROTAs.DeleteOnSubmit(oLOTACAOROTA);
        }
        public static void Excluir(LOTACAOROTA oLOTACAOROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oLOTACAOROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<LOTACAOROTA> ListarTodos(DataContext MyDB)
        {
            List<LOTACAOROTA> oLista = new List<LOTACAOROTA>();
            var res = from p in MyDB.LOTACAOROTAs select p;
            oLista = res.ToList();
            return oLista;
        }

        public static List<LOTACAOROTA> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static LOTACAOROTA SelecionaPK(int pLRCodigo, DataContext MyDB = null)
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
            LOTACAOROTA oLOTACAOROTA = default(LOTACAOROTA);
            var res = (from p in db.LOTACAOROTAs where p.LRCodigo == pLRCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oLOTACAOROTA = res.First();
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
            return oLOTACAOROTA;
        }

        #endregion

    }
}
