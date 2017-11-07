using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permute_focal_lengths
{
    class Program
    {
        

        static void Main(string[] args)
        {
            while(true)
            { 
            double maginput;

            Console.WriteLine("Enter Magnification upto 4 decimal point or write userinput to select track length again");
                        
     
            while(!Double.TryParse(Console.ReadLine(), out maginput))
            {
                Console.WriteLine("input again");
            }


            }


        }

       
           
    }
}