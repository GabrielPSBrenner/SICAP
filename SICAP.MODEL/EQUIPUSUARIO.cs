using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class EQUIPUSUARIO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(EQUIPUSUARIO oEQUIPUSUARIO, DataContext MyDb)
        {
            MyDb.EQUIPUSUARIOs.InsertOnSubmit(oEQUIPUSUARIO);
        }

        public static void Incluir(EQUIPUSUARIO oEQUIPUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oEQUIPUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(EQUIPUSUARIO oEQUIPUSUARIO, DataContext MyDb)
        {
            MyDb.EQUIPUSUARIOs.Attach(oEQUIPUSUARIO, true);
        }

        public static void Alterar(EQUIPUSUARIO oEQUIPUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oEQUIPUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pEUSCodigo, DataContext MyDB)
        {
            EQUIPUSUARIO oEQUIPUSUARIO = default(EQUIPUSUARIO);
            var res = from p in MyDB.EQUIPUSUARIOs where p.EUSCodigo == pEUSCodigo select p;
            if (res.Count() > 0)
            {
                oEQUIPUSUARIO = res.First();
                MyDB.EQUIPUSUARIOs.DeleteOnSubmit(oEQUIPUSUARIO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pEUSCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            EQUIPUSUARIO oEQUIPUSUARIO = default(EQUIPUSUARIO);
            var res = from p in db.EQUIPUSUARIOs where p.EUSCodigo == pEUSCodigo select p;
            if (res.Count() > 0)
            {
                oEQUIPUSUARIO = res.First();
                db.EQUIPUSUARIOs.DeleteOnSubmit(oEQUIPUSUARIO);
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

        public static void Excluir(EQUIPUSUARIO oEQUIPUSUARIO, DataContext MyDb)
        {
            MyDb.EQUIPUSUARIOs.Attach(oEQUIPUSUARIO);
            MyDb.EQUIPUSUARIOs.DeleteOnSubmit(oEQUIPUSUARIO);
        }
        public static void Excluir(EQUIPUSUARIO oEQUIPUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oEQUIPUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<EQUIPUSUARIO> ListarTodos(DataContext MyDB)
        {
            List<EQUIPUSUARIO> oLista = new List<EQUIPUSUARIO>();
            var res = from p in MyDB.EQUIPUSUARIOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<EQUIPUSUARIO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static EQUIPUSUARIO SelecionaPK(int pEUSCodigo, DataContext MyDB = null)
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
            EQUIPUSUARIO oEQUIPUSUARIO = default(EQUIPUSUARIO);
            var res = (from p in db.EQUIPUSUARIOs where p.EUSCodigo == pEUSCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oEQUIPUSUARIO = res.First();
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
            return oEQUIPUSUARIO;
        }

        public static List<vw_EquipamentoUsuario> ListaEquipamentoUsuario(int CodigoUsuario)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.vw_EquipamentoUsuarios where p.EUSCodigoUsuario == CodigoUsuario select p;
            var Retorno = res.ToList();
            db.Dispose();
            return Retorno;
        }


        public static vw_EquipamentoUsuario ListaEquipamentoUsuario(int CodigoUsuario, string TAG)
        {
           DataContext db = new DataContext(MyGlobal.ConnectionString);
           DateTime DataInicial = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
           DateTime DataFinal = DataInicial.AddDays(1);

           var res = from p in db.vw_EquipamentoUsuarios where p.EUSCodigoUsuario == CodigoUsuario && p.EqTAGRFID == TAG select p;
           var Retorno = res.ToList();
           db.Dispose();
           if (Retorno.Count() == 0)
              return null;
           else
              return Retorno.First();
        }
       

        #endregion

    }
}
