using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class GiaiPT_18_Huynh
    {
        private float a, b, c;
        public GiaiPT_18_Huynh(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static String GiaiPT1(float a, float b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình vô số nghiệm.";
                else
                    return "Phương trình vô nghiệm.";
            }
            else
            {
                return "" + (-b / a);
            }
        }
        public static String GiaiPT2(float a, float b, float c)
        { 
            if(a == 0) 
            { 
                return GiaiPT1(b,c);
            }
            
            else 
            {
                float d = b * b - 4  * a * c;
                if (d < 0) 
                {
                    return "Phương trình vô nghiệm.";
                }
                else if (d == 0) 
                {
                    return "x1=x2= " + (-b / (2*a));
                }
                else
                {
                    float x1 = ((float)(-b + Math.Sqrt(d))) / (2 * a);
                    float x2 = ((float)(-b - Math.Sqrt(d))) / (2 * a);
                    return "x1=" + x1 + "  " + "x2=" + x2;
                }
                    
            }
        }
    }
}
