using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class TIPOEQUIPAMENTO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO, DataContext MyDb)
        {
            MyDb.TIPOEQUIPAMENTOs.InsertOnSubmit(oTIPOEQUIPAMENTO);
        }

        public static void Incluir(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oTIPOEQUIPAMENTO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO, DataContext MyDb)
        {
            MyDb.TIPOEQUIPAMENTOs.Attach(oTIPOEQUIPAMENTO, true);
        }

        public static void Alterar(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oTIPOEQUIPAMENTO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pTECodigo, DataContext MyDB)
        {
            TIPOEQUIPAMENTO oTIPOEQUIPAMENTO = null;
            dynamic res = from p in MyDB.TIPOEQUIPAMENTOs where p.TECodigo == pTECodigo select p;
            if (res.Count > 0)
            {
                oTIPOEQUIPAMENTO = res.First;
                MyDB.TIPOEQUIPAMENTOs.DeleteOnSubmit(oTIPOEQUIPAMENTO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pTECodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            TIPOEQUIPAMENTO oTIPOEQUIPAMENTO = null;
            dynamic res = from p in db.TIPOEQUIPAMENTOs where p.TECodigo == pTECodigo select p;
            if (res.Count > 0)
            {
                oTIPOEQUIPAMENTO = res.First;
                db.TIPOEQUIPAMENTOs.DeleteOnSubmit(oTIPOEQUIPAMENTO);
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

        public static void Excluir(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO, DataContext MyDb)
        {
            MyDb.TIPOEQUIPAMENTOs.Attach(oTIPOEQUIPAMENTO);
            MyDb.TIPOEQUIPAMENTOs.DeleteOnSubmit(oTIPOEQUIPAMENTO);
        }
        public static void Excluir(TIPOEQUIPAMENTO oTIPOEQUIPAMENTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oTIPOEQUIPAMENTO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<TIPOEQUIPAMENTO> ListarTodos(DataContext MyDB)
        {
            List<TIPOEQUIPAMENTO> oLista = new List<TIPOEQUIPAMENTO>();
            var res = from p in MyDB.TIPOEQUIPAMENTOs where p.TECodigo>1 select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<TIPOEQUIPAMENTO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static TIPOEQUIPAMENTO SelecionaPK(int pTECodigo, DataContext MyDB = null)
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
            TIPOEQUIPAMENTO oTIPOEQUIPAMENTO = null;
            var res = (from p in db.TIPOEQUIPAMENTOs where p.TECodigo == pTECodigo select p).ToList();
            if (res.Count > 0)
            {
                oTIPOEQUIPAMENTO = res.First();
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
            return oTIPOEQUIPAMENTO;
        }

        #endregion

        public static List<TIPOEQUIPAMENTO> ListaTipoEquipamento(int CodigoPonto)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var resEquipamentoUtilizado = from p in db.EQUIPAMENTOPONTOs where p.EPCodigoPontoControle == CodigoPonto select p.EPCodigoTipoEquipamento;
            var res = from p in db.TIPOEQUIPAMENTOs where p.TECodigo>1 && resEquipamentoUtilizado.Contains(p.TECodigo) == false select p;
            var retorno = res.ToList();
            db.Dispose();
            return retorno;
        }

        public static List<vw_EquipamentoPonto> ListaEquipamentoPonto(int CodigoPonto)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.vw_EquipamentoPontos where p.EPCodigoPontoControle == CodigoPonto select p;
            var Retorno = res.ToList();
            db.Dispose();
            return Retorno;
        }
    }
}
