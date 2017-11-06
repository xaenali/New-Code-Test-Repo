using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permute_focal_lengths
{
    class Program
    {
        public static double perm(double[] F1, double[] F2, double[] F3, double[] MxratioMy, double[] Maxtrack)
        {
            int l;
            double[] Max = new double[3];
            for (int i = 0; i < F1.Length; i++)
            {
              
                
                
                for (int j = 0; j < F2.Length; j++)
                {
                   for(int k = 0; k < F3.Length; k++)
                   {
                      // int l;
                       MxratioMy[k] = Math.Round((double)F1[i] / F3[k], 4);
                       
                       Maxtrack[k] = Math.Round((double)F1[i] + 2 * F2[j] + F3[k] + (F2[j] * (((F3[k] * MxratioMy[k]) / F1[i]) + F1[i] / (F3[k] * MxratioMy[k]))), 4);
                       Max[i] = Maxtrack[k];
                   //   Console.WriteLine("MaxTrack = {0} and MinTrack = {1}", Max.Max(), Max.Min());
                       Console.WriteLine("The total system length (d1+d2) = {0}", Maxtrack[k]);
                     //  Console.WriteLine("MaxTrack = {0} and MinTrack = {1}", Maxtrack.Max(),Maxtrack.Min());

                      // Console.WriteLine("F1 = {0} , F2 = {1} and F3 = {2}",F1[i],F2[j],F3[k]);
                   }


                   //
                }
                Console.WriteLine("MaxTrack = {0} and MinTrack = {1}", Max.Max(), Max.Min());
            }

            for (int i = 0; i < Max.Length; i++)
            {
                Console.WriteLine(Max[i]);
            }
                // System.Console.WriteLine();
                return 0;
        }

        static void Main(string[] args)
        {

            double[] focallength1 = new double[] { 140,120,140 };
            double[] focallength2 = new double[] { -20}; // Initialize array for focal length 2
            double[] focallength3 = new double[] { 70,71,72 }; //Initialize array for focal length 3
            double[] a1 = new double[3];
            double[] MxratioMy = new double[3];
            double[] Maxtrack = new double[3];
           // double caseinput;
            //perm(focallength1,focallength2,focallength3);

          //  a1 = perm(focallength1,focallength2);

           // a1[m] = Math.Round((double)focallength1[k] + focallength2[l], 4);


             Console.WriteLine("Enter 0,1,2 to see all combinations with each resutls or d1 and d2 for Max Mag ");

             string input = Console.ReadLine();

             switch (input)
             {
                 case "0": 
                    
                     break;

                 case "1":   
                     
                    
                     break;

                 case "2":


                     break;

                 default:
                    
                     break;
             }

            perm(focallength1,focallength2,focallength3,MxratioMy,Maxtrack);


            /*

            double[] focallength1 = new double[] { 140 }; // Initialize array for focal length 1
            double[] focallength2 = new double[] { -20 }; // Initialize array for focal length 2
            double[] focallength3 = new double[] { 1 }; //Initialize array for focal length 3
            double[] MxratioMy = new double[3];
            double[] Mx = new double[3];
            double[] My = new double[3];
            double[] a1 = new double[3];
            double[] a2 = new double[3];
            double[] b1 = new double[3];
            double[] b2 = new double[3];
            double[] d1forMx = new double[3];
            double[] d2forMx = new double[3];
            double[] d1forMy = new double[3];
            double[] d2forMy = new double[3];
            double[] d1forMxratioMy = new double[3];
            double[] d2forMxratioMy = new double[3];
            double[] Maxtrack = new double[3];
            double[] d1forInputMax = new double[3];
            double[] d2forInputMax = new double[3];
            double[] d1forInputMin = new double[3];
            double[] d2forInputMin = new double[3];
            double[] Maxtrackstore = new double[3];
            double[] Maxlengths = new double[3];
            double InputMax, InputMin;

            int k, l, m, n = 0, o;

            while (true)
            {

                n = 0; // Make n(number of combination) = 0, in start and at the end of all the combination 

                Console.WriteLine("Enter Max Magnification upto 4 decimal point");

                InputMax = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Min Magnification upto 4 decimal point");

                InputMin = double.Parse(Console.ReadLine());


                //take f1, f2 and f3 to calculate Max magnification and compare with Mx and My magnifications

                for (k = 0; k < focallength1.Length; k++) // take f1
                {

                    for (l = 0; l < focallength2.Length; l++) // take f2
                    {


                        for (m = 0; m < focallength3.Length; m++) // take f3
                        {

                            a1[m] = Math.Round((double)focallength1[k] + focallength2[l], 4);

                            MxratioMy[m] = Math.Round((double)focallength1[k] / focallength3[m], 4);

                            a2[m] = Math.Round((double)focallength2[l] + focallength3[m], 4);

                            b1[m] = Math.Round((double)(focallength1[k] * focallength2[l]) / focallength3[m], 4);

                            b2[m] = Math.Round((double)(focallength2[l] * focallength3[m]) / focallength1[k], 4);

                            Mx[m] = Math.Round((double)-a2[m] / b2[m], 4);

                            My[m] = Math.Round((double)-b1[m] / a1[m], 4);


                            //comparison with Mx and My magnifications

                            if ((Mx[m] > MxratioMy[m]) && (MxratioMy[m] > My[m]) && (InputMax <= Mx[m]) && (InputMin >= My[m]) && (InputMax > InputMin))
                            {
                                n = n + 1;

                                Console.WriteLine("number of combination = {0} ", n);

                                Console.WriteLine("Conditions satified for comination {0}", n);

                                Console.WriteLine("take Mx as {0} and My as {1} with F1 as {2}, F2 as {3} and F3 as {4}", Mx[m], My[m], focallength1[k], focallength2[l], focallength3[m]);



                                //Calculate d1 and d2 for the Input Max and Min Magnification

                                d1forInputMax[m] = Math.Round((double)focallength1[m] + focallength2[m] + ((focallength1[m] * focallength2[m]) / (InputMax * focallength3[m])), 4);

                                d2forInputMax[m] = Math.Round((double)focallength2[m] + focallength3[m] + ((focallength2[m] * focallength3[m] * InputMax) / (focallength1[m])), 4);

                                // Check for very small negative distance value and convert them to zero

                                if ((d1forInputMax[m] >= -0.012) && (d1forInputMax[m] < 0))
                                {
                                    d1forInputMax[m] = 0;
                                }
                                else

                                    if ((d2forInputMax[m] >= -0.012) && (d2forInputMax[m] < 0))
                                {
                                    d2forInputMax[m] = 0;
                                }

                                Console.WriteLine("The system has d1 = {0} and d2 = {1} for Max magnification Input = {2} ", d1forInputMax[m], d2forInputMax[m], InputMax);

                                d1forInputMin[m] = Math.Round((double)focallength1[m] + focallength2[m] + ((focallength1[m] * focallength2[m]) / (InputMin * focallength3[m])), 4);

                                d2forInputMin[m] = Math.Round((double)focallength2[m] + focallength3[m] + ((focallength2[m] * focallength3[m] * InputMin) / (focallength1[m])), 4);

                                if ((d1forInputMin[m] >= -0.012) && (d1forInputMin[m] < 0))
                                {
                                    d1forInputMin[m] = 0;
                                }
                                else

                                    if ((d2forInputMin[m] >= -0.012) && (d2forInputMin[m] < 0))
                                {
                                    d2forInputMin[m] = 0;
                                }

                                Console.WriteLine("The system has d1 = {0} and d2 = {1} for Min magnification Input = {2} ", d1forInputMin[m], d2forInputMin[m], InputMin);


                                // Calculate Max d1 and d2 for Max magnification

                                d1forMx[m] = Math.Round((double)focallength1[m] + focallength2[m] + ((focallength1[m] * focallength2[m]) / (Mx[m] * focallength3[m])), 4);

                                d2forMx[m] = Math.Round((double)focallength2[m] + focallength3[m] + ((focallength2[m] * focallength3[m] * Mx[m]) / (focallength1[m])), 4);

                                if ((d1forMx[m] >= -0.012) && (d1forMx[m] < 0))
                                {
                                    d1forMx[m] = 0;
                                }
                                else

                                    if ((d2forMx[m] >= -0.012) && (d2forMx[m] < 0))
                                {
                                    d2forMx[m] = 0;
                                }

                                Console.WriteLine("The system has d1 = {0} and d2 = {1} for Maximum Magnification possible = {2} ", d1forMx[m], d2forMx[m], Mx[m]);


                                // Calculate d1 and d2 for Minimum magnification

                                d1forMy[m] = Math.Round((double)focallength1[m] + focallength2[m] + ((focallength1[m] * focallength2[m]) / (My[m] * focallength3[m])), 4);

                                d2forMy[m] = Math.Round((double)focallength2[m] + focallength3[m] + ((focallength2[m] * focallength3[m] * My[m]) / (focallength1[m])), 4);

                                if ((d1forMy[m] >= -0.012) && (d1forMy[m] < 0))
                                {
                                    d1forMy[m] = 0;
                                }
                                else

                                    if ((d2forMy[m] >= -0.012) && (d2forMy[m] < 0))
                                {
                                    d2forMy[m] = 0;
                                }

                                Console.WriteLine("The system has d1 = {0} and d2 = {1} for Mimimum Magnification possible = {2} ", d1forMy[m], d2forMy[m], My[m]);


                                // Calculate Max track length and d1 and d2 for that

                                Maxtrack[m] = Math.Round((double)focallength1[m] + 2 * focallength2[m] + focallength3[m] + (focallength2[m] * (((focallength3[m] * MxratioMy[m]) / focallength1[m]) + focallength1[m] / (focallength3[m] * MxratioMy[m]))), 4);


                                Console.WriteLine("The total system length (d1+d2) = {0} for Magnification = {1} with F1 = {2}, F2 = {3} and F3 = {4} ", Maxtrack[m], MxratioMy[m], focallength1[m], focallength2[m], focallength3[m]);

                                d1forMxratioMy[m] = Math.Round((double)focallength1[m] + focallength2[m] + ((focallength1[m] * focallength2[m]) / (MxratioMy[m] * focallength3[m])), 4);

                                d2forMxratioMy[m] = Math.Round((double)focallength2[m] + focallength3[m] + ((focallength2[m] * focallength3[m] * MxratioMy[m]) / (focallength1[m])), 4);

                                if ((d1forMxratioMy[m] >= -0.012) && (d1forMxratioMy[m] < 0))
                                {
                                    d1forMxratioMy[m] = 0;
                                }
                                else

                                    if ((d2forMxratioMy[m] >= -0.012) && (d2forMxratioMy[m] < 0))
                                {
                                    d2forMxratioMy[m] = 0;
                                }

                                Console.WriteLine("The system has maximum length with d1 = {0} and d2 = {1} and Magnification = {2} ", d1forMxratioMy[m], d2forMxratioMy[m], MxratioMy[m]);


                            }


                            else

                                if ((MxratioMy[m] > Mx[m]) || (My[m] > MxratioMy[m]) || (InputMax > Mx[m]) || (InputMin < My[m]) || (InputMax < InputMin))
                            {
                                n = n + 1;

                                Console.WriteLine("number of combination = {0} ", n);

                                Console.WriteLine("Conditions didn't satified for comination {0}", n);

                                Console.WriteLine("Can't choose InputMax = {0} and InputMin = {1} as InputMax ({0}) > Calculated Mx {2} or InputMin ({1}) < calculated My {3} with F1 as {4}, F2 as {5} and F3 as {6} ", InputMax, InputMin, Mx[m], My[m], focallength1[m], focallength2[m], focallength3[m]);

                            }
                        }

                    }

                }

            }

            */

        }

       
           
    }
}