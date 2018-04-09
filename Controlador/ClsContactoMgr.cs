using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    class ClsContactoMgr
    {
        ClsDatos ncGeneral = null;
        ClsContacto objContacto = null;
        Modelo.DataTable tblDatos = null;

        public ClsContactoMgr(ClsContacto objContacto)
        {
            this.objContacto = objContacto;
        }
        public Modelo.DataTable Listar() {
            tblDatos = new DataTable;
            try
            {
                ncGeneral = new clsDatos;
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = System.Data.SqlDbType.Int;
                parParameter[0].SqlValue = objContacto.opc;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPContacto");

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDatos;
        }
        public void Guardar()
        {
            try
            {
                ncGeneral = new clsDatos;
                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = System.Data.SqlDbType.Int;
                parParameter[0].SqlValue = objContacto.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@ID";
                parParameter[1].SqlDbType = System.Data.SqlDbType.Int;
                parParameter[1].SqlValue = objContacto.opc;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Nombre_Contacto";
                parParameter[2].SqlDbType = System.Data.SqlDbType.VarChar;
                parParameter[2].SqlValue = objContacto.opc;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Telefono_Contacto";
                parParameter[3].SqlDbType = System.Data.SqlDbType.VarChar;
                parParameter[3].SqlValue = objContacto.opc;

                

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPContacto");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void actualizar()
        {
            try
            {
                ncGeneral = new clsDatos;
                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = System.Data.SqlDbType.Int;
                parParameter[0].SqlValue = objContacto.opc;

                /*parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@ID";
                parParameter[1].SqlDbType = System.Data.SqlDbType.Int;
                parParameter[1].SqlValue = objContacto.opc;*/

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Nombre_Contacto";
                parParameter[2].SqlDbType = System.Data.SqlDbType.VarChar;
                parParameter[2].SqlValue = objContacto.opc;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Telefono_Contacto";
                parParameter[3].SqlDbType = System.Data.SqlDbType.VarChar;
                parParameter[3].SqlValue = objContacto.opc;



                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPContacto");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
