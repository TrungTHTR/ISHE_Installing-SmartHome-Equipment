﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public interface UserService
    {
         Task<bool> RegisterAccount(Users user);
    }
}
