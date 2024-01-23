﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Response
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; } 
        public string Token { get; set; }
    }
}
