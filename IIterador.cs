﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Metodologias
{
    public interface IIterador
    {
        void primero();
        void segundo();
        bool fin();
        IComparable actual();
    }
}
