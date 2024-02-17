using Footsul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Teams.Contracts.Dtos
{
    public class FilterTeamDto
    {
        public string? Name { get; set; }
        public Color? FirstKit { get; set; }
    }
}
