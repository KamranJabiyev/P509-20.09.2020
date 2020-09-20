using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Adinizi yazin:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Salam "+ name);

            #region Homework
            //int n = 1;
            //int count = 0;

            //if (n > 0)
            //{
            //    while (n % 2 == 0)
            //    {
            //        n /= 2;
            //        count++;
            //    }
            //    if (n == 1)
            //    {
            //        Console.WriteLine("Quvvetidir");
            //        Console.WriteLine(count);
            //    }
            //    else
            //    {
            //        Console.WriteLine(-1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}

            int n = 1243545;
            int counter = 0;

            if (n < 0)
            {
                n *= (-1);
            }

            while (n>0)
            {
                n /= 10;
                counter++;
            }
            Console.WriteLine(counter);
            #endregion

            #region Variable,DataType
            //string courseName = "Code Academy";
            //courseName = "Test";
            //byte age = 255;
            //char letter = '@';
            //bool isMaried = true;
            //float pi = 3.14F;
            //double d = 1.2;
            //decimal p = 3.24M;
            #endregion

            #region Condition,Switch-case
            //int n = 101;

            //if (n > 100)
            //{

            //}
            //if (n > 90)
            //{

            //}
            //if (n > 80)
            //{

            //}

            //if (n > 100)
            //{

            //}
            //else if (n > 90)
            //{

            //}
            //else if (n > 80)
            //{

            //}
            //else
            //{

            //}

            //switch (n)
            //{
            //    case 100:
            //        Console.WriteLine("dogrudur -100");
            //        break;
            //    case 90:
            //        Console.WriteLine("dogrudur - 90");
            //        break;
            //    default:
            //        Console.WriteLine("default ishledi");
            //        break;
            //}
            #endregion

            #region Loops
            //for (int i = 0; i < 10; i++)
            //{

            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);

            //foreach (var item in collection)
            //{

            //}
            #endregion

            #region RunTime error, Try-catch

            //Console.WriteLine("Yashinizi daxil edin:");
            //string age = Console.ReadLine();

            //try
            //{
            //    int Age = int.Parse(age);
            //    if (Age > 16)
            //    {
            //        Console.WriteLine("Xosh gelmishsiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("gelmeee");
            //    }
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Eded daxil etmediniz");
            //}
            //finally
            //{
            //    Console.WriteLine("finally");
            //}

            
            #endregion
        }
    }
}
