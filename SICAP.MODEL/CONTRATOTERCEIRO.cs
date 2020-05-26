using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class CONTRATOTERCEIRO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(CONTRATOTERCEIRO oCONTRATOTERCEIRO, DataContext MyDb)
        {
            MyDb.CONTRATOTERCEIROs.InsertOnSubmit(oCONTRATOTERCEIRO);
        }

        public static void Incluir(CONTRATOTERCEIRO oCONTRATOTERCEIRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oCONTRATOTERCEIRO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(CONTRATOTERCEIRO oCONTRATOTERCEIRO, DataContext MyDb)
        {
            MyDb.CONTRATOTERCEIROs.Attach(oCONTRATOTERCEIRO, true);
        }

        public static void Alterar(CONTRATOTERCEIRO oCONTRATOTERCEIRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oCONTRATOTERCEIRO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pCTCodigo, DataContext MyDB)
        {
            CONTRATOTERCEIRO oCONTRATOTERCEIRO = default(CONTRATOTERCEIRO);
            var res = from p in MyDB.CONTRATOTERCEIROs where p.CTCodigo == pCTCodigo select p;
            if (res.Count() > 0)
            {
                oCONTRATOTERCEIRO = res.First();
                MyDB.CONTRATOTERCEIROs.DeleteOnSubmit(oCONTRATOTERCEIRO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pCTCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            CONTRATOTERCEIRO oCONTRATOTERCEIRO = default(CONTRATOTERCEIRO);
            var res = from p in db.CONTRATOTERCEIROs where p.CTCodigo == pCTCodigo select p;
            if (res.Count() > 0)
            {
                oCONTRATOTERCEIRO = res.First();
                db.CONTRATOTERCEIROs.DeleteOnSubmit(oCONTRATOTERCEIRO);
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

        public static void Excluir(CONTRATOTERCEIRO oCONTRATOTERCEIRO, DataContext MyDb)
        {
            MyDb.CONTRATOTERCEIROs.Attach(oCONTRATOTERCEIRO);
            MyDb.CONTRATOTERCEIROs.DeleteOnSubmit(oCONTRATOTERCEIRO);
        }
        public static void Excluir(CONTRATOTERCEIRO oCONTRATOTERCEIRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oCONTRATOTERCEIRO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<CONTRATOTERCEIRO> ListarTodos(DataContext MyDB)
        {
            List<CONTRATOTERCEIRO> oLista = new List<CONTRATOTERCEIRO>();
            var res = from p in MyDB.CONTRATOTERCEIROs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<CONTRATOTERCEIRO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static CONTRATOTERCEIRO SelecionaPK(int pCTCodigo, DataContext MyDB = null)
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
            CONTRATOTERCEIRO oCONTRATOTERCEIRO = default(CONTRATOTERCEIRO);
            var res = (from p in db.CONTRATOTERCEIROs where p.CTCodigo == pCTCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oCONTRATOTERCEIRO = res.First();
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
            return oCONTRATOTERCEIRO;
        }

        public static CONTRATOTERCEIRO SelecionaContratoValido(int CodigoTerceiro, DataContext db)
        {
            CONTRATOTERCEIRO oCONTRATOTERCEIRO = null;
            var res = (from p in db.CONTRATOTERCEIROs where p.CTCodigoTerceiro == CodigoTerceiro && p.CTDataExpiracaoContrato > DateTime.Now && p.CTDataInicioContrato <= DateTime.Now select p).ToList();
            if (res.Count() > 0)
            {
                oCONTRATOTERCEIRO = res.First();
            }
            return oCONTRATOTERCEIRO;
        }


        public static CONTRATOTERCEIRO SelecionaContratoValido(int CodigoTerceiro)
        {
            DataContext db = default(DataContext);
            db = new DataContext(MyGlobal.ConnectionString);
            CONTRATOTERCEIRO oCONTRATOTERCEIRO = null;
            var res = (from p in db.CONTRATOTERCEIROs where p.CTCodigoTerceiro == CodigoTerceiro && p.CTDataExpiracaoContrato > DateTime.Now && p.CTDataInicioContrato <= DateTime.Now select p).ToList();
            if (res.Count() > 0)
            {
                oCONTRATOTERCEIRO = res.First();
            }
            else
            {
                db.Dispose();
                throw new Exception("Não foi possível selecionar o ítem, porque o mesmo não existe na base de dados.");
            }
                db.Dispose();
            return oCONTRATOTERCEIRO;
        }
        #endregion

    }
}
