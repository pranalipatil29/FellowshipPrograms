/******************************************************************************
 *  Execution:    Utility.cs
 *  
 *  Purpose:Contains Different Methods to perform different operations
 *
 *  @author  Pranali Patil
 *  @version 1.0
 *  @since   11-11-2019
 *
 ******************************************************************************/
/// Including the requried assemblies in to the program
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Algorithmprograms
{
    /// <summary>
    /// Utility class contains all the methods which are required to perform different algorithm programs
    /// </summary>
    class Utility
    {
        /// <summary>
        /// getArrayElements method used to get the user defined type elements in array
        /// </summary>
        /// <typeparam name="T">T is generic member variable to take elements in array of user declared data type </typeparam>
        /// <returns></returns>
        public T[] getArrayElements<T>()
        {
            int size;
            //take size of array from user
            Console.WriteLine("Enter size of array:");
            size = Convert.ToInt32(Console.ReadLine());

            T[] arr = new T[size];
            //reads elements and store them in array
            Console.WriteLine("Enter " + size + " elements in Array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
            return arr;
        }

        /// <summary>
        /// bubbleSortIntArray method sort the array elements using bubble sort and print sorted array elements
        /// </summary>
        /// <param name="arr"></param>
        public void bubbleSortIntArray(int[] arr)
        {
            int temp,len = arr.Length;
            for(int i=0;i<len;i++)
            {
                for(int j=1;j<len;j++)
                {
                    if(arr[j-1]>arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }          
            }
            //printing sorted Array
            Console.WriteLine("\nAfter Sorting array Elemnts are: ");
            for (int k = 0; k < len; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }

        /// <summary>
        /// CheckAnagram method is used to check whwther two strings are anagram or not
        /// </summary>
        /// <param name="str1">str1 contains user entered first string</param>
        /// <param name="str2">str2 contains user entered second string</param>
        /// <returns></returns>
        public Boolean CheckAnagram(String str1,String str2)
        {
            //remove spaces in strings 
            string st1 = str1.Replace("\\s", "");
            string st2 = str2.Replace("\\s", "");
           //check whether both strings length is equals or not  if not then both strings are not anagram 
            if((st1.Length)==(st2.Length))
            {
                //convert both strings characters into lowercase and stores then in char array
                char[] s1 = st1.ToLower().ToCharArray();
                char[] s2 = st2.ToLower().ToCharArray();
                //sort the both array
                Array.Sort(s1);
                Array.Sort(s2);

                String s11 = new String(s1);
                String s22 = new String(s2);
                //check whether both strings contains same characters
                return (Array.Equals(s11, s22));
            }
            else
            {
                return false;
            }
          
        }

        /// <summary>
        /// CalPrimeNumbers method prints Prime numbers between 0-1000
        /// </summary>
        /// <param name="limit">limit variable contains limit till we need to find the prime numbers</param>
        /// <returns></returns>
        public int[] CalPrimeNumbers(int limit)
        {
            int[] arr = new int[limit];
            int j = 0;
            for(int i=2;i<=limit;i++)
            {
                //check no is prime or not ,if yes then store it in different array
                if(isPrime(i))
                {
                    arr[j] = i;
                    j++;
                }
            }
            //store prime numbers in array
            int[] res = new int[j];
            for(int i=0;i<j;i++)
            {
                res[i] = arr[i];
            }
            return res;
        }

        /// <summary>
        /// isPrime method checks given no is prime or not and return boolean value for result
        /// </summary>
        /// <param name="no">no variable contain number tobe checked</param>
        /// <returns></returns>
        public Boolean isPrime(int no)
        {
            for(int i=2;i<=no/2;i++)
            {
                if (no % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// CheckPalindromeNum method returns the list of prime numbers which are palindrome
        /// </summary>
        /// <param name="primenum">primenum ia a array variable which contains prime numbers</param>
        /// <returns></returns>
        public String CheckPalindromeNum(int[] primenum)
        {
            //palindrome variable stores prime numbers which are Palindrome
            String palindrome = "";
            for (int i=0;i< primenum.Length;i++)
            {
                if (checkPalindrome(primenum[i]))
                {
                    palindrome += (primenum[i]).ToString() +" ";
                }
            }
            return palindrome;
        }
        /// <summary>
        /// checkPalindrome method checks the given number is palindrome or not and return the result in boolean value
        /// </summary>
        /// <param name="no">no variable contains number tobe checked for palindrome</param>
        /// <returns></returns>
        public Boolean checkPalindrome(int no)
        {
            int rev = 0, rem = 0, temp = no;
            //make reverse of given number
            while(temp>0)
            {
                rem = temp % 10;
                temp /= 10;
                rev = rev * 10 + rem;
            }
            //check whether reverse of given number is equals to given number 
            //if yes then return true
            if (no == rev)
                return true;
            else
                return false;
        }

        /// <summary>
        /// PrintAnagramPrimeNum method Prints the prime numbers which are anagram.
        /// </summary>
        /// <param name="primenum">The primenum array contains prime numbers.</param>
        public void PrintAnagramPrimeNum(int[] primenum)
        {
            ArrayList list1 = new ArrayList();
            ArrayList list2 = new ArrayList();
        //count variable stores count of Prime numbers that are anagram 
            int count = 0;
            for(int i=0;i<primenum.Length;i++)
            {
                String a1 = primenum[i].ToString();
                for(int j=i+1;j<primenum.Length;j++)
                {
                  String a2 = primenum[j].ToString();
                    if((a1.Length)==(a2.Length))
                    {
                        char[] s1 = a1.ToCharArray();
                        char[] s2 = a2.ToCharArray();
                        //sort both array
                        Array.Sort(s1);
                        Array.Sort(s2);
                        //convert array values into String 
                        String str1 = new String(s1);
                        String str2 = new String(s2);
                        //if both string variable values are same then add them to list
                        if(Array.Equals(str1,str2))
                        {
                            list1.Add(a1);
                            list2.Add(a2);
                            count++;
                        }
                    }
                }
           
            }
            //Print Prime Numbers that are anagram
            for (int k = 0; k < count; k++)
            {
                Console.WriteLine(list1[k] + " " + list2[k]);
            }
        }

        /// <summary>
        /// ReadWordsFromFile method reads the words from file and store them in list
        /// </summary>
        /// <returns></returns>
        public ArrayList ReadWordsFromFile()
        {
            ArrayList list = new ArrayList();
           
            using (StreamReader fr = new StreamReader("info.txt"))
            {
                String a;
                while ((a=fr.ReadLine())!=null)
                {
                    string[] words = a.Split(' ');
                                  
                   foreach(var i in words)
                        list.Add(i);
                }
                return list;
            }
            
        }
        /// <summary>
        /// SearchWord method search the user entered word from list and prints result
        /// </summary>
        /// <param name="list">list is ArrayList which contains list of words</param>
        /// <param name="key">key is a user entered word for searching</param>
        public void SearchWord(ArrayList list,String key)
        {
            string[] arr = new string[list.Count];
            Boolean flag = false;
            
            int i = 0;
            //store words in list into array
            while(list.Count>i)
            {
                arr[i] = list[i].ToString();
                i++;
            }
            //sort the array elements
            Array.Sort(arr);
            //perform binary search on array to find the word
            int start = 0, last = arr.Length - 1, mid;
            while (start<=last)
            {
                mid = (last + start) / 2;
                //check whether key is middle element or not and stores result in result variable
                int result = String.Compare(key,arr[mid]);
               //if result variable contains 0 means word is found
                if (result == 0)
                {
                    //if word found set flag variable to true 
                    flag = true;
                    break;
                }
                //if result variable contains value greater than 0 means required word is greater than middle element
                if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
            if(flag)
                Console.WriteLine("Word Found..");
            else
                Console.WriteLine("Word Not Found..");         
        }

        /// <summary>
        /// InsertionSortArray method Sorts the array word elements using Insertion Sort
        /// </summary>
        /// <param name="arr">arr variable contains words for sorting</param>

        public void InsertionSortArray(String[] arr)
        {
            int len = arr.Length,j;
            String key = "";
            for(int i=1;i<len;i++)
            {
                j = i - 1;
                //put i'th element word in key variable
                key = arr[i]; 
               while(j>=0)
                {
                    //compare key value with j'th element in array
                    if(String.Compare(key,(arr[j]))>0)      //if key value is greater than j'th element in word break the loop
                    {
                        break;
                    }
                    //else replace the elements in array
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
            //print sorted array elements
            for(int i=0;i<len;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// MergeSortArrayWords method Sorts the Words in array using Merge Sort
        /// </summary>
        /// <param name="arr">arr contains list of words tobe sort</param>
        /// <param name="start">start variable points starting location of array</param>
        /// <param name="last">last variable points last location of array</param>
        public void MergeSortArrayWords(String[] arr,int start,int last)
        {
            int mid;
            //sort or merge the array till starting point is less than last point
            if(start<last)
            {
                mid = (start + last) / 2;
                //sort the left side of array until each word become single element in array
                MergeSortArrayWords(arr, start, mid);
                //sort the right side of array until each word become single element in array
                MergeSortArrayWords(arr, mid + 1, last);
                //merge the array
                Merge(arr, start, mid, last);
                
            }
           
        }
        /// <summary>
        /// Merge method sort the array elements and merge the sorted array
        /// </summary>
        /// <param name="arr">arr variable contains word elements tobe sort and merge</param>
        /// <param name="start">start variable contain starting position of array</param>
        /// <param name="mid">mid variable contain middle position of array</param>
        /// <param name="last">last variable contain last position of array</param>
        public void Merge(String[] arr,int start,int mid,int last)
        {
            int s1 = mid - start + 1;
            int s2 = last - mid;
            //create 2 array for left side array and right side array
            String[] left = new String[s1];
            String[] right = new String[s2];
            int t = 0;
            
            //put elements of left side array into left array
            for (int i = 0; i < s1; i++)
                left[i] = arr[start+i];
            
            //put elements of right side array into right array
            for (int j = 0; j < s2; j++)
                right[j] = arr[mid + 1 + j];

            int m = 0, n = 0, k = start;
            //compare both array elements with each other
            while(m<s1 && n<s2)
            {
                if((String.Compare(left[m],right[n]))<=0)
                {
                    //if left side array element is leass than right side array element put left side array element in final sorted array
                    arr[k] = left[m];
                    m++;
                }
                else
                {
                    //if left side array element is greater than right side array element put right side array element in final sorted array
                    arr[k] = right[n];
                    n++;
                }
                k++;
            }
            //put remeaning left side array elements in final sorted array
            while(m<s1)
            {
                arr[k] = left[m];
                m++;
                k++;
            }
            //put remeaning right side array elements in final sorted array
            while (n < s2)
            {
                arr[k] = right[n];
                n++;
                k++;
            }
        }

        /// <summary>
        /// ModifyMsg method checks user entered values are in proper format or not.
        /// if yes then replace the user information with new info in given Message.
        /// </summary>
        /// <param name="msg">msg variable contains the old Message</param>
        /// <param name="nm">nm variable contains user entered name</param>
        /// <param name="fullnm">fullnm variable contains user entered full name</param>
        /// <param name="date">date variable contain old date in message</param>
        /// <param name="contactno">contactno variable contains user entered contact number</param>
        public void ModifyMsg(String msg,String nm,String fullnm,String date,String contactno)
        {
            String newmsg = "";
            //pattern variable contain pattern for name value
            String pattern = "^[A-Z][a-z]*$";
            Regex rg = new Regex(pattern);
            Match match = Regex.Match(nm, pattern);
            if (match.Success)
                newmsg = msg.Replace("<<name>>", nm);
            else
                Console.WriteLine("Please Enter Correct Name ");

            //fnmpattern variable contain pattern for full name value
            string fnmpattern = "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$";
            Regex rg1 = new Regex(fnmpattern);
            match = Regex.Match(fullnm, fnmpattern);
            if (match.Success)
                newmsg = newmsg.Replace("<<full name>>", fullnm);
            else
                Console.WriteLine("Please Enter Correct Full Name ");

            //noPattern variable contain pattern for contact number
            String noPattern = "^[0-9]{10}$";
            Regex norg = new Regex(noPattern);
            match = Regex.Match(contactno, noPattern);
            if (match.Success)
                newmsg = newmsg.Replace("91-xxxxxxxxxx", contactno);
            else
                Console.WriteLine("Please Enter Correct Contact Number ");

            //datepattern variable contain pattern for Date
            DateTime dt = DateTime.Now;
            DateTime currentdate = DateTime.SpecifyKind(dt, DateTimeKind.Local);
            String datepattern = "^\\d{1,2}/\\d{1,2}/\\d{4}$";
            Regex drg = new Regex(datepattern);
            if (match.Success)
                newmsg = newmsg.Replace(date, currentdate.ToString());
            


            Console.WriteLine("\n Modified Message= " + newmsg+"\n");
        }

        /// <summary>
        /// CalPermutation method 
        /// </summary>
        /// <param name="str">str variable contains string on which we need to perform permutation</param>
        /// <param name="start">start variable idicates starting position of string</param>
        /// <param name="last">last variable idicates last position of string</param>
        public void CalPermutation(String str,int start,int last)
        {
            if (start == last)
            {
                Console.WriteLine(str);
            }
              
            else
            {
                for(int i=start;i<last;i++)
                {
                    str = swap(str, start, i);
                    CalPermutation(str, start + 1, last);
                    str = swap(str, start, i);
                }
            }
        }
        /// <summary>
        /// swap method is used to swap the characters in string
        /// </summary>
        /// <param name="s">s variable contains string</param>
        /// <param name="m">m variable indicates position of first character tobe replaced</param>
        /// <param name="n">n variable indicates position of last character tobe replaced</param>
        /// <returns></returns>
        public String swap(String s,int m,int n)
        {
            char temp;
            char[] arr = s.ToCharArray();
            temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;
            String arr1 = new String(arr);
            return arr1;
           
        }

        /// <summary>
        /// GuessNumberByBinarySearch method finds middle number and find its the required number or not
        /// </summary>
        /// <param name="range"></param>
        public void GuessNumberByBinarySearch(int first,int mid,int last)
        {
           
            try
            {
                Boolean Flag = false;
                int result=1;

                if (first != last && Flag==false)
                {
                    while (result != 0)
                    {
                        Console.WriteLine("If your number is = " + mid + " if yes then enter 0 else enter 1\n");
                        result = Convert.ToInt32(Console.ReadLine());
                        if (result == 0)
                        {
                            Console.WriteLine("Number is found");
                            Flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("if your number is between " + first + " to " + mid + " if yes then then enter 0 else enter 1\n");
                            result = Convert.ToInt32(Console.ReadLine());

                            if (result == 0)
                            {

                                last = mid;
                                mid = (last - first) / 2;
                                mid = first + mid;
                                GuessNumberByBinarySearch(first, mid, last);
                            }
                            else
                            {
                                Console.WriteLine("if your number is between " + mid + " to " + last + " if yes then enter 0 else enter 1\n");
                                result = Convert.ToInt32(Console.ReadLine());
                                if (result == 0)
                                {
                                    first = mid;
                                    mid = (last - first) / 2;
                                    mid = first + mid;
                                    GuessNumberByBinarySearch(first, mid, last);
                                }                                  
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct value");
            }
            
        }

       
    }
}
