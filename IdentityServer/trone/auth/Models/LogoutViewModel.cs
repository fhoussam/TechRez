﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace auth.Models
{
    public class LogoutViewModel : LogoutInputModel
    {
        public bool ShowLogoutPrompt { get; set; } = true;
    }
}
