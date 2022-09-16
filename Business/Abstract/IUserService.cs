﻿using Core.Entites.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaim(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
