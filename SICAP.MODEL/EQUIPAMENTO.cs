using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class EQUIPAMENTO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(EQUIPAMENTO oEQUIPAMENTO, DataContext MyDb)
        {
            MyDb.EQUIPAMENTOs.InsertOnSubmit(oEQUIPAMENTO);
        }

        public static void Incluir(EQUIPAMENTO oEQUIPAMENTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oEQUIPAMENTO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(EQUIPAMENTO oEQUIPAMENTO, DataContext MyDb)
        {
            MyDb.EQUIPAMENTOs.Attach(oEQUIPAMENTO, true);
        }

        public static void Alterar(EQUIPAMENTO oEQUIPAMENTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oEQUIPAMENTO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pEqCodigo, DataContext MyDB)
        {
            EQUIPAMENTO oEQUIPAMENTO = default(EQUIPAMENTO);
            var res = from p in MyDB.EQUIPAMENTOs where p.EqCodigo == pEqCodigo select p;
            if (res.Count() > 0)
            {
                oEQUIPAMENTO = res.First();
                MyDB.EQUIPAMENTOs.DeleteOnSubmit(oEQUIPAMENTO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pEqCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            EQUIPAMENTO oEQUIPAMENTO = default(EQUIPAMENTO);
            var res = from p in db.EQUIPAMENTOs where p.EqCodigo == pEqCodigo select p;
            if (res.Count() > 0)
            {
                oEQUIPAMENTO = res.First();
                db.EQUIPAMENTOs.DeleteOnSubmit(oEQUIPAMENTO);
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

        public static void Excluir(EQUIPAMENTO oEQUIPAMENTO, DataContext MyDb)
        {
            MyDb.EQUIPAMENTOs.Attach(oEQUIPAMENTO);
            MyDb.EQUIPAMENTOs.DeleteOnSubmit(oEQUIPAMENTO);
        }
        public static void Excluir(EQUIPAMENTO oEQUIPAMENTO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oEQUIPAMENTO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<EQUIPAMENTO> ListarTodos(DataContext MyDB)
        {
            List<EQUIPAMENTO> oLista = new List<EQUIPAMENTO>();
            var res = from p in MyDB.EQUIPAMENTOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<EQUIPAMENTO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static EQUIPAMENTO SelecionaPK(int pEqCodigo, DataContext MyDB = null)
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
            EQUIPAMENTO oEQUIPAMENTO = default(EQUIPAMENTO);
            var res = (from p in db.EQUIPAMENTOs where p.EqCodigo == pEqCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oEQUIPAMENTO = res.First();
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
            return oEQUIPAMENTO;
        }

        public static List<EQUIPAMENTO> ListarEquipamentosTipo(int Tipo)
        {
            DataContext oDb = new DataContext(MyGlobal.ConnectionString);
            List<EQUIPAMENTO> oLista = new List<EQUIPAMENTO>();
            var res = from p in oDb.EQUIPAMENTOs where p.EqTipoEquipamento == Tipo select p;
            oLista = res.ToList();
            oDb.Dispose();
            return oLista;
        }

        #endregion


        public static List<EQUIPAMENTO> ListarTodosEquipamentosNaoDistribuidos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            List<EQUIPAMENTO> oLista = new List<EQUIPAMENTO>();

            var EquipamentosDistribuidos = from p in db.EQUIPUSUARIOs where p.EUSDataInicio <= DateTime.Now && p.EUSDataFim >= DateTime.Now  select p.EUSCodigoEquipamento;
            var Listagem = EquipamentosDistribuidos.ToList();
            if (Listagem.Count() > 0)
            {
                var res = from p in db.EQUIPAMENTOs where Listagem.Contains(p.EqCodigo) == false && (p.EqTAGRFID != null && p.EqTAGRFID != "") select p;
                oLista = res.ToList();
            }
            else
            {
                var res = from p in db.EQUIPAMENTOs where p.EqTAGRFID != null && p.EqTAGRFID != ""  select p;
                oLista = res.ToList();
            }
            
            return oLista;
        }
    }
}
