using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class PARAMETRO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(PARAMETRO oPARAMETRO, DataContext MyDb)
        {
            MyDb.PARAMETROs.InsertOnSubmit(oPARAMETRO);
        }

        public static void Incluir(PARAMETRO oPARAMETRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oPARAMETRO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(PARAMETRO oPARAMETRO, DataContext MyDb)
        {
            MyDb.PARAMETROs.Attach(oPARAMETRO, true);
        }

        public static void Alterar(PARAMETRO oPARAMETRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oPARAMETRO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pPACodigo, DataContext MyDB)
        {
            PARAMETRO oPARAMETRO = default(PARAMETRO);
            var res = from p in MyDB.PARAMETROs where p.PACodigo == pPACodigo select p;
            if (res.Count() > 0)
            {
                oPARAMETRO = res.First();
                MyDB.PARAMETROs.DeleteOnSubmit(oPARAMETRO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pPACodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            PARAMETRO oPARAMETRO = default(PARAMETRO);
            var res = from p in db.PARAMETROs where p.PACodigo == pPACodigo select p;
            if (res.Count() > 0)
            {
                oPARAMETRO = res.First();
                db.PARAMETROs.DeleteOnSubmit(oPARAMETRO);
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

        public static void Excluir(PARAMETRO oPARAMETRO, DataContext MyDb)
        {
            MyDb.PARAMETROs.Attach(oPARAMETRO);
            MyDb.PARAMETROs.DeleteOnSubmit(oPARAMETRO);
        }
        public static void Excluir(PARAMETRO oPARAMETRO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oPARAMETRO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<PARAMETRO> ListarTodos(DataContext MyDB)
        {
            List<PARAMETRO> oLista = new List<PARAMETRO>();
            var res = from p in MyDB.PARAMETROs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<PARAMETRO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static PARAMETRO SelecionaPK(int pPACodigo, DataContext MyDB = null)
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
            PARAMETRO oPARAMETRO = default(PARAMETRO);
            var res = (from p in db.PARAMETROs where p.PACodigo == pPACodigo select p).ToList();
            if (res.Count() > 0)
            {
                oPARAMETRO = res.First();
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
            return oPARAMETRO;
        }

        #endregion

    }
}
