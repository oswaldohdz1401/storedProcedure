using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    class ClsDatos
    {
        public ClsDatos()
        {
            string strCadenaConexion = "Data Source= A-006-4291\\SQLEXPRESS; Initial Catalog = DBContacto; Integrated Security = True; ";
        }
        public void EjecutarSP()
        {
            try
            {
                cnnConnexion = new SqlConnection(strCadenaConexion);
                cmdComando = new SqlCommand();
                cmdComando.Connection = cnnConexion;
                cnnConexion.Open();
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdCoomando.ComandText = parSPName;
                cmdComando.Parameters.AddRange(parParametros);
                cmdComando.ExecuteNonQuey();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConecion.Dispose();
                cmdComando.Dispose();
            }

        }
    }
}
