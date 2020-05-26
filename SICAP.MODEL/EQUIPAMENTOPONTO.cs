using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class EQUIPAMENTOPONTO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(EQUIPAMENTOPONTO oEQUIPAMENTOPONTO, DataContext MyDb)
        {
            MyDb.EQUIPAMENTOPONTOs.InsertOnSubmit(oEQUIPAMENTOPONTO);
        }

        public static void Incluir(EQUIPAMENTOPONTO oEQUIPAMENTOPONTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oEQUIPAMENTOPONTO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(EQUIPAMENTOPONTO oEQUIPAMENTOPONTO, DataContext MyDb)
        {
            MyDb.EQUIPAMENTOPONTOs.Attach(oEQUIPAMENTOPONTO, true);
        }

        public static void Alterar(EQUIPAMENTOPONTO oEQUIPAMENTOPONTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oEQUIPAMENTOPONTO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pEPCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto, DataContext MyDB)
        {
            EQUIPAMENTOPONTO oEQUIPAMENTOPONTO = default(EQUIPAMENTOPONTO);
            var res = from p in MyDB.EQUIPAMENTOPONTOs where p.EPCodigoPontoControle == pEPCodigoPontoControle && p.EPCodigoTipoEquipamento == pEPEquipamento && p.EPCodigoTipoPonto.Equals(pEPCodigoTipoPonto) select p;
            if (res.Count() > 0)
            {
                oEQUIPAMENTOPONTO = res.First();
                MyDB.EQUIPAMENTOPONTOs.DeleteOnSubmit(oEQUIPAMENTOPONTO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pEPCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            EQUIPAMENTOPONTO oEQUIPAMENTOPONTO = default(EQUIPAMENTOPONTO);
            var res = from p in db.EQUIPAMENTOPONTOs where p.EPCodigoPontoControle == pEPCodigoPontoControle && p.EPCodigoTipoEquipamento == pEPEquipamento && p.EPCodigoTipoPonto.Equals(pEPCodigoTipoPonto) select p;
            if (res.Count() > 0)
            {
                oEQUIPAMENTOPONTO = res.First();
                db.EQUIPAMENTOPONTOs.DeleteOnSubmit(oEQUIPAMENTOPONTO);
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

        public static void Excluir(EQUIPAMENTOPONTO oEQUIPAMENTOPONTO, DataContext MyDb)
        {
            MyDb.EQUIPAMENTOPONTOs.Attach(oEQUIPAMENTOPONTO);
            MyDb.EQUIPAMENTOPONTOs.DeleteOnSubmit(oEQUIPAMENTOPONTO);
        }
        public static void Excluir(EQUIPAMENTOPONTO oEQUIPAMENTOPONTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oEQUIPAMENTOPONTO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<EQUIPAMENTOPONTO> ListarTodos(DataContext MyDB)
        {
            List<EQUIPAMENTOPONTO> oLista = new List<EQUIPAMENTOPONTO>();
            var res = from p in MyDB.EQUIPAMENTOPONTOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<EQUIPAMENTOPONTO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static EQUIPAMENTOPONTO SelecionaPK(int pEPCodigoPontoControle, int pEPEquipamento, string pEPCodigoTipoPonto, DataContext MyDB = null)
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
            EQUIPAMENTOPONTO oEQUIPAMENTOPONTO = default(EQUIPAMENTOPONTO);
            var res = (from p in db.EQUIPAMENTOPONTOs where p.EPCodigoPontoControle == pEPCodigoPontoControle && p._EPCodigoTipoEquipamento == pEPEquipamento && p.EPCodigoTipoPonto.Equals(pEPCodigoTipoPonto) select p).ToList();
            if (res.Count() > 0)
            {
                oEQUIPAMENTOPONTO = res.First();
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
            return oEQUIPAMENTOPONTO;
        }

        #endregion

    }
}
