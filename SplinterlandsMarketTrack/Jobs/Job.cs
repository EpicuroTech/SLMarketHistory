using SplinterlandsMarketTrack.Data;
using SplinterlandsMarketTrack.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplinterlandsMarketTrack.Jobs
{

    public static partial class Job
    {
        public static void routine(string player) 
        {
            List<LineOnRent> myHistory = new List<LineOnRent>();

            ApiClient apiClient = new ApiClient();
            myHistory = UtilsHelpers.GetAllRentHistory(player);

            //iniciar ao abrir aplicação
            var pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DBSplinterLands\";

            //verifica se a pasta de dados existe, se nao existir, cria a pasta
            if (!Directory.Exists(pasta_dados)) Directory.CreateDirectory(pasta_dados);

            string data = DateTime.Now.ToString("yyyy-MM-dd");
            //verifica se a base de dados existe
            var file = pasta_dados + data +"_SplinterReportsCSV.csv";

            var result = UtilsHelpers.CreateCsv(myHistory, file);

            Console.WriteLine($"New file report was created!{result}");
        }      
    }
}
