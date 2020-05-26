using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class ROTAUSUARIO
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(ROTAUSUARIO oROTAUSUARIO, DataContext MyDb)
        {
            MyDb.ROTAUSUARIOs.InsertOnSubmit(oROTAUSUARIO);
        }

        public static void Incluir(ROTAUSUARIO oROTAUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oROTAUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(ROTAUSUARIO oROTAUSUARIO, DataContext MyDb)
        {
            MyDb.ROTAUSUARIOs.Attach(oROTAUSUARIO, true);
        }

        public static void Alterar(ROTAUSUARIO oROTAUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oROTAUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pRUCodigo, DataContext MyDB)
        {
            ROTAUSUARIO oROTAUSUARIO = default(ROTAUSUARIO);
            var res = from p in MyDB.ROTAUSUARIOs where p.RUCodigo == pRUCodigo select p;
            if (res.Count() > 0)
            {
                oROTAUSUARIO = res.First();
                MyDB.ROTAUSUARIOs.DeleteOnSubmit(oROTAUSUARIO);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pRUCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            ROTAUSUARIO oROTAUSUARIO = default(ROTAUSUARIO);
            var res = from p in db.ROTAUSUARIOs where p.RUCodigo == pRUCodigo select p;
            if (res.Count() > 0)
            {
                oROTAUSUARIO = res.First();
                db.ROTAUSUARIOs.DeleteOnSubmit(oROTAUSUARIO);
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

        public static void Excluir(ROTAUSUARIO oROTAUSUARIO, DataContext MyDb)
        {
            MyDb.ROTAUSUARIOs.Attach(oROTAUSUARIO);
            MyDb.ROTAUSUARIOs.DeleteOnSubmit(oROTAUSUARIO);
        }
        public static void Excluir(ROTAUSUARIO oROTAUSUARIO)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oROTAUSUARIO, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<ROTAUSUARIO> ListarTodos(DataContext MyDB)
        {
            List<ROTAUSUARIO> oLista = new List<ROTAUSUARIO>();
            var res = from p in MyDB.ROTAUSUARIOs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<ROTAUSUARIO> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }

        public static bool PossuiPermissaoPonto(int CodigoUsuario, int CodigoPonto)
        {
            bool retorno = false;
            DataContext db = new DataContext(MyGlobal.ConnectionString);

            //VERIFICA QUAL TIPO DE USUÁRIO É
            //SE FOR CONTRATADO, TEM QUE POSSUIR UM CONTRATO VÁLIDO
            //SE FOR VISITANTE, TEM QUE POSSUIR UMA VISITA VÁLIDA

            var resUsuario = from p in db.USUARIOs where p.USCODIGO == CodigoUsuario select p;
            if (resUsuario.Count() == 0)
            {
                db.Dispose();
                throw new Exception("Usuario não encontrado na base de dados.");
            }
            var Usuario = resUsuario.First();


            if (Usuario.USCODIGOTERCEIRO != null)
            {
                //Contratado
                var Contrato = CONTRATOTERCEIRO.SelecionaContratoValido((int)Usuario.USCODIGOTERCEIRO, db);
                if (Contrato == null)
                {
                    db.Dispose();
                    throw new Exception("O contratado não possui um contrato válido cadastrado.");
                }
            }
            else if (Usuario.USCODIGOVISITANTE != null)
            {
                //Visitante
                var Visita = VISITA.SelecionaVisitaValida((int)Usuario.USCODIGOVISITANTE, db);
                if (Visita == null)
                {
                    db.Dispose();
                    throw new Exception("O visitante não possui uma visita válida cadastrada.");
                }
            }


            //Verifica se o usuário tem permissão de acessar o ponto.
            var res = from p in db.PONTOROTAs join x in db.ROTAUSUARIOs on p.PRCodigoRota equals x.RUCodigoRota where p.PRCodigoPontoControle == CodigoPonto && x.RUCodigoUsuario == CodigoUsuario && x.RUDataInicioPermissao <= DateTime.Now && x.RUDataExpiracao>=DateTime.Now select p;
            if (res.Count() > 0)
            {
                retorno = true;
            }
            db.Dispose();
            return retorno;
        }

        public static List<ROTAUSUARIO> RotasUsuario(int CodigoUsuario)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.ROTAUSUARIOs where p.RUCodigoUsuario == CodigoUsuario && p.RUDataInicioPermissao <= DateTime.Now && p.RUDataExpiracao > DateTime.Now  select p;
            var Retorno = res.ToList();
            db.Dispose();
            return Retorno;
        }

        public static ROTAUSUARIO SelecionaPK(int pRUCodigo, DataContext MyDB = null)
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
            ROTAUSUARIO oROTAUSUARIO = default(ROTAUSUARIO);
            var res = (from p in db.ROTAUSUARIOs where p.RUCodigo == pRUCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oROTAUSUARIO = res.First();
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
            return oROTAUSUARIO;
        }

        #endregion

    }
}
