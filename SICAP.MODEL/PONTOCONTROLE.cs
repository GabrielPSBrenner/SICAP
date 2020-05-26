using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class PONTOCONTROLE
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(PONTOCONTROLE oPONTOCONTROLE, DataContext MyDb)
        {
            MyDb.PONTOCONTROLEs.InsertOnSubmit(oPONTOCONTROLE);
        }

        public static void Incluir(PONTOCONTROLE oPONTOCONTROLE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oPONTOCONTROLE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(PONTOCONTROLE oPONTOCONTROLE, DataContext MyDb)
        {
            MyDb.PONTOCONTROLEs.Attach(oPONTOCONTROLE, true);
        }

        public static void Alterar(PONTOCONTROLE oPONTOCONTROLE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oPONTOCONTROLE, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pPoCodigo, string pPoTipo, DataContext MyDB)
        {
            PONTOCONTROLE oPONTOCONTROLE = default(PONTOCONTROLE);
            var res = from p in MyDB.PONTOCONTROLEs where p.PoCodigo == pPoCodigo && p.PoTipo.Equals(pPoTipo) select p;
            if (res.Count() > 0)
            {
                oPONTOCONTROLE = res.First();
                MyDB.PONTOCONTROLEs.DeleteOnSubmit(oPONTOCONTROLE);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pPoCodigo, string pPoTipo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            PONTOCONTROLE oPONTOCONTROLE = default(PONTOCONTROLE);
            var res = from p in db.PONTOCONTROLEs where p.PoCodigo == pPoCodigo && p.PoTipo.Equals(pPoTipo) select p;
            if (res.Count() > 0)
            {
                oPONTOCONTROLE = res.First();
                db.PONTOCONTROLEs.DeleteOnSubmit(oPONTOCONTROLE);
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

        public static void Excluir(PONTOCONTROLE oPONTOCONTROLE, DataContext MyDb)
        {
            MyDb.PONTOCONTROLEs.Attach(oPONTOCONTROLE);
            MyDb.PONTOCONTROLEs.DeleteOnSubmit(oPONTOCONTROLE);
        }
        public static void Excluir(PONTOCONTROLE oPONTOCONTROLE)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oPONTOCONTROLE, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<PONTOCONTROLE> ListarTodos(DataContext MyDB)
        {
            List<PONTOCONTROLE> oLista = new List<PONTOCONTROLE>();
            var res = from p in MyDB.PONTOCONTROLEs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<PONTOCONTROLE> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }

        public static List<PONTOCONTROLE> ListarPorTipo(char Tipo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = (from p in db.PONTOCONTROLEs where p.PoTipo.Equals(Tipo) orderby p.PoNome select p).ToList();
            db.Dispose();
            return oLista;
        }


        public static PONTOCONTROLE SelecionaPK(int pPoCodigo, string pPoTipo, DataContext MyDB = null)
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
            PONTOCONTROLE oPONTOCONTROLE = default(PONTOCONTROLE);
            var res = (from p in db.PONTOCONTROLEs where p.PoCodigo == pPoCodigo && p.PoTipo.Equals(pPoTipo) select p).ToList();
            if (res.Count() > 0)
            {
                oPONTOCONTROLE = res.First();
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
            return oPONTOCONTROLE;
        }

        #endregion

        public static List<PONTOCONTROLE> ListaPontoControleEPI()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.PONTOCONTROLEs where p.PoTipo == char.Parse("E") select p;
            var Retorno = res.ToList();
            db.Dispose();
            return Retorno;
        }

    }
}
