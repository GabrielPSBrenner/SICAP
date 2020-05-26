using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class CARTAO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(CARTAO oCARTAO, DataContext MyDb)
        {
            MyDb.CARTAOs.InsertOnSubmit(oCARTAO);
        }

        public static void Incluir(CARTAO oCARTAO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oCARTAO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(CARTAO oCARTAO, DataContext MyDb)
        {
            MyDb.CARTAOs.Attach(oCARTAO, true);
        }

        public static void Alterar(CARTAO oCARTAO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oCARTAO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pCrCodigo, DataContext MyDB)
        {
            CARTAO oCARTAO = default(CARTAO);
            var res = from p in MyDB.CARTAOs where p.CrCodigo == pCrCodigo select p;
            if (res.Count() > 0)
            {
                oCARTAO = res.First();
                MyDB.CARTAOs.DeleteOnSubmit(oCARTAO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pCrCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            CARTAO oCARTAO = default(CARTAO);
            var res = from p in db.CARTAOs where p.CrCodigo == pCrCodigo select p;
            if (res.Count() > 0)
            {
                oCARTAO = res.First();
                db.CARTAOs.DeleteOnSubmit(oCARTAO);
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

        public static void Excluir(CARTAO oCARTAO, DataContext MyDb)
        {
            MyDb.CARTAOs.Attach(oCARTAO);
            MyDb.CARTAOs.DeleteOnSubmit(oCARTAO);
        }
        public static void Excluir(CARTAO oCARTAO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oCARTAO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<CARTAO> ListarCartoesTipo(char Tipo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var resCartao = from p in db.CARTAOUSUARIOs where p.CSDataEntrega == null || p.CSDataEntrega < DateTime.Now select p.CSCodigoCartao;
            var res = from p in db.CARTAOs where p.CrTipo.Equals(Tipo) && resCartao.Contains(p.CrCodigo) == false select p;
            var Lista = res.ToList();
            db.Dispose();
            return Lista;
        }

        public static List<CARTAO> ListarCartoesTipo(char Tipo, int Usuario)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var resCartao = from p in db.CARTAOUSUARIOs where p.CSDevolvido ==false && p.CSCodigoUsuario != Usuario select p.CSCodigoCartao;
            var ListaComparacao = resCartao.ToList();
            var res = from p in db.CARTAOs where p.CrTipo.Equals(Tipo) && ListaComparacao.Contains(p.CrCodigo) == false select p;
            var Lista = res.ToList();
            db.Dispose();
            return Lista;
        }

        public static List<CARTAO> CartaoNumero(string numero)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.CARTAOs where p.CrNumeroCartao == numero select p;
            var Lista = res.ToList();
            db.Dispose();
            return Lista;
        }

        public static List<CARTAO> ListarTodos(DataContext MyDB)
        {
            List<CARTAO> oLista = new List<CARTAO>();
            var res = from p in MyDB.CARTAOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<CARTAO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static CARTAO SelecionaPK(int pCrCodigo, DataContext MyDB = null)
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
            CARTAO oCARTAO = default(CARTAO);
            var res = (from p in db.CARTAOs where p.CrCodigo == pCrCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oCARTAO = res.First();
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
            return oCARTAO;
        }

        #endregion

    }
}
