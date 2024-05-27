using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class RosourceList
    {
        public int count {  get; set; }
        public string next {  get; set; }
        public string previus { get; set; }
        public List<PokeInfo>? results { get; set; }
    }
}
