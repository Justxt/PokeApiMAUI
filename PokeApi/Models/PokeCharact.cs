using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class PokeCharact
    {
        public List<Abilities> abilities { get; set; }
        public sprites sprites { get; set; }
    }
}
