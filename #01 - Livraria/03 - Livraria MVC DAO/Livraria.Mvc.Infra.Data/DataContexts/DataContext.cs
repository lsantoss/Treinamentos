﻿using Microsoft.Extensions.Options;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Livraria.Mvc.Infra.Data.DataContexts
{
    public class DataContext : IDisposable
    {
        public SqlConnection SQLServerConexao { get; set; }

        public DataContext(IOptions<SettingsInfraData> options)
        {
            try
            {
                SQLServerConexao = new SqlConnection(options.Value.ConnectionString);
                SQLServerConexao.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            try
            {
                if (SQLServerConexao.State != ConnectionState.Closed)
                    SQLServerConexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}