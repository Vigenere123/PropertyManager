﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManager.Domain
{
    public enum ResponseCode
    {
        Success = 0,
        EmailAlreadyInUse = 1,
        PhoneNumberAlreadyInUse = 2
    }
}
