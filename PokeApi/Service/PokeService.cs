using Newtonsoft.Json;
using PokeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Service
{
    public class PokeService
    {
        public HttpClient HttpClient;

        public PokeService()
        {
            HttpClient = new HttpClient();
        }

        public async Task<List<PokeInfo>> PokeList()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=40&offset=0";
            string json = await HttpClient.GetStringAsync(url);

            RosourceList resourceListPok = JsonConvert.DeserializeObject<RosourceList>(json);
            return resourceListPok.results;
        }

        public async Task<PokeCharact> PokeCharacteristics(string url)
        {
            string json = await HttpClient.GetStringAsync(url);
            PokeCharact pokeCharact = JsonConvert.DeserializeObject<PokeCharact>(json);
            return pokeCharact;
        }

        public async Task<EffectInfo> PokeAbilitiesInfo(string url)
        {
            string json = await HttpClient.GetStringAsync(url);
            EffectInfo effectEntries = JsonConvert.DeserializeObject<EffectInfo>(json);
            return effectEntries;
        }
    }
}
    