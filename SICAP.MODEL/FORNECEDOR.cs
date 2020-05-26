using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class FORNECEDOR
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(FORNECEDOR oFORNECEDOR, DataContext MyDb)
        {
            MyDb.FORNECEDORs.InsertOnSubmit(oFORNECEDOR);
        }

        public static void Incluir(FORNECEDOR oFORNECEDOR)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oFORNECEDOR, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(FORNECEDOR oFORNECEDOR, DataContext MyDb)
        {
            MyDb.FORNECEDORs.Attach(oFORNECEDOR, true);
        }

        public static void Alterar(FORNECEDOR oFORNECEDOR)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oFORNECEDOR, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(string pFOCNPJ, DataContext MyDB)
        {
            FORNECEDOR oFORNECEDOR = default(FORNECEDOR);
            var res = from p in MyDB.FORNECEDORs where p.FOCNPJ == pFOCNPJ select p;
            if (res.Count() > 0)
            {
                oFORNECEDOR = res.First();
                MyDB.FORNECEDORs.DeleteOnSubmit(oFORNECEDOR);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(string pFOCNPJ)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            FORNECEDOR oFORNECEDOR = default(FORNECEDOR);
            var res = from p in db.FORNECEDORs where p.FOCNPJ == pFOCNPJ select p;
            if (res.Count() > 0)
            {
                oFORNECEDOR = res.First();
                db.FORNECEDORs.DeleteOnSubmit(oFORNECEDOR);
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

        public static void Excluir(FORNECEDOR oFORNECEDOR, DataContext MyDb)
        {
            MyDb.FORNECEDORs.Attach(oFORNECEDOR);
            MyDb.FORNECEDORs.DeleteOnSubmit(oFORNECEDOR);
        }
        public static void Excluir(FORNECEDOR oFORNECEDOR)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oFORNECEDOR, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<FORNECEDOR> ListarTodos(DataContext MyDB)
        {
            List<FORNECEDOR> oLista = new List<FORNECEDOR>();
            var res = from p in MyDB.FORNECEDORs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<FORNECEDOR> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static FORNECEDOR SelecionaPK(string pFOCNPJ, DataContext MyDB = null)
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
            FORNECEDOR oFORNECEDOR = default(FORNECEDOR);
            var res = (from p in db.FORNECEDORs where p.FOCNPJ == pFOCNPJ select p).ToList();
            if (res.Count > 0)
            {
                oFORNECEDOR = res.First();
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
            return oFORNECEDOR;
        }

        #endregion

    }
}
