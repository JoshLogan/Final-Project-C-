﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public interface ISelectSize
    {
        int NumberOf { get; }
        bool IsSmall { get; }
    }
}