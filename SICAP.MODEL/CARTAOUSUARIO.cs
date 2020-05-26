using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class CARTAOUSUARIO
    {

        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(CARTAOUSUARIO oCARTAOUSUARIO, DataContext MyDb)
        {
            MyDb.CARTAOUSUARIOs.InsertOnSubmit(oCARTAOUSUARIO);
        }

        public static void Incluir(CARTAOUSUARIO oCARTAOUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oCARTAOUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(CARTAOUSUARIO oCARTAOUSUARIO, DataContext MyDb)
        {
            MyDb.CARTAOUSUARIOs.Attach(oCARTAOUSUARIO, true);
        }

        public static void Alterar(CARTAOUSUARIO oCARTAOUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oCARTAOUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pCSCODIGO, DataContext MyDB)
        {
            CARTAOUSUARIO oCARTAOUSUARIO = default(CARTAOUSUARIO);
            var res = from p in MyDB.CARTAOUSUARIOs where p.CSCODIGO == pCSCODIGO select p;
            if (res.Count() > 0)
            {
                oCARTAOUSUARIO = res.First();
                MyDB.CARTAOUSUARIOs.DeleteOnSubmit(oCARTAOUSUARIO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pCSCODIGO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            CARTAOUSUARIO oCARTAOUSUARIO = default(CARTAOUSUARIO);
            var res = from p in db.CARTAOUSUARIOs where p.CSCODIGO == pCSCODIGO select p;
            if (res.Count() > 0)
            {
                oCARTAOUSUARIO = res.First();
                db.CARTAOUSUARIOs.DeleteOnSubmit(oCARTAOUSUARIO);
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

        public static void Excluir(CARTAOUSUARIO oCARTAOUSUARIO, DataContext MyDb)
        {
            MyDb.CARTAOUSUARIOs.Attach(oCARTAOUSUARIO);
            MyDb.CARTAOUSUARIOs.DeleteOnSubmit(oCARTAOUSUARIO);
        }
        public static void Excluir(CARTAOUSUARIO oCARTAOUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oCARTAOUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<CARTAOUSUARIO> ListarTodos(DataContext MyDB)
        {
            List<CARTAOUSUARIO> oLista = new List<CARTAOUSUARIO>();
            var res = from p in MyDB.CARTAOUSUARIOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<CARTAOUSUARIO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static CARTAOUSUARIO SelecionaPK(int pCSCODIGO, DataContext MyDB = null)
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
            CARTAOUSUARIO oCARTAOUSUARIO = default(CARTAOUSUARIO);
            var res = (from p in db.CARTAOUSUARIOs where p.CSCODIGO == pCSCODIGO select p).ToList();
            if (res.Count() > 0)
            {
                oCARTAOUSUARIO = res.First();
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
            return oCARTAOUSUARIO;
        }

        public static CARTAO SelecionaCartao(string NumeroCartao, out CARTAOUSUARIO oCartaoUsuario)
        {
            DataContext db = default(DataContext);
            oCartaoUsuario = null;
            CARTAO oCartao = null;
            db = new DataContext(MyGlobal.ConnectionString);
            var Res = from p in db.CARTAOs where p.CrNumeroCartao == NumeroCartao select p;            
            if (Res.Count() > 0)
            {
                oCartao = Res.First();

                var Res1 = from p in db.CARTAOUSUARIOs where p.CSCodigoCartao == oCartao.CrCodigo && p.CSDataEntrega <= DateTime.Now && p.CSDataExpiracao >= DateTime.Now && p.CSDevolvido == false select p;
                if (Res1.Count() != 0)
                {
                    oCartaoUsuario = Res1.First();
                }
                else
                {
                    oCartao = null;
                }               
            }
            db.Dispose();
            return oCartao;            
        }

        #endregion

    }
}
