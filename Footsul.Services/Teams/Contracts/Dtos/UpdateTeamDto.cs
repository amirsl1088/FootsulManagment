﻿using Footsul.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Teams.Contracts.Dtos
{
    public class UpdateTeamDto
    {
        public string Name { get; set; }
        public Color FirstKit { get; set; }
        public Color SecondKit { get; set; }
    }
}
