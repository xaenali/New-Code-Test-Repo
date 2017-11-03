using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codetesting
{
    class Program
    {
     /*   static public double permute(params double[] focallength1, params double[] focallength2, params double[] focallength3)
        {
            double[] a1 = new double[3];

            
            a1= Math.Round((double)focallength1 + focallength2, 4);

        }


        static void Main(string[] args)
        {
            double[] focallength1 = new double[] { 140 }; // Initialize array for focal length 1
            double[] focallength2 = new double[] { -20}; // Initialize array for focal length 2
            double[] focallength3 = new double[] {1 }; //Initialize array for focal length 3

             int i, j, k ;           
           
            for (i = 0; i < focallength1.Length; i++)
            {
                for (j = 0; j < focallength2.Length; j++)
                {
                    for (k = 0; k < focallength3.Length; k++)
                    {
                        permute(focallength1[i],focallength2[j],focallength3[k]);
                    }
                }
            }
            
        } */

        static void Main(string[] args)
{
    GreetPersons(0);
    GreetPersons(2,"John", "Jane", "Tarzan");    
    Console.ReadKey();
}

static void GreetPersons(int someUnusedParameter, params string[] names)
{
    foreach(string name in names)
        Console.WriteLine("Hello, " + name);
}

        }
    }
