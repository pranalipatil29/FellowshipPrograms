// ******************************************************************************
//  <copyright file="Utility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  Utility.cs
//  
//     Purpose:    Utility class contains difernrt methods to perform different operations
//
//     @author  Pranali Patil
//     @version 1.0
//     @since   15-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
//
// ******************************************************************************/
namespace DataStructurePrograms
{
    /// Including the requried assemblies in to the program
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Utility class contains all the methods for performing different operations
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The count variable is used to count the prime numbers between range 0-1000
        /// </summary>
        public int count = 0;

        /// <summary>
        /// anagramCount variable is used to count the prime numbers which are anagrams
        /// </summary>
        public int anagramCounter = 0;

        /// <summary>
        /// The notAnagramCounter variable is used to count the prime numbers which are not anagrams
        /// </summary>
        public int NotAnagramCounter = 0;

        /// <summary>
        ///  range variable array defines range of prime numbers which are stored in row of 2D array
        /// </summary>
        public int[] Range = { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

        /// <summary>
        /// The months array stores the months in year    
        /// </summary>
        public string[] Months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

        /// <summary>
        /// The dates array stores dates for each month
        /// </summary>
        public int[] Dates = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        ///  The week array stores the days for each week
        /// </summary>
        public string[] Week = { "Sun", "Mon", "Tue", "Wed", "The", "Fri", "Sat" };
       
        /// <summary>
        /// The head is used to point the head node in linked list
        /// </summary>
        public static Node head;

        /// <summary>
        /// AddDataInLinkedList method is used to add a new node in linked list
        /// </summary>
        /// <param name="data">The data parameter contains value tobe stored in linked list.</param>
        public void AddDataInLinkedList(string data)
        {
            // create a new node and assign new data to that node
            Node newNode = new Node(data);

            // checks whteher the linked list is null or not 
            if (head == null)
            {
                // if the linked list is empty then assign a head node to new node
                head = newNode;
                newNode.next = null;
            }
            else
            {
                // if linked list is not empty then points a current node to head
                Node currentNode = head;

                // traverse the linked list until it reaches the last node in linked list
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                
                // when current node reaches last node in linked list add the created new node at last in linked list
                currentNode.next = newNode;
            }
        }

        /// <summary>
        /// PrintList method prints the linked list.
        /// </summary>
        public void PrintList()
        {
            // points a current node to head
            Node currentNode = head;

            // traverse the linked list until it reaches the last node in linked list
            while (currentNode != null)
            {
                // print the data at current Node
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }

        /// <summary>
        /// ReadElementsFromFile method reads the elements from file and return word.
        /// </summary>
        /// <returns>returns the string from file</returns>
        public string ReadElementsFromFile()
        {
            // creating StreamReader class object pointing to the required file to read Words from file
            string returnWordsList = string.Empty;

            using (StreamReader streamReader = new StreamReader("WordElements.txt"))
            {
                // fileWords variable stores the list of words in file
                string fileWords = string.Empty;

                // reads the words from file until it goes to end point in file
                while ((fileWords = streamReader.ReadLine()) != null)
                {
                    // contains in file will added into fileWords variable
                    fileWords += " " + streamReader.ReadLine();

                    returnWordsList += " " + fileWords;
                }

                // closing the stream reader object
                streamReader.Close();

                // returnWordsList variable contains words in file
                return returnWordsList;
            }
        }

        /// <summary>
        /// AddInLinkedList method is used to Add word in linked list.
        /// </summary>
        /// <param name="words">The word variable contains the word which needs to add in linked list.</param>
        public void AddToLinkedList(string words)
        {
            // singleWord variable contains a  words in file
            string[] singleWord = words.Split(' ');

            // for loop is used to iterate the loop until all words in singleWord array
            for (int i = 0; i < singleWord.Length; i++)
            {
                // adding words in linked list
                this.AddDataInLinkedList(singleWord[i]);
            }
        }

        /// <summary>
        /// SearchUserWord method Searches the user word in linked list
        /// if word is present in linked list it will delete the word from linked list
        /// if word not present in linked list it will return false value 
        /// </summary>
        /// <param name="searchWord">The search word.</param>
        /// <returns>returns true or false value</returns>
        public bool SearchUserWord(string searchWord)
        {
            // creating currentNode and previousNode for pointing linkedlist nodes
            Node currentnode = head;
            Node previusNode = head;

            // flag variable indicates whether required word is found or not
            bool flag = false;

            // first checks the user entered data matches with head Node data in linked list
            if (currentnode.data.Equals(searchWord) && currentnode == head)
            {
                // if requered data is present at head node then points the head pointer to next node 
                head = currentnode.next;
                flag = true;
            }

            // checks every node data in linked list until list ends or data found
            while (currentnode != null && currentnode.data.Equals(searchWord) != true)
            {
                // increments currentNode and previousNode pointer
                previusNode = currentnode;
                currentnode = currentnode.next;
            }

            // if data is found checks that node is empty or not
            if (currentnode != null)
            {
                // if required data found then change the next pointer
                previusNode.next = currentnode.next;
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// WriteToFile method Writes the linked list elements in file.
        /// </summary>
        public void WriteToFile()
        {
            // pointing current node to head
            Node currentnode = head;

            // creating StreamWriter class object and passing the file name to it
            // for writing the linked list elements in that file
            using (StreamWriter streamWriter = new StreamWriter("UpdatedElements.txt"))
            {
                // traverse the linkedlist until last node
                streamWriter.WriteLine("Updated information is as follows: \n");
                while (currentnode != null)
                {
                    // writing linkedlist elements in file
                    streamWriter.Write(currentnode.data + " ");

                    // goes to next node in linked list
                    currentnode = currentnode.next;
                }

                // closing StreamWriter class object 
                streamWriter.Close();
            }
        }

        /// <summary>
        /// GetPrimeNumbers method calculates the prime numbers between 0-1000.
        /// </summary>
        /// <param name="limit">The limit variable stores the number till we want the prime numbers.</param>
        /// <returns> this method returns the array of prime numbers between 0 to given limit</returns>
        public int[] GetPrimeNumbers(int limit)
        {
            // primeNumbersArray array stores the prime numbers
            int[] primeNumbersArray = new int[limit];
            int j = 0;

            // for loop is iterated from 2 to given limit to check whether that number is prime or not
            for (int i = 2; i <= limit; i++)
            {
                // isPrime method returns the boolean value after chcking i number for prime number condition
                if (this.IsPrime(i))
                {
                    // if isPrime() method returns true value that means the number is prime so we add it in primeNumbersArray array
                    primeNumbersArray[j] = i;
                    j++;

                    // count variable count the prime numbers
                    this.count++;
                }
            }

            // primeNumbers stores the prime numbers from 0-1000
            int[] primeNumbers = new int[j];

            // for loop is used to store the all elements in primeNumbersArray array into primeNumbers array
            for (int i = 0; i < j; i++)
            {
                primeNumbers[i] = primeNumbersArray[i];
            }

            // returns the prime Numbers from 0-10000
            return primeNumbers;
        }

        /// <summary>
        /// isPrime method determines whether the specified number is prime or not.
        /// </summary>
        /// <param name="number">The number variable indicates the number tobe checked for prime number condition.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is prime; otherwise, returns<c>false</c>.
        /// </returns>
        public bool IsPrime(int number)
        {
            // for loop is used to check whether the given number gets evenly divided by any other number
            for (int i = 2; i <= number / 2; i++)
            {
                // checks whether the number gets evenly divided by any other number
                if (number % i == 0)
                {
                    // if number gets evenly divided by any other number thet mesns the number is not prime so return false value
                    return false;
                }
            }

            // if number cant get evenly divided by any other number that means the number is prime number so return true
            return true;
        }

        /// <summary>
        /// StorePrimNumbersInTwoDArray method Stores the prim numbers in 2D array.
        /// </summary>
        /// <param name="primeNumbers">The primeNumbers is a array variable that contains prime numbers.</param>
        /// <returns>this method returns the 2D Jagged array which contains the prime numbers in range of 0-100,100-200 and so on till 1000</returns>
        public int[][] StorePrimNumbersInTwoDArray(int[] primeNumbers)
        {
            // primeNumbersTwoDArray is a 2D Jagged array having 10 rows
            int[][] primeNumbersTwoDArray = new int[10][];

            // k variable is used to indicates the no.of column in each row
            int k = 0;

            // counting the column in each row
            // first for loop is used for row count. it iterates untill it goes to 10th row in array
            for (int i = 0; i < 10; i++)
            {
                // second fro loop is used to point the prime numbers from 0-1000
                for (int j = 0; j < this.count; j++)
                {
                    // checks whether the prime number is in between the range of i'th row or not
                    if (this.Range[i] <= primeNumbers[j] && primeNumbers[j] <= this.Range[i + 1])
                    {
                        // if the prime number is in range of i'th row then increment the column counter by 1.
                        primeNumbersTwoDArray[i] = new int[++k];
                    }
                }
            }

            // storing prime numbers in to primeNumbersTwoDArray 2d Jagged array
            for (int i = 0; i < 10; i++)
            {
                // first loop iterates till all 10 rows in primeNumbersTwoDArray jagged array
                for (int j = 0; j < primeNumbersTwoDArray[i].Length; j++)
                {
                    // second for loop is used to point each column value in i'th row
                    // store the prime number in primeNumbersTwoDArray jagged array
                    primeNumbersTwoDArray[i][j] = primeNumbers[j];
                }
            }

            // returns the primeNumbersTwoDArray 2D jagged array containing the prime numbers
            return primeNumbersTwoDArray;
        }

        /// <summary>
        /// isAnagram method checks which prime numbers is anagrams.
        /// </summary>
        /// <param name="primeNumbers">The primeNumbers variable contains all the prime numbers from 0-1000.</param>
        /// <returns>this method returns the array which holds prime numbers that are anagrams</returns>
        public int[] IsAnagram(int[] primeNumbers)
        {
            // anagrams array used to holds the prime numbers which are anagram
            int[] anagrams = new int[primeNumbers.Length];

            // anagramarrayPosition variable indicates the position in anagrams array
            int anagramarrayPosition = 0;

            // for loop iterates till it reaches the last number in primeNumbers array
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                // second for loop is used to take primeNumber array elements which till last number in array 
                for (int j = i + 1; j < primeNumbers.Length; j++)
                {
                    // CheckIsNumberAnagram method checks whether i'th and j'th location number are anagram or not and store result in result variable
                    bool result = this.CheckIsNumberAnagram(primeNumbers[i], primeNumbers[j]);

                    // if result is true then add i'th prime number in anagrams array
                    if (result)
                    {
                        anagrams[anagramarrayPosition] = primeNumbers[i];

                        // increment the position of anagrams array
                        anagramarrayPosition++;
                        this.anagramCounter++;
                    }

                    if (result)
                    {
                        // if result is true then also add j'th number in anagrams array 
                        anagrams[anagramarrayPosition] = primeNumbers[j];

                        // increment the position counter for anagrams array
                        anagramarrayPosition++;
                        this.anagramCounter++;
                    }
                }
            }

            // creating 2D array for storing only anagram numbers
            int[] anagramNumbers = new int[this.anagramCounter];

            // for loop iterares till all the angram numbers in angram array are stored in anagramNumbers array
            for (int i = 0; i < this.anagramCounter; i++)
            {
                anagramNumbers[i] = anagrams[i];
            }

            // returning array which holds all the prime numbers which are anagrams
            return anagramNumbers;
        }

        /// <summary>
        /// CheckIsNumberAnagram method Checks whether the both numbers are anagram or not.
        /// </summary>
        /// <param name="firstNumber">The firstNumber variable holds one prime number.</param>
        /// <param name="secondNumber">The secondNumber variable holds second prime number.</param>
        /// <returns>this method returns true if both numbers are anagram otherwise return false</returns>
        public bool CheckIsNumberAnagram(int firstNumber, int secondNumber)
        {
            // converting both numbers to string type
            string firstPrimeNumber = new string(firstNumber.ToString());
            string secondPrimeNumber = new string(secondNumber.ToString());

            if (firstPrimeNumber.Length == secondPrimeNumber.Length)
            {
                // storing both numbers digit in char array
                char[] charArray1 = firstPrimeNumber.ToCharArray();
                char[] charArray2 = secondPrimeNumber.ToCharArray();

                // sorting both array elements
                Array.Sort(charArray1);
                Array.Sort(charArray2);

                // converting both char array elements to string
                string numberFirst = new string(charArray1);
                string numberSecond = new string(charArray2);

                // checks whether both strings are equal or not if equal then return true otherwise return false
                return numberFirst.Equals(numberSecond);
            }

            // if both strings are not equal then return false
            return false;
        }

        /// <summary>
        /// isNotAnagram method is used to store the prime numbers which are not Anagram numbers
        /// </summary>
        /// <param name="primeNumbers">primeNumbers parameter holds all the prime numbers</param>
        /// <param name="anagrams">anagrams parameter holds all the prim numbers which are not anagram</param>
        /// <returns>returns array of prime numbers which are not anagrams</returns>
        public int[] IsNotAnagram(int[] primeNumbers, int[] anagrams)
        {
            // notAnagrams array used to holds the prime numbers which are not anagram
            int[] notAnagrams = new int[primeNumbers.Length];

            // anagramarrayPosition variable indicates the position in anagrams array
            int notanagramarrayPosition = 0;

            // for loop iterates till it reaches the last number in primeNumbers array
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                bool flag = false;

                // second for loop is used to take primeNumber array elements which till last number in array 
                for (int j = 0; j < anagrams.Length; j++)
                {
                    // CheckIsNumberAnagram method checks whether i'th and j'th location number are anagram or not and store result in result variable
                    bool result = primeNumbers[i] == anagrams[j];
                    if (result)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    // if result is true then add i'th prime number in anagrams array
                    notAnagrams[notanagramarrayPosition] = primeNumbers[i];

                    // increment the position of notanagrams array
                    notanagramarrayPosition++;
                    this.NotAnagramCounter++;
                }
            }

            // storing only Prime numbers that are not anagrams from notAnagrams array(removing extra null values from notAnagrams array
            int[] notAnagramNumber = new int[this.NotAnagramCounter];
            for (int i = 0; i < this.NotAnagramCounter; i++)
            {
                notAnagramNumber[i] = notAnagrams[i];
            }

            // returning prime numbers which are not anagrams
            return notAnagramNumber;
        }

        /// <summary>
        /// AnagramsInTwoDArray method is used to store Prime numbers that are Anagrams in 2D array
        /// </summary>
        /// <param name="anagramNumbers">anagramNumbers array holds the prime numbers which are anagram</param>
        /// <param name="notAnagrams">The not anagrams.</param>
        /// <returns>
        /// returns the 2D array which holds the anagram numbers
        /// </returns>
        public int[][] AnagramsInTwoDArray(int[] anagramNumbers, int[] notAnagrams)
        {
            // anagramsInTwoD is 2D array in which 1st row holds all the prime numbers that are anagram
            // and 2nd row holds the prime numbers that are not anagrams
            int[][] AnagramNotAnagramInTwoD = new int[2][];

            // assigning column length for each row in AnagramNotAnagramInTwoD array
            // first row contains only Prime numbers that are angarams
            AnagramNotAnagramInTwoD[0] = new int[anagramNumbers.Length];

            // Second row contains only Prime numbers that are not angarams
            AnagramNotAnagramInTwoD[1] = new int[this.NotAnagramCounter];

            // row variable is used to indicate each row in AnagramNotAnagramInTwoD array
            int row = 0;

            // repeate the loop untill 1st row
            while (row != 1)
            {
                // first for loop iterates till first row column length
                for (int j = 0; j < AnagramNotAnagramInTwoD[row].Length; j++)
                {
                    // storing prime numbers that are anagrams in 1st row of AnagramNotAnagramInTwoD array
                    AnagramNotAnagramInTwoD[row][j] = anagramNumbers[j];
                }

                row++;

                // second for loop iterates till second row column length
                for (int j = 0; j < AnagramNotAnagramInTwoD[row].Length; j++)
                {
                    // storing prime numbers that are not anagrams in 2nd row of AnagramNotAnagramInTwoD array
                    AnagramNotAnagramInTwoD[row][j] = notAnagrams[j];
                }
            }

            // returning the 2D array which 1st row holds the prime numbers that are anagram and  prime numbers that are not anagrams
            return AnagramNotAnagramInTwoD;
        }

        /// <summary>
        /// isLeapYear method is used tod determines whether the user entered year is leap year or not.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeapYear(int year)
        {
            // checks condition for leap year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                // if condition for leap year is true then return true indicating that year is leap year
                return true;
            }
            else
            {
                // return false indicating year is not leap yaer
                return false;
            }
        }  
       
        /// <summary>
        /// CalculateDayOfWeek method Calculates the day of week.
        /// </summary>
        /// <param name="date">The date parameter stores the date entered by user.</param>
        /// <param name="month">The month parameter stores the month entered by user.</param>
        /// <param name="year">The year parameter stores the year entered by user.</param>
        /// <returns>returns array which represents calendar of month</returns>
        public int CalculateDayOfWeek(int date, int month, int year)
        {
            // creating variables for storing the values of year,month,and starting day of month
            int years, months, temp, day;

            // finding the starting day of given month
            years = year - (14 - month) / 12;
            temp = years + years / 4 - years / 100 + years / 400;
            months = month + 12 * ((14 - month) / 12) - 2;
            day = (date + temp + 31 * months / 12) % 7;

            // returning the first day of given month
            return day;
        }

        /// <summary>
        /// GenerateCalendar method is used to generate the calendar for user entered month.
        /// </summary>
        /// <param name="day">The day variable holds the starting day of month.</param>
        /// <param name="month">The month variable holds user entered month.</param>
        /// <param name="year">The year variable holds user entered year.</param>
        /// <returns>this method returns the 2d array which represents the calendar of month</returns>
        public int[,] GenerateCalendar(int day, int month, int year)
        {
            // creating array to store calendar of month
            int[,] calendarArray = new int[6, 7];

            // starting row from 0
            int row = 0;

            // column variable is used to indicate the column in each row
            // start column from day value
            int column = day;

            // date variable is used to indicate date in month
            int date = 1;

            // repetes the loop till 6 rows bcz each month in calendar having 6 rows
            while (row < 6)
            {
                // second while loop repetes till coulumn counter becomes 7 and all dates in given month are stored in array
                while (column < 7 && date <= this.Dates[month])
                {
                    // store date in calendar array
                    calendarArray[row, column] = date;

                    // incremenet date counter
                    date++;

                    // increment column counter to go next day in month
                    column++;
                }

                // if column counter becomes 7 it goes to next row so again start column from 0
                column = 0;

                // if column counter become 7 then row must increment
                row++;

                // check whether date is greater than dates in given month
                if (date > this.Dates[month])
                {
                    // repeate the loop till 7'th column
                    while (column < 7)
                    {
                        // add 0's to remeaning places in array
                        calendarArray[row, column] = '\0';
                        column++;
                    }

                    // if column counter becomes 7 it goes to next row so again start column from 0
                    column = 0;

                    // increment row counter
                    row++;
                }
            }

            // return the calendarArray which represents calendar of month
            return calendarArray;
        }

        /// <summary>
        /// Factorial method calculates the factorials of specified number.
        /// </summary>
        /// <param name="number">The number variable holds number which factorial we want to find.</param>
        /// <returns>returns the factorial of given number</returns>
        public int Factorial(int number)
        {
            // check whether the user given number is 0 or not if yes then return 1
            if (number == 0)
            {
                return 1;
            }           
            else
            {
                // returns the factorial of given number
                return number * this.Factorial(number - 1);
            }
        }

        /// <summary>
        ///  this method calculates the total number of ways to create BST.
        /// </summary>
        /// <param name="userNumber">The user number variable holds user entered number.</param>
        /// <returns>returns the count of total wats to create binary search tree</returns>
        public int NumberOfwaysforBST(int userNumber)
        {
            // calculate the Number of ways to create binary search tree
            return this.Factorial(2 * userNumber) / (this.Factorial(userNumber + 1) * this.Factorial(userNumber));
        }

        /// <summary>
        /// class Node is used to create a new node in linked list
        /// </summary>
        public class Node
        {
            /// <summary>
            /// The data variable holds value for node
            /// </summary>
            public string data;

            /// <summary>
            /// The next is used to point the next node in list
            /// </summary>
            public Node next;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            /// <param name="dataForNode">The data for node.</param>
            public Node(string dataForNode)
            {
                this.data = dataForNode;
                this.next = null;
            }
        }
    }
}
