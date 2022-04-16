using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Project
{
    public static class Helper
    {
        public static bool IsRightKeyword(string word)
        {
            if (word == "lol") return true;
            else return false;
        }
        public static bool IsOfAge(int age)
        {
            if (age < 18) return false;
            else return true;
        }
    }
}
