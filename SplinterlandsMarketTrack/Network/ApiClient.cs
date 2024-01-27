using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SplinterlandsMarketTrack.Data;

namespace SplinterlandsMarketTrack.Network
{
    internal class ApiClient
    {

        public List<LineOnRent> GetRentalHistory(string player, int skip, int offset)
        {
            var myHistory = new List<LineOnRent>();
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(
                    $@"https://api.splinterlands.com/market/rental_history?username={player}&limit=200&skip={skip}&offset={offset}"
                    );

                Task<HttpResponseMessage> httpResponse = client.GetAsync(endpoint);
                HttpResponseMessage response = httpResponse.Result;
                var json = response.Content.ReadAsStringAsync().Result;

                //ou!
                //var result = client.GetAsync(endpoint).Result;
                //var json = result.Content.ReadAsStringAsync().Result;


                myHistory = JsonConvert.DeserializeObject<List<LineOnRent>>(json);

            }
            return myHistory; 
        }


        // EXEMPLO DE POST
        public void PostExample()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                var newPost = new Post("Carlos Teste")
                {
                    Title = "Test",
                    Body = "hellow world",
                    UserId = 44,
                    PublishDate = DateTime.Now,
                };

                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;

            }

        }

        // TESTE A LER DE UM FICHEIRO JSON
        public void ReadJsonFromFile()
        {
            // Uma linha no renthistory teste
            var fileJsonText = File.ReadAllText(@"..\..\Data\lineOnHistoryTest.json");
            var myLineOnHistory = JsonConvert.DeserializeObject<LineOnRent>(fileJsonText);

            // todo o history
            var fileJsonTextArray = File.ReadAllText(@"..\..\Data\historyTest.json");
            var myHistory = JsonConvert.DeserializeObject<List<LineOnRent>>(fileJsonTextArray);
        }
    }
}
