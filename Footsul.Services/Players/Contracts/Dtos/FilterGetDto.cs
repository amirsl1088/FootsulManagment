﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsul.Services.Players.Contracts.Dtos
{
    public class FilterGetDto
    {
        public string? FirstName { get; set; }
        
        public DateTime? BirthDay { get; set; }
    }
}
