/******************************************************************************
  *  Execution:    Utility.cs
 *  
 *  Purpose: Contains different Methods to perform different operations
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   09-11-2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace JUnit
{
    /// <summary>
    /// Utility class contains different methods to perform different operations
    /// </summary>
    class Utility
    {
        //To get Change of rs. by vending machine
        static int rem = 0, nonotes = 0, minNotes = 0;
        //hashtable contains which notes are required to give as change and count of them
        Hashtable ht = new Hashtable();
        /// <summary>
        /// GetChangeByvendingMachine method calculates the total number of
        /// notes to give change by vending machine to user.
        /// </summary>
        /// <param name="rs">The rs variable contains amount for which user wants change from vending machine</param>
        /// <param name="notes">The notes array contains different Rs. notes</param>
        /// <param name="i">The i variable is used to indicate the note in notes array </param>
        /// <param name="total">The total variable count the number of notes required</param>
        /// <returns></returns>
        public int GetChangeByvendingMachine(int rs,int[] notes,int i,int total)
        {
            try
            {
                if (rs == 0)
                {
                    return -1;
                }
                else
                {
                    if (rs >= notes[i])
                    {
                        nonotes = rs / notes[i];
                        rem = rs % notes[i];
                        rs = rem;
                        total += nonotes;
                        minNotes += nonotes;
                       ht.Add(nonotes,notes[i]);
                    }
                    i--;
                    GetChangeByvendingMachine(rs, notes, i, total);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return minNotes;
        }
        /// <summary>
        ///  printList method prints list of Required Notes list and count of notes
        /// </summary>

        public void printList()
        {
            ICollection key = ht.Keys;
            Console.WriteLine(" No. of Notes\t Note");         
            foreach(int i in key)
            {
               Console.WriteLine(" "+i + " \t\t " + ht[i]);
            }
            foreach (int k in key)
            {
                ht.Clear();
            }
        }


        /// <summary>
        /// FindDayOfWeek method find and prints the day of week.
        /// </summary>
        /// <param name="d">The d variable contain user entered date</param>
        /// <param name="m">The m variable contain user entered month.</param>
        /// <param name="y">The y variable contain user entered year.</param>
        public void FindDayOfWeek(int d,int m,int y)
        {
            int digit = 0,y1=y;
            int  year, month, temp, day = 0;
            //count digit in user entered year
            while (y1>0)
            {
                digit++;
                y1 /= 10;
            }
           if ((y != 0 && digit==4) && (m >= 1 && m <= 12) && (d >= 1 && d <= 31))          //check year, month and date are in proper format
            {
                year = y - (14 - m) / 12;
                temp = year + (year / 4) - (year / 100) + (year / 400);
                month = m + 12 * ((14 - m) / 12) - 2;
                day = (d + temp + 31 * month / 12) % 7;
            }
            else
            {
               Console.WriteLine("Please Enter Correct year");
            }
                   //dependinng upon day value prints day of given date 
           switch (day)
            {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
            }
           
        }

        /// <summary>
        /// ConverToCelcius method Convert and print fahrenheit Temperature into Celcius 
        /// </summary>
        /// <param name="fahr">variable contains user entered fahrenheit temperature</param>
        public void ConverToCelcius(double fahr)
        {
            double ans = (fahr - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit to Celcius: " + ans+" c");
        }

        /// <summary>
        ///  ToFahrenheit method Convert and print Celcius Temperature into fahrenheit
        /// </summary>
        /// <param name="ctemp">The ctemp variable contains user entered Celcius temperature.</param>
        public void ToFahrenheit(double ctemp)
        {
            double cTof = (ctemp * 9/5) + 32;
            Console.WriteLine("Celsius To Fahrenheit Temperature: " + cTof+" f");
        }

        /// <summary>
        /// CalMonthlyPayment method Calculates Monthly Payment
        /// </summary>
        /// <param name="p">p variable contains user entered principal amount</param>
        /// <param name="r">r variable contains user entered Rate per cent amount</param>
        /// <param name="y">y variable contains user entered count of number of years</param>
       public void CalMonthlyPayment(double p,double r,int y)
        {
            int n = y * 12;
            double R = r / (12 * 100);
            double ans = (p * R) / (1 - (Math.Pow((1 + R), (-n))));
            Console.WriteLine("Monthly Payment= " + ans);
        }

        /// <summary>
        /// CalSqrt method Calculates Sqrt of number by Newton's Method
        /// </summary>
        /// <param name="no">no variable contains user entered number</param>
        public void CalSqrt(int no)
        {
            double t = 1;
            double Epsilon = 1e-15;
            while(Math.Abs(t-no/t)>Epsilon*t)
            {
                t = (t + no / t) / 2;
            }
            Console.WriteLine("Sqrt of " + no + " is= " + t);
        }

        /// <summary>
        /// ConvertToBinary method Convert decimal number to binary and return binary number 
        /// </summary>
        /// <param name="no">no variable contains user entered decimal number</param>
        /// <returns></returns>
        public int[] ConvertToBinary(int no)
        {
            int[] binary = new int[1000];
            int i=0,k = 0;
            //if number is greater than 127 then its binary number is 8 bits
            if(no>127)
            {
                while(no>0)
                {
                    binary[i] = no % 2;
                    no = no / 2;
                    i++;
                }
                int[] result = new int[i];
                for(int j=i-1;j>=0;j--)
                {
                    result[k] = binary[j];
                    k++;
                }
                return result;
            }
            //if number is less than 127 then its binary numbers are less than8 bits so we need to add zeros to remaning positions 
            else
            {
               int m = 0,n=0;
                while(no>0)
                {
                    binary[m] = no % 2;
                    no /= 2;
                    m++;
                }
                int[] result = new int[m];
                for(int j=m-1;j>=0;j--)
                {
                    result[n] = binary[j];
                    n++;
                }
                int len = result.Length, add = 0;
                int[] resultarr = new int[8];
                i = 0; k = 0;
                if (len<8)
                {
                    add = 8 - len;
                    while(i<add)
                    {
                        resultarr[i] = 0;
                        i++;
                    }
                    for(int j=i;j<8;j++)
                    {
                        resultarr[j] = result[k];
                        k++;
                    }
                }
                return resultarr;
            }

        }

        /// <summary>
        /// Swapbinary method swap nibbles of binary number
        /// </summary>
        /// <param name="binary">binary variable array contains the binary number</param>
        /// <returns></returns>
        public int[] Swapbinary(int[] binary)
        {
            int[] arr1 = new int[4];
            int[] arr2 = new int[4];
            int[] result = new int[8];
            for(int i=0;i<4;i++)
            {
                arr1[i] = binary[i];

            }
            int j = 0;
            for(int i=4;i<8;i++)
            {
                arr2[j] = binary[i];
                j++;

            }
            for(int i=0;i<4;i++)
            {
                result[i] = arr2[i];
            }
            j = 0;
            for(int i=4;i<8;i++)
            {
                result[i] = arr1[j];
                j++;
            }
            return result;
        }

        /// <summary>
        /// BinarytoDecimal method convert binary number array to decimal number
        /// </summary>
        /// <param name="binary">binary variable array contains binary number</param>
        /// <returns></returns>
        public int BinarytoDecimal(int[] binary)
        {
            int len = binary.Length,no=0;
            //for converting array elements into int no
            int k = 0;
            for(int i=0;i<len;i++)
            {
                k = k * 10 + binary[i];
            }
            //Converting binary number to decimal number
            int n = 0, rem;
            while(k>0)
            {
                rem = k % 10;
                no += rem * (int)(Math.Pow(2, n));
                n++;
                k /= 10;
            }
            return no;
        }
    }
}
