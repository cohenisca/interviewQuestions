using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewQuestions.Others
{
    class CalculateExpression
    {
        public CalculateExpression()
        {
            Console.WriteLine(calculate("31+15*4+2*33"));
        }
        public int calculate(string expression)
        {
            int mult = -1;
            int sum = 0;
            string param1 = "", param2 = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != '+' && expression[i] != '*' && mult == -1)
                {
                    param1 = param1 + expression[i].ToString();
                }
                else if (expression[i] != '+' && expression[i] != '*' && mult != -1)
                {
                    param2 = param2 + expression[i].ToString();

                }
                else if (expression[i] == '+')
                {
                    if (mult != -1)
                    {
                        sum += Convert.ToInt32(param1) * Convert.ToInt32(param2);
                        param1 = "";
                        param2 = "";
                        mult = -1;
                    }
                    else
                    {
                        sum += Convert.ToInt32(param1);
                        param1 = "";

                    }
                }
                else if (expression[i] == '*')
                {
                    if (param2 != "")
                    {
                        param1 = (Convert.ToInt32(param1) * Convert.ToInt32(param2)).ToString();
                        param2 = "";
                    }
                    else
                    {
                        mult = (Convert.ToInt32(param1));
                    }
                }
               
            }

            if (mult != -1)
            {
                return sum += Convert.ToInt32(param1) * Convert.ToInt32(param2);

            }
            else
            {
                return sum += Convert.ToInt32(param1);

            }
        }
    }
}
