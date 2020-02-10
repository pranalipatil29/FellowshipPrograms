/******************************************************************************
 *  Execution:    Utility.cs
 *  Purpose: contains methods and variables for performing different operations
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   07-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FunctionalPrograms
{
    /// <summary>
    /// Utility class contains different methods to perform different operations
    /// </summary>
    class Utility
    {
        /// <summary>
        /// ReadIntArray method is used to Read and storesthe integer type elemments in array
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public int[] ReadIntArray(int size)
        {
            Console.WriteLine("Enter " + size + " elements in array:");
            int[] arr = new int[size];
                 
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }    
               
            return arr;
        }
        /// <summary>
        ///FindSumOfThreeInt method is used to Find Triplates which addition is equals to zero 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>

        public void FindSumOfThreeInt(int[] arr,int size)
        {
            for(int i=0;i<size-2;i++)
            {
                for(int j=i+1;j<size-1;j++)
                {
                    for(int k=j+1;k<size;k++)
                    {
                        if(arr[i]+arr[j]+arr[k]==0)
                        {
                            Console.WriteLine("{" + arr[i] + ","+ arr[j] + "," + arr[k] + "}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// CalDistance method is used to Calculate the distance between two points.
        /// </summary>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public void CalDistance(int x2,int y2)
        {
            double ans = Math.Sqrt(Math.Pow((x2 - 0), 2)+ Math.Pow((y2 - 0), 2));
            Console.WriteLine("Euclidean Distance = " + (ans*100000)/10000);
        }

        /// <summary>
        /// FindQuadraticRoots method is used to finds the quadratic roots.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void FindQuadraticRoots(double a,double b,double c)
        {
            try
            {
                double delta, r1, r2;

                delta = b * b - 4 * a * c;
                //if delta value is greater than 0 then both roots are real
                if(delta>0)
                {
                    r1 = ((-b) + (Math.Sqrt(delta)) / (2 * a));
                    r2 = ((-b) - (Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("root 1 of X= " + r1);
                    Console.WriteLine("root 2 of X= " + r2);
                }
                //if delta value is equals to zero then one root is real
                if(delta==0)
                {
                    r1 = (-b) / (2 * a);
                    r2 = (-b) / (2 * a);
                    Console.WriteLine("root 1 of X= " + r1);
                    Console.WriteLine("root 2 of X= " + r2);
                }
                //if delta value is less than zero then both roots are not real
                if(delta<0)
                {
                    Console.WriteLine("No real roots :"+Math.Sqrt(b * b - 4 * a * c));
                }

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// CalWindChill method is used to Calculate the wind chill of given temperature and wind Speed.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="v"></param>
        public void CalWindChill(double t,double v)
        {
            //check temp is betwwen -58 to 41 & wind Speed is>2
            if ((Math.Abs(t) < 50) && v <= 120 && v > 2)
            {
                double ans = (35.74 + (0.621 * t) - (35.75 * (Math.Pow(v, 0.16)) + 0.4275 * t * (Math.Pow(v, 0.16))));
                Console.WriteLine("WindChill= " + ans);
            }
            else
            {
                Console.WriteLine("Please Enter temp <50 °F & wind Speed is>2 and <120");
            }
        }


        /// <summary>
        /// GetIntTwoDAray method is used to read integer values for the two D array.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int[,] GetIntTwoDAray(int x,int y)
        {
            int[,] arr = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter value for arr[" + i + "," + j + "]: ");
                   arr[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        /// <summary>
        /// PrintIntTwoDArray method is used to Write integer numbers into text File
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PrintIntTwoDArray(int[,] arr,int x,int y)
        {
                              
            using (StreamWriter sw = new StreamWriter("ArraysInfo.txt"))          
            {
                sw.WriteLine("Integer Array Elemnts: ");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        sw.Write(arr[i,j]+",");
                    }
                    sw.WriteLine("\n");
                }
               
            }  
        }
        /// <summary>
        /// GetDoubleTwoDArray method is used to read double values for the two D array.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double[,] GetDoubleTwoDArray(int x,int y)
        {
            double[,] arr = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter double value for arr[" + i + "," + j + "]: ");
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return arr;
        }
        /// <summary>
        /// PrintDoubleTwoDArr method is used to Write double type of numbers into text File
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PrintDoubleTwoDArr(double[,] arr,int x,int y)
        {
            // //Append values stored in array into the file
            FileStream f = new FileStream("ArraysInfo.txt", FileMode.Append, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(f))
            {
                sw.WriteLine("Double Values of Array: ");
                for(int i=0;i<x;i++)
                {
                    for(int j=0;j<y;j++)
                    {
                        sw.Write(arr[i, j]+",");
                    }
                    sw.WriteLine("\n");
                }
            }
        }
        /// <summary>
        /// GetBooleanTwoDArray method is used to read boolean type of value into array
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Boolean[,] GetBooleanTwoDArray(int x, int y)
        {
            Boolean[,] arr = new Boolean[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter Boolean value for arr[" + i + "," + j + "]: ");
                    arr[i, j] = Convert.ToBoolean(Console.ReadLine());
                }
            }
            return arr;
        }
        /// <summary>
        /// PrintDoubleTwoDArr method is used to write boolean type of values in to file
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>

        public void PrintDoubleTwoDArr(Boolean[,] arr, int x, int y)
        {
            // //Append values stored in array into the file
            FileStream f = new FileStream("ArraysInfo.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(f))
            {
                sw.WriteLine("Boolean Values of Array: ");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        sw.Write(arr[i, j] + ",");
                    }
                    sw.WriteLine("\n");
                }
            }
        }
    }
}
