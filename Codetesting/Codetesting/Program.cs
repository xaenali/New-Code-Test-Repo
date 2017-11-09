using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApplication
{

    class Program
    {
        public static IList<double> focallength1 = new List<double>() { 130, 140, 150,140 ,1,2,4,5,5,65,6,6,6};
        public static IList<double> focallength2 = new List<double>() { -19, -20, -21 };
        public static IList<double> focallength3 = new List<double>() { 70, 71, 72 ,4,5,5,4,4,5,5,454,};
        public static IList<double> a1 = new List<double>() { };


        static void Main(string[] args)
        {



            for (int i = 0; i < focallength1.Count; i++)
            {
                for (int j = 0; j < focallength2.Count; j++)
                {
                    for (int k = 0; k < focallength3.Count; k++)
                    {
                        a1.Add(focallength1[i] + focallength2[j] + focallength3[k]);
                        Console.WriteLine(a1[k]);

                       // a1[k] = (double) F1[i] + F2[j] + F3[k];

                    }
                }
            }

        }
    }
}