using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class ROTA
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(ROTA oROTA, DataContext MyDb)
        {
            MyDb.ROTAs.InsertOnSubmit(oROTA);
        }

        public static int Incluir(ROTA oROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oROTA, db);
            db.SubmitChanges();
            db.Dispose();
            return oROTA.ROCodigo;
        }

        public static void Alterar(ROTA oROTA, DataContext MyDb)
        {
            MyDb.ROTAs.Attach(oROTA, true);
        }

        public static void Alterar(ROTA oROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pROCodigo, DataContext MyDB)
        {
            ROTA oROTA = default(ROTA);
            var res = from p in MyDB.ROTAs where p.ROCodigo == pROCodigo select p;
            if (res.Count() > 0)
            {
                oROTA = res.First();
                MyDB.ROTAs.DeleteOnSubmit(oROTA);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pROCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            ROTA oROTA = default(ROTA);
            var res = from p in db.ROTAs where p.ROCodigo == pROCodigo select p;
            if (res.Count() > 0)
            {
                oROTA = res.First();
                db.ROTAs.DeleteOnSubmit(oROTA);
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

        public static void Excluir(ROTA oROTA, DataContext MyDb)
        {
            MyDb.ROTAs.Attach(oROTA);
            MyDb.ROTAs.DeleteOnSubmit(oROTA);
        }
        public static void Excluir(ROTA oROTA)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oROTA, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<ROTA> ListarTodos(DataContext MyDB)
        {
            List<ROTA> oLista = new List<ROTA>();
            var res = from p in MyDB.ROTAs where p.ROBloqueada==false select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<ROTA> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static ROTA SelecionaPK(int pROCodigo, DataContext MyDB = null)
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
            ROTA oROTA = default(ROTA);
            var res = (from p in db.ROTAs where p.ROCodigo == pROCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oROTA = res.First();
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
            return oROTA;
        }

        public static List<vw_PontoRota> PontosDaRota(int PrCodigoRota)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var Res = from p in db.vw_PontoRotas where p.PRCodigoRota == PrCodigoRota orderby p.PROrdem select p;
            var Lista = Res.ToList();
            db.Dispose();
            return Lista;
        }

        public static  void OrdemMaisUm(int PRCodigoRota, int PRCodigoPontoControle, char PRTipoPontoControle)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var Res = from p in db.PONTOROTAs where p.PRCodigoRota == PRCodigoRota && p.PRCodigoPontoControle == PRCodigoPontoControle && p.PRTipoPontoControle.Equals(PRTipoPontoControle) select p;
            if (Res.Count() > 0)
            {
                PONTOROTA oPontoOrigem = Res.First();

                var ResPD = from p in db.PONTOROTAs where p.PRCodigoRota == PRCodigoRota && p.PROrdem == oPontoOrigem.PROrdem + 1 select p;
                if (ResPD.Count() > 0)
                {
                    PONTOROTA oPontoDestino = ResPD.First();

                    oPontoOrigem.PROrdem = oPontoOrigem.PROrdem + 1;
                    oPontoDestino.PROrdem = oPontoDestino.PROrdem - 1;
                    db.SubmitChanges();
                }
            }
            db.Dispose();
        }

        public static void OrdemMenosUm(int PRCodigoRota, int PRCodigoPontoControle, char PRTipoPontoControle)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var Res = from p in db.PONTOROTAs where p.PRCodigoRota == PRCodigoRota && p.PRCodigoPontoControle == PRCodigoPontoControle && p.PRTipoPontoControle.Equals(PRTipoPontoControle) select p;
            if (Res.Count() > 0)
            {
                PONTOROTA oPontoOrigem = Res.First();

                var ResPD = from p in db.PONTOROTAs where p.PRCodigoRota == PRCodigoRota && p.PROrdem == oPontoOrigem.PROrdem -1 select p;
                if (ResPD.Count() > 0)
                {
                    PONTOROTA oPontoDestino = ResPD.First();
                    oPontoOrigem.PROrdem = oPontoOrigem.PROrdem -1;
                    oPontoDestino.PROrdem = oPontoDestino.PROrdem + 1;
                    db.SubmitChanges();
                }
            }
            db.Dispose();
        }
        #endregion

    }
}
