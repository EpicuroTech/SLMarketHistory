using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SplinterlandsMarketTrack.Data
{
    public static partial class dataLayer
    {
        public static string versao = "v.1.0";
        public static string pasta_dados;
        public static string base_dados;
        //--------------------------------------------------------------------
        public static void Iniciar()
        {
            //iniciar ao abrir aplicação
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DBSplinterLands\";

            //verifica se a pasta de dados existe, se nao existir, cria a pasta
            if (!Directory.Exists(pasta_dados)) Directory.CreateDirectory(pasta_dados);

            //verifica se a base de dados existe
            base_dados = pasta_dados + "SplinterReportsSQLCe.sdf";
            if (!File.Exists(base_dados)) CriarBaseDados();
        }
        //--------------------------------------------------------------------
        //Criaçao base de dados 
        public static void CriarBaseDados()
        {
            MessageBox.Show("Vai ser criada a base de dados!");
            //cria BD
            SqlCeEngine motor = new SqlCeEngine("Data Source = " + base_dados);
            motor.CreateDatabase();

            //abrir ligacao
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + base_dados);
            ligacao.Open();

            //criar tabelas da Base de dados
            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE historyreport(" +
                                    "id                             int not null primary key,      " +
                                    "dec                            nvarchar(20),                  " +
                                    "usd                            nvarchar(20),                  " +
                                    "date                           datetime                       )";
            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            //libertar memoria
            comando.Dispose();
            ligacao.Dispose();
        }
    }
}