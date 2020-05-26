using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class LOTACAO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(LOTACAO oLOTACAO, DataContext MyDb)
        {
            MyDb.LOTACAOs.InsertOnSubmit(oLOTACAO);
        }

        public static void Incluir(LOTACAO oLOTACAO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oLOTACAO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(LOTACAO oLOTACAO, DataContext MyDb)
        {
            MyDb.LOTACAOs.Attach(oLOTACAO, true);
        }

        public static void Alterar(LOTACAO oLOTACAO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oLOTACAO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(string pLoCodigo, int pLoCodigoLocalidade, DataContext MyDB)
        {
            LOTACAO oLOTACAO = default(LOTACAO);
            var res = from p in MyDB.LOTACAOs where p.LoCodigo == pLoCodigo && p.LoCodigoLocalidade == pLoCodigoLocalidade select p;
            if (res.Count() > 0)
            {
                oLOTACAO = res.First();
                MyDB.LOTACAOs.DeleteOnSubmit(oLOTACAO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(string pLoCodigo, int pLoCodigoLocalidade)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            LOTACAO oLOTACAO = default(LOTACAO);
            var res = from p in db.LOTACAOs where p.LoCodigo == pLoCodigo && p.LoCodigoLocalidade == pLoCodigoLocalidade select p;
            if (res.Count() > 0)
            {
                oLOTACAO = res.First();
                db.LOTACAOs.DeleteOnSubmit(oLOTACAO);
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

        public static void Excluir(LOTACAO oLOTACAO, DataContext MyDb)
        {
            MyDb.LOTACAOs.Attach(oLOTACAO);
            MyDb.LOTACAOs.DeleteOnSubmit(oLOTACAO);
        }
        public static void Excluir(LOTACAO oLOTACAO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oLOTACAO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<LOTACAO> ListarTodos(DataContext MyDB)
        {
            List<LOTACAO> oLista = new List<LOTACAO>();
            var res = from p in MyDB.LOTACAOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<LOTACAO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static LOTACAO SelecionaPK(string pLoCodigo, int pLoCodigoLocalidade, DataContext MyDB = null)
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
            LOTACAO oLOTACAO = default(LOTACAO);
            var res = (from p in db.LOTACAOs where p.LoCodigo == pLoCodigo && p.LoCodigoLocalidade == pLoCodigoLocalidade select p).ToList();
            if (res.Count() > 0)
            {
                oLOTACAO = res.First();
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
            return oLOTACAO;
        }

        #endregion

    }
}
