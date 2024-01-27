using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SplinterlandsMarketTrack.Network
{
    public class Post
    {
        public string Title {  get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        // se pretender ignorar alguma propiedade.
        [JsonIgnore]
        public DateTime PublishDate {  get; set; }

        // se pretendemos que propriedade privada seja incluída.
        [JsonRequired]
        private readonly string _userName;
        public Post(string userName) {  _userName = userName; }
    }
}
