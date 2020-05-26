using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class FUNCIONARIO
    {

        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(FUNCIONARIO oFUNCIONARIO, DataContext MyDb)
        {
            MyDb.FUNCIONARIOs.InsertOnSubmit(oFUNCIONARIO);
        }

        public static void Incluir(FUNCIONARIO oFUNCIONARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oFUNCIONARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(FUNCIONARIO oFUNCIONARIO, DataContext MyDb)
        {
            MyDb.FUNCIONARIOs.Attach(oFUNCIONARIO, true);
        }

        public static void Alterar(FUNCIONARIO oFUNCIONARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oFUNCIONARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pFUMATFUNC, DataContext MyDB)
        {
            FUNCIONARIO oFUNCIONARIO = default(FUNCIONARIO);
            var res = from p in MyDB.FUNCIONARIOs where p.FUMATFUNC == pFUMATFUNC select p;
            if (res.Count() > 0)
            {
                oFUNCIONARIO = res.First();
                MyDB.FUNCIONARIOs.DeleteOnSubmit(oFUNCIONARIO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pFUMATFUNC)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            FUNCIONARIO oFUNCIONARIO = default(FUNCIONARIO);
            var res = from p in db.FUNCIONARIOs where p.FUMATFUNC == pFUMATFUNC select p;
            if (res.Count() > 0)
            {
                oFUNCIONARIO = res.First();
                db.FUNCIONARIOs.DeleteOnSubmit(oFUNCIONARIO);
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

        public static void Excluir(FUNCIONARIO oFUNCIONARIO, DataContext MyDb)
        {
            MyDb.FUNCIONARIOs.Attach(oFUNCIONARIO);
            MyDb.FUNCIONARIOs.DeleteOnSubmit(oFUNCIONARIO);
        }
        public static void Excluir(FUNCIONARIO oFUNCIONARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oFUNCIONARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<FUNCIONARIO> ListarTodos(DataContext MyDB)
        {
            List<FUNCIONARIO> oLista = new List<FUNCIONARIO>();
            var res = from p in MyDB.FUNCIONARIOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<FUNCIONARIO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static FUNCIONARIO SelecionaPK(int pFUMATFUNC, DataContext MyDB = null)
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
            FUNCIONARIO oFUNCIONARIO = default(FUNCIONARIO);
            var res = (from p in db.FUNCIONARIOs where p.FUMATFUNC == pFUMATFUNC select p).ToList();
            if (res.Count() > 0)
            {
                oFUNCIONARIO = res.First();
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
            return oFUNCIONARIO;
        }

        #endregion

    }
}
