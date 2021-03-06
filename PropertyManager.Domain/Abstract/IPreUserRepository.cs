﻿using PropertyManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManager.Domain.Abstract
{
    public interface IPreUserRepository
    {
        IEnumerable<PreUser> PreUsers { get; }
        PreUserResponseCode Add(PreUser user);
    }
}
