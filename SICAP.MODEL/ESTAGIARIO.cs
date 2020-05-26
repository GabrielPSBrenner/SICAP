using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class ESTAGIARIO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(ESTAGIARIO oESTAGIARIO, DataContext MyDb)
        {
            MyDb.ESTAGIARIOs.InsertOnSubmit(oESTAGIARIO);
        }

        public static void Incluir(ESTAGIARIO oESTAGIARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oESTAGIARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(ESTAGIARIO oESTAGIARIO, DataContext MyDb)
        {
            MyDb.ESTAGIARIOs.Attach(oESTAGIARIO, true);
        }

        public static void Alterar(ESTAGIARIO oESTAGIARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oESTAGIARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pESCodigo, DataContext MyDB)
        {
            ESTAGIARIO oESTAGIARIO = default(ESTAGIARIO);
            var res = from p in MyDB.ESTAGIARIOs where p.ESCodigo == pESCodigo select p;
            if (res.Count() > 0)
            {
                oESTAGIARIO = res.First();
                MyDB.ESTAGIARIOs.DeleteOnSubmit(oESTAGIARIO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pESCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            ESTAGIARIO oESTAGIARIO = default(ESTAGIARIO);
            var res = from p in db.ESTAGIARIOs where p.ESCodigo == pESCodigo select p;
            if (res.Count() > 0)
            {
                oESTAGIARIO = res.First();
                db.ESTAGIARIOs.DeleteOnSubmit(oESTAGIARIO);
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

        public static void Excluir(ESTAGIARIO oESTAGIARIO, DataContext MyDb)
        {
            MyDb.ESTAGIARIOs.Attach(oESTAGIARIO);
            MyDb.ESTAGIARIOs.DeleteOnSubmit(oESTAGIARIO);
        }
        public static void Excluir(ESTAGIARIO oESTAGIARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oESTAGIARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<ESTAGIARIO> ListarTodos(DataContext MyDB)
        {
            List<ESTAGIARIO> oLista = new List<ESTAGIARIO>();
            var res = from p in MyDB.ESTAGIARIOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<ESTAGIARIO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static ESTAGIARIO SelecionaPK(int pESCodigo, DataContext MyDB = null)
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
            ESTAGIARIO oESTAGIARIO = default(ESTAGIARIO);
            var res = (from p in db.ESTAGIARIOs where p.ESCodigo == pESCodigo select p).ToList();

            oESTAGIARIO = res.FirstOrDefault();

            if (MyDB == null)
            {
                db.Dispose();
            }
            return oESTAGIARIO;
        }

        #endregion
    }
}
