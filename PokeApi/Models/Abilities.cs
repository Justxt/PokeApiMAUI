using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class Abilities
    {
        public Ability ability { get; set; }
        public Boolean is_hidden { get; set; }
        public int slot { get; set; }
    }
}
