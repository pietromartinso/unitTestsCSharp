﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Project
{
    public static class Helper
    {
        public static bool VerificaIdadeDeRisco(int idade)
        {
            if (idade >= 18) return true;
            else return false;
        }

        public static bool VerificaNomeDeRisco(string name)
        {
            if (name == "corona") return false;
            else return true;
        }
    }
}
