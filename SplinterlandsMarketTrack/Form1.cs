using Newtonsoft.Json;
using SplinterlandsMarketTrack.Data;
using SplinterlandsMarketTrack.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplinterlandsMarketTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            float version = 1.0F;
            InitializeComponent();
            labelVersion.Text = $"Version: {version:0.00}\n @CarlosDias";
        }

        List<LineOnRent> myHistory = new List<LineOnRent>();
        decimal DecToUsd  = 0.00095M;
        decimal totalDecValue=0;
        decimal totalUsdValue=0;
        int totalreports;



        private void buttonStart_Click(object sender, EventArgs e)
        {
            string player = textBoxUsername.Text.Trim().ToLower();
            if (player == "")
            {
                MessageBox.Show("Insert the player Username!", "No Username");
                return;
            }
            ApiClient apiClient = new ApiClient();
            //myHistory = apiClient.GetRentalHistory("epicurotech", 200, 400);
            myHistory = UtilsHelpers.GetAllRentHistory(player);

            //teste para contar linhas devolvidas pelas chamadas há API.
            labelTest.Text = myHistory.Count().ToString();
            totalDecValue = UtilsHelpers.MonthTotalRent(myHistory);
            totalUsdValue = totalDecValue * DecToUsd;
            labelRentMonthDEC.Text = $"{totalDecValue} DEC";
            labelRentMonthUSD.Text = $"{totalUsdValue:0.00} USD";
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            ApiClient apiClient = new ApiClient();
            apiClient.PostExample();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            ApiClient apiClient = new ApiClient();
            apiClient.ReadJsonFromFile();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void buttonPeek_Click(object sender, EventArgs e)
        {
            if (myHistory.Count() == 0)
            {
                MessageBox.Show("You should first click in Request Data!", "No data");
            }
            else
            {
                string htmlContent = UtilsHelpers.GenerateHtmlTable(myHistory);
                File.WriteAllText(@"..\..\Data\HistoryInHTML.html", htmlContent);


                Form2 form2 = new Form2();
                form2.ShowDialog();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonToSql_Click(object sender, EventArgs e)
        {
            if (myHistory.Count() == 0)
            {
                MessageBox.Show("You should first click in Request Data!", "No data");
            }
            else
            {
                SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + dataLayer.base_dados);
                ligacao.Open();
                DataTable dados = new DataTable();

                //buscar o total de registos
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT COUNT(id) from historyreport", ligacao);
                adaptador.Fill(dados);

                //verifica se o valor é null, ainda nao tem dados a bd
                if (DBNull.Value.Equals(dados.Rows[0][0]))//é nulo!
                {
                    totalreports = 0;
                }
                else totalreports = Convert.ToInt16(dados.Rows[0][0]);//nao é nulo
  

                //gravar o novo contacto na bd
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;
                //parametros
                comando.Parameters.AddWithValue("@id", totalreports+1);
                comando.Parameters.AddWithValue("@dec", totalDecValue.ToString());
                comando.Parameters.AddWithValue("@usd", totalUsdValue.ToString());
                comando.Parameters.AddWithValue("@date", DateTime.Now);

                //texto da query
                comando.CommandText = "INSERT INTO historyreport VALUES(" +
                "@id," +
                "@dec," +
                "@usd," +
                "@date)";


                comando.ExecuteNonQuery();
                comando.Dispose();
                ligacao.Dispose();

                MessageBox.Show("Report registado!");
            }
        }
    }
}
