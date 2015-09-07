﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ConexionDal
    {
        #region Atributos
        public static string connectionString = ConfigurationManager.ConnectionStrings["CadenaDeConexion"].ConnectionString;
        #endregion
        #region Metodos
        public static void test()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (SqlException sqlExceptionX)
                {
                    throw sqlExceptionX;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        #endregion
    }
}