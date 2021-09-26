using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableName_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "qq-q";
            bool x = variableName(s);
            Console.WriteLine(x);
        }

        static bool variableName(string name)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i <= name.Length - 1; i++)
            {
                if (name[0]>=(char)0 && name[0]<=(char)64 || 
                    name[0] >=(char)91 && name[0] <= (char)94 ||
                    name[0] == (char)96 ||
                    name[0] >= (char)123 && name[0] <= (char)685)
                {
                    return false;
                }
                else if (name[0] >= (char)65 && name[0] <= (char)90 ||
                    name[0] >= (char)97 && name[0] <= (char)122 )
                {
                    x = 1;
                }
                if (i > 0)
                {
                    if (name[i] >= (char)0 && name[i] <= (char)47 ||
                        name[i] >= (char)58 && name[i] <= (char)64 ||
                        name[i] >= (char)91 && name[i] <= (char)94 ||
                        name[i] >= (char)96 && name[i] <= (char)96 ||
                        name[i] >= (char)123 && name[i] <= (char)685)
                    {
                        y = 1;
                    }
                }

            }
            if (x==1 && y == 0)
            {
                return true;
            }
            return false;
        }
    }
}
