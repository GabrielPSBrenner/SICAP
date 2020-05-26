using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACESSO.MODEL
{
    public partial class DIGITAL
    {
        #region "MÉTODOS INCLUIR, ALTERAR E EXCLUIR"

        public static void Incluir(DIGITAL oDIGITAL, DataContext MyDb)
        {
            MyDb.DIGITALs.InsertOnSubmit(oDIGITAL);
        }



        public static void Incluir(DIGITAL oDIGITAL)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Incluir(oDIGITAL, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Incluir(DIGITAL Digital1, HASHDIGITAL Hash1, DIGITAL Digital2, HASHDIGITAL Hash2, DIGITAL Digital3, HASHDIGITAL Hash3)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            //Digital1.HASHDIGITALs.Add(Hash1);
            //Digital2.HASHDIGITALs.Add(Hash2);
            //Digital3.HASHDIGITALs.Add(Hash3);
            db.DIGITALs.InsertOnSubmit(Digital1);
            db.DIGITALs.InsertOnSubmit(Digital2);
            db.DIGITALs.InsertOnSubmit(Digital3);
            db.SubmitChanges();
            Hash1.HaCodigoDigital = Digital1.DiCodigo;
            Hash2.HaCodigoDigital = Digital2.DiCodigo;
            Hash3.HaCodigoDigital = Digital3.DiCodigo;
            db.HASHDIGITALs.InsertOnSubmit(Hash1);
            db.HASHDIGITALs.InsertOnSubmit(Hash2);
            db.HASHDIGITALs.InsertOnSubmit(Hash3);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Alterar(DIGITAL oDIGITAL, DataContext MyDb)
        {
            MyDb.DIGITALs.Attach(oDIGITAL, true);
        }

        public static void Alterar(DIGITAL oDIGITAL)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Alterar(oDIGITAL, db);
            db.SubmitChanges();
            db.Dispose();
        }

        public static void Excluir(int pDiCodigo, DataContext MyDB)
        {
            DIGITAL oDIGITAL = default(DIGITAL);
            var res = from p in MyDB.DIGITALs where p.DiCodigo == pDiCodigo select p;
            if (res.Count() > 0)
            {
                oDIGITAL = res.First();
                MyDB.DIGITALs.DeleteOnSubmit(oDIGITAL);
            }
            else
            {
                throw new Exception("Não foi possível excluir o ítem, porque o mesmo não existe na base de dados.");
            }
        }


        public static void Excluir(int pDiCodigo)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            DIGITAL oDIGITAL = default(DIGITAL);
            var res = from p in db.DIGITALs where p.DiCodigo == pDiCodigo select p;
            if (res.Count() > 0)
            {
                oDIGITAL = res.First();
                db.DIGITALs.DeleteOnSubmit(oDIGITAL);
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

        public static void Excluir(DIGITAL oDIGITAL, DataContext MyDb)
        {
            MyDb.DIGITALs.Attach(oDIGITAL);
            MyDb.DIGITALs.DeleteOnSubmit(oDIGITAL);
        }
        public static void Excluir(DIGITAL oDIGITAL)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            Excluir(oDIGITAL, db);
            db.SubmitChanges();
            db.Dispose();
        }
        #endregion

        #region "MÉTODOS SELECIONA TODOS E SELECIONA PELA CHAVE"

        public static List<DIGITAL> ListarTodos(DataContext MyDB)
        {
            List<DIGITAL> oLista = new List<DIGITAL>();
            var res = from p in MyDB.DIGITALs select p;
            oLista = res.ToList();
            return oLista;
        }
        public static List<DIGITAL> ListarTodos()
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            dynamic oLista = ListarTodos(db);
            db.Dispose();
            return oLista;
        }


        public static List<DIGITAL> ListarPorUsuario(int CodigoUSuario)
        {
            DataContext db = new DataContext(MyGlobal.ConnectionString);
            var res = from p in db.DIGITALs join x in db.HASHDIGITALs on p.DiCodigo equals x.HaCodigoDigital where x.HaCodigoUsuario == CodigoUSuario select p ;
            var oLista = res.ToList(); 
            db.Dispose();
            return oLista;
        }
        


        public static DIGITAL SelecionaPK(int pDiCodigo, DataContext MyDB = null)
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
            DIGITAL oDIGITAL = default(DIGITAL);
            var res = (from p in db.DIGITALs where p.DiCodigo == pDiCodigo select p).ToList();
            if (res.Count() > 0)
            {
                oDIGITAL = res.First();
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
            return oDIGITAL;
        }

        #endregion

    }
}
