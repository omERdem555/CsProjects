using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Ocak2025_Kodları
{
    internal class VeriYapıları
    {
    }
    public class ParantezSorusu
    {
        static public bool HataVar(string ifade)
        {
            Stack<char> S = new Stack<char>();

            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == '(' || ifade[i] == '[' || ifade[i] == '{')
                    S.Push(ifade[i]);
                else if (ifade[i] == ')' || ifade[i] == ']' || ifade[i] == '}')
                    S.Pop();
            }

            if (S.Count() == 0)
                return false;
            else
                return true;
        }

    }
}
