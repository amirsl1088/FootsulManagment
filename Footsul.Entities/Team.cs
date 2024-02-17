using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color FirstKit { get; set; }
        public Color SecondKit { get; set; }
    }
}
