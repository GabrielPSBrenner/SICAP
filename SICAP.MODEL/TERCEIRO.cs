using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class TERCEIRO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(TERCEIRO oTERCEIRO, DataContext MyDb)
        {
            MyDb.TERCEIROs.InsertOnSubmit(oTERCEIRO);
        }

        public static void Incluir(TERCEIRO oTERCEIRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oTERCEIRO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(TERCEIRO oTERCEIRO, DataContext MyDb)
        {
            MyDb.TERCEIROs.Attach(oTERCEIRO, true);
        }

        public static void Alterar(TERCEIRO oTERCEIRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oTERCEIRO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pTeCodigo, DataContext MyDB)
        {
            TERCEIRO oTERCEIRO = default(TERCEIRO);
            var res = from p in MyDB.TERCEIROs where p.TeCodigo == pTeCodigo select p;
            if (res.Count() > 0)
            {
                oTERCEIRO = res.First();
                MyDB.TERCEIROs.DeleteOnSubmit(oTERCEIRO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pTeCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            TERCEIRO oTERCEIRO = default(TERCEIRO);
            var res = from p in db.TERCEIROs where p.TeCodigo == pTeCodigo select p;
            if (res.Count() > 0)
            {
                oTERCEIRO = res.First();
                db.TERCEIROs.DeleteOnSubmit(oTERCEIRO);
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

        public static void Excluir(TERCEIRO oTERCEIRO, DataContext MyDb)
        {
            MyDb.TERCEIROs.Attach(oTERCEIRO);
            MyDb.TERCEIROs.DeleteOnSubmit(oTERCEIRO);
        }
        public static void Excluir(TERCEIRO oTERCEIRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oTERCEIRO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<TERCEIRO> ListarTodos(DataContext MyDB)
        {
            List<TERCEIRO> oLista = new List<TERCEIRO>();
            var res = from p in MyDB.TERCEIROs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<TERCEIRO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static TERCEIRO SelecionaPK(int pTeCodigo, DataContext MyDB = null)
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
            TERCEIRO oTERCEIRO = default(TERCEIRO);
            var res = (from p in db.TERCEIROs where p.TeCodigo == pTeCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oTERCEIRO = res.First();
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
            return oTERCEIRO;
        }

        #endregion

    }
}
