using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class ACESSOPONTOCONTROLE
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE, DataContext MyDb)
        {
            MyDb.ACESSOPONTOCONTROLEs.InsertOnSubmit(oACESSOPONTOCONTROLE);
        }

        public static void Incluir(ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oACESSOPONTOCONTROLE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE, DataContext MyDb)
        {
            MyDb.ACESSOPONTOCONTROLEs.Attach(oACESSOPONTOCONTROLE, true);
        }

        public static void Alterar(ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oACESSOPONTOCONTROLE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pAPCodigo, DataContext MyDB)
        {
            ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE = default(ACESSOPONTOCONTROLE);
            var res = from p in MyDB.ACESSOPONTOCONTROLEs where p.APCodigo == pAPCodigo select p;
            if (res.Count() > 0)
            {
                oACESSOPONTOCONTROLE = res.First();
                MyDB.ACESSOPONTOCONTROLEs.DeleteOnSubmit(oACESSOPONTOCONTROLE);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pAPCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE = default(ACESSOPONTOCONTROLE);
            var res = from p in db.ACESSOPONTOCONTROLEs where p.APCodigo == pAPCodigo select p;
            if (res.Count() > 0)
            {
                oACESSOPONTOCONTROLE = res.First();
                db.ACESSOPONTOCONTROLEs.DeleteOnSubmit(oACESSOPONTOCONTROLE);
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

        public static void Excluir(ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE, DataContext MyDb)
        {
            MyDb.ACESSOPONTOCONTROLEs.Attach(oACESSOPONTOCONTROLE);
            MyDb.ACESSOPONTOCONTROLEs.DeleteOnSubmit(oACESSOPONTOCONTROLE);
        }
        public static void Excluir(ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oACESSOPONTOCONTROLE, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<ACESSOPONTOCONTROLE> ListarTodos(DataContext MyDB)
        {
            List<ACESSOPONTOCONTROLE> oLista = new List<ACESSOPONTOCONTROLE>();
            var res = from p in MyDB.ACESSOPONTOCONTROLEs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<ACESSOPONTOCONTROLE> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static ACESSOPONTOCONTROLE SelecionaPK(int pAPCodigo, DataContext MyDB = null)
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
            ACESSOPONTOCONTROLE oACESSOPONTOCONTROLE = default(ACESSOPONTOCONTROLE);
            var res = (from p in db.ACESSOPONTOCONTROLEs where p.APCodigo == pAPCodigo select p).ToList();
            if (res.Count > 0)
            {
                oACESSOPONTOCONTROLE = res.First();
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
            return oACESSOPONTOCONTROLE;
        }

        #endregion

    }
}
