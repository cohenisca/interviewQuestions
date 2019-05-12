using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// יש לך מערך עם כדורים אדומים, צהובים וירוקים. אתה צריך לסדר אותו כך שכל הכדורים האדומים יהיו בהתחלה
/// וכל הכדורים הירוקים יהיו בסוף.אין לך שטח זיכרון נוסף להשתמש בו.
/// </summary>
namespace interviewQuestions.Intel
{
    class Q1
    {
        public int[] bollsArray = new int[100];
        public Q1()
        {
            init();
        }

        private void init()
        {
            for (int i = 0; i < 100; i++)
            {
                bollsArray[i] = i % 3;
            }


        }

        public void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write("[" + item + "] ");
            }
        }
        public void arrangeBolls()
        {
            // for red bolls
            for (int i = 0; i < 100; i++)
            {
                if (bollsArray[i] != (int)BollColor.Red)
                {
                    var temp = bollsArray[i];
                    for (int j = i; j < 100; j++)
                    {
                        if (bollsArray[j] == (int)BollColor.Red)
                        {
                            bollsArray[j] = temp;
                            bollsArray[i] = (int)BollColor.Red;
                            break;
                        }
                    }
                }
            }


            // for green bolls
            for (int i = 99; i > 0; i--)
            {
                if (bollsArray[i] != (int)BollColor.Green)
                {
                    var temp = bollsArray[i];
                    for (int j = i; j > 0; j --)
                    {
                        if (bollsArray[j] == (int)BollColor.Green)
                        {
                            bollsArray[j] = temp;
                            bollsArray[i] = (int)BollColor.Green;
                            break;
                        }
                    }
                }
            }



        }

        enum BollColor
        {
            Red = 0,
            Yello = 1,
            Green = 2
        }
    }
}
