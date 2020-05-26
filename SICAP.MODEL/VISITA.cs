using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class VISITA
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(VISITA oVISITA, DataContext MyDb)
        {
            MyDb.VISITAs.InsertOnSubmit(oVISITA);
        }

        public static void Incluir(VISITA oVISITA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oVISITA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(VISITA oVISITA, DataContext MyDb)
        {
            MyDb.VISITAs.Attach(oVISITA, true);
        }

        public static void Alterar(VISITA oVISITA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oVISITA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pVtCodigo, DataContext MyDB)
        {
            VISITA oVISITA = default(VISITA);
            var res = from p in MyDB.VISITAs where p.VtCodigo == pVtCodigo select p;
            if (res.Count() > 0)
            {
                oVISITA = res.First();
                MyDB.VISITAs.DeleteOnSubmit(oVISITA);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pVtCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            VISITA oVISITA = default(VISITA);
            var res = from p in db.VISITAs where p.VtCodigo == pVtCodigo select p;
            if (res.Count() > 0)
            {
                oVISITA = res.First();
                db.VISITAs.DeleteOnSubmit(oVISITA);
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

        public static void Excluir(VISITA oVISITA, DataContext MyDb)
        {
            MyDb.VISITAs.Attach(oVISITA);
            MyDb.VISITAs.DeleteOnSubmit(oVISITA);
        }
        public static void Excluir(VISITA oVISITA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oVISITA, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<VISITA> ListarTodos(DataContext MyDB)
        {
            List<VISITA> oLista = new List<VISITA>();
            var res = from p in MyDB.VISITAs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<VISITA> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static VISITA SelecionaPK(int pVtCodigo, DataContext MyDB = null)
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
            VISITA oVISITA = default(VISITA);
            var res = (from p in db.VISITAs where p.VtCodigo == pVtCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oVISITA = res.First();
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
            return oVISITA;
        }


        public static VISITA SelecionaVisitaValida(int CodigoVisitante, DataContext db)
        {
            var res = from p in db.VISITAs where p.VtDataInicio <= DateTime.Now && p.VtDataTermino >= DateTime.Now && p.VtCodigoVisitante == CodigoVisitante select p;
            VISITA oVisita = null;
            if (res.Count() > 0)
            {
                oVisita = res.First();
            }
            return oVisita;
        }
        #endregion

    }
}
