// ******************************************************************************
//  <copyright file="AddressBookUtility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution:  AddressBookUtility.cs
//  
//     Purpose: contains all methods for performning operation in address book
//     @author  Pranali Patil
//     @version 1.0
//     @since   22-11-2019
//  </copyright>
//  <creator name="Pranali Patil"/>
// ******************************************************************************/
namespace ObjectOrientedPrograms.AddressBook
{
    // Including the requried assemblies in to the program
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// AddressBookUtility class contains all methods for performing operation in address book
    /// </summary>
    public class AddressBookUtility
    {
        /// <summary>
        ///  storing JSON file path
        /// </summary>
        private static string jsonFilePath = @"C:\Users\User\source\repos\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook\AddressBook.json";

        /// <summary>
        /// creating list which is used to store data from file
        /// </summary>
        private static List<BookData> newPerson = new List<BookData>();

        /// <summary>
        /// creating RegexUtility class object
        /// </summary>
        private readonly RegExUtility regExUtility = new RegExUtility();

        /// <summary>
        /// this method is used to displays the address book entries.
        /// </summary>
        public void DisplayAddressBookEntries()
        {
            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonFilePath);

            // storing data from json file into jsonFileData variable
            string jsonFileData = streamReader.ReadToEnd();

            // converting json file data into json object
            newPerson = JsonConvert.DeserializeObject<List<BookData>>(jsonFileData);

            // iterate loop for each object in json file
            foreach (var entry in newPerson)
            {
                // priniting data from json file
                Console.Write("Name: " + entry.FullName + "\nAddress: " + entry.Address + "\nCity : " + entry.City + "\nState: " + entry.State + "\nZip Code: " + entry.Zip + "\nContact number: " + entry.Phone + "\n\n");
            }

            streamReader.Close();
        }

        /// <summary>
        ///  GetPersonInfo method is used to get the person information stored in file.
        /// </summary>
        public void GetPersonInfo()
        {
            // reading person information 
            Console.WriteLine("Enter Full Name: ");
            string newFullName = Convert.ToString(Console.ReadLine());

            // check user enter name is in correct format
            if (this.regExUtility.IsFullName(newFullName))
            {
                // check whether the person entry is already exist in address  book and storing the result in result 
                BookData result = this.Find(newFullName);

                // if result holds null value that means the person entry is not exist in address book
                if (result != null)
                {
                    // if the person name is already exist in address book then return to menu
                    throw new Exception("\n Person entry is Already Exist in address book..!\n");
                }
                else
                {
                    // if result holds null value that means the person entry is not exist in address book
                    Console.WriteLine("Enter Address : ");
                    string newAddress = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter city : ");
                    string newCity = Convert.ToString(Console.ReadLine());

                    // check city name is valid or not
                    if (this.regExUtility.IsCityName(newCity))
                    {
                        Console.WriteLine("Enter State : ");
                        string newState = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Zip Code: ");
                        string newZip = Convert.ToString(Console.ReadLine());

                        // check zip code is number or not
                        if (this.regExUtility.IsNumber(newZip))
                        {
                            Console.WriteLine("Enter Contact Number: ");
                            string newContactNumber = Convert.ToString(Console.ReadLine());

                            // check contact number is valid or not
                            if (this.regExUtility.IsContactNumber(newContactNumber))
                            {
                                // passing the person information to AddToAddressBook method
                                 this.AddToAddressBook(newFullName, newAddress, newCity, newState, newZip, newContactNumber);
                            }
                            else
                            {
                                throw new Exception("contact number is Invalid");
                            }
                        }
                        else
                        {
                            throw new Exception("Zip code is Invalid");
                        }
                    }
                    else
                    {
                        throw new Exception("City name is Invalid");
                    }
                }
            }
            else
            {
                throw new Exception("Name is Invalid");
            }
        }

        /// <summary>
        /// AddToAddressBook method is used to add the person entry into address book.
        /// </summary>
        /// <param name="newfullName">new fullName parameter holds person Name.</param>
        /// <param name="newAddress">newAddress parameter holds person address.</param>
        /// <param name="newCity">newCity parameter holds person city name.</param>
        /// <param name="newState">newState parameter holds person state name.</param>
        /// <param name="newZip">newZip parameter holds person zip code.</param>
        /// <param name="newContactNumber">newContactNumber parameter holds person contact number.</param>
        public void AddToAddressBook(string newfullName, string newAddress, string newCity, string newState, string newZip, string newContactNumber)
        {
            // creating BookData class object
            BookData personInfoObj = new BookData()
            {
                // assigning all user entered values to bookdata class object 
                FullName = newfullName,
                Address = newAddress,
                City = newCity,
                State = newState,
                Zip = newZip,
                Phone = newContactNumber
            };

            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonFilePath);

            // storing data from json file into jsonFileData variable
            string jsonFileData = streamReader.ReadToEnd();

            // converting json file data into json object
            newPerson = JsonConvert.DeserializeObject<List<BookData>>(jsonFileData);

            // adding person information into list
            newPerson.Add(personInfoObj);

            // converting jsonobject data into string
            var convertedJson = JsonConvert.SerializeObject(newPerson);

            // closing the streamReader class object
            streamReader.Close();

            // writing all updated data into json file
            File.WriteAllText(jsonFilePath, convertedJson);

            throw new Exception("\nEntry Added Successfully into Address Book");
        }

        /// <summary>
        /// Find method is used to finds the user entered name from file.
        /// </summary>
        /// <param name="nameToFind">parameter holds the name tobe find.</param>
        /// <returns>this method returns the list contains person info if user entered name was found</returns>
        public BookData Find(string nameToFind)
        {
            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonFilePath);

            // storing data from json file into jsonFileData variable
            string jsonFileData = streamReader.ReadToEnd();

            // converting json file data into json object
            newPerson = JsonConvert.DeserializeObject<List<BookData>>(jsonFileData);

            // creating BookData class object to store result 
            BookData result = null;

            // iterate loop for each person entry in address book
            foreach (var entry in newPerson)
            {
                // check whether the user entered name is equals to name in address book
                if (nameToFind.Equals(entry.FullName))
                {
                    // if name was found then close the streamreader class object
                    streamReader.Close();

                    // return the person entry in address book indicating the person is already exist in address book
                    return entry;
                }
            }

            // if name was not found then close the streamreader class object 
            streamReader.Close();

            // return the result object indicating the person is not exist in address book
            return result;
        }

        /// <summary>
        /// UpdateEntry method is used to Update the person data in address book.
        /// </summary>
        public void UpdateEntry()
        {
            // reading person information 
            Console.WriteLine("Enter Full Name: ");
            string newFullName = Convert.ToString(Console.ReadLine());

            // check user enter name is in correct format
            if (this.regExUtility.IsFullName(newFullName))
            {
                // check whether the person entry is already exist in address  book and storing the result in result 
                BookData result = this.Find(newFullName);

                // if result does not holds null value that means the person entry is found in address book
                if (result != null)
                {
                    // updating information of person by person choice
                    this.GetChoice(result);

                    // return message indicating opeartion is done or not
                    Console.WriteLine("\nEntry updated Successfully into Address Book");
                }
                else
                {
                    // if result holds null value that means the person entry is not exist in address book
                    throw new Exception("\n entry not found in address book");
                }
            }
            else
            {
                throw new Exception("Name is Invalid");
            }
        }

        /// <summary>
        /// Remove method is used to remove Remove person entry from address book.
        /// </summary>
        public void Remove()
        {
            // reading user name to know which person want to delete their entry from address book
            Console.Write("\nEnter Name you want to remove from address book: ");
            string nameToRemove = Convert.ToString(Console.ReadLine());

            // check user enter name is in correct format
            if (this.regExUtility.IsFullName(nameToRemove))
            {
                // finding the user entered name in address book
                BookData entryToRemove = this.Find(nameToRemove);

                // is entryToRemove object holds some value that means the person entry is found in address book
                if (entryToRemove != null)
                {
                    // removing person entry from address book
                    newPerson.Remove(entryToRemove);

                    // converting jsonobject data into string
                    var convertedJson = JsonConvert.SerializeObject(newPerson);

                    // writing updated data in json file
                    File.WriteAllText(jsonFilePath, convertedJson);
                    Console.WriteLine("Entry is Removed");
                }
                else
                {
                    // if person name is not found in address book return to menu
                  Console.WriteLine("Entry not found");
                }
            }
            else
            {
                throw new Exception("Name is Invalid");
            }
        }

        /// <summary>
        /// getChoice method is used to Get the person choice for updating information.
        /// </summary>
        /// <param name="result">The result parameter holds the object in file of person which wants to update his/her information.</param>
        public void GetChoice(BookData result)
        { // choice variable is used to store user choice to perform operation
            int choice;

            // flag is used to indicate whether user entered correct choice or not
            bool flag = false;

            // loop iterates untill user enter correct choice
            while (flag == false)
            {
                // perform operations till user wants to exit
                do
                {
                    // takes choice from user
                    Console.WriteLine("\n 1.Update Name \n 2.update address \n 3.update city name\n 4.update state name\n 5.update zip code\n 6.update contact number\n 7.Exit");
                    Console.WriteLine("\n Enter your choice for updating info:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    // update information acording to user choice
                    switch (choice)
                    {
                        case 1:
                            // if user wants to update his/her name
                            this.UpdateName(result);

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 2:
                            // if user wants to update his/her address
                            this.UpdateAddress(result);

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 3:
                            // if user wants to update his/her city name
                            this.UpdateCity(result);

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 4:
                            // if user wants to update his/her state name
                            this.UpdateState(result);

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 5:
                            // if user wants to update his/her zip code
                            this.UpdateZipCode(result);

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 6:
                            // if user wants to update his/her Contact number
                            this.UpdateContactNumber(result);

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        case 7:
                            // if user wants to update his/her exit

                            // make flag true to indicate user enter correct choice
                            flag = true;
                            break;
                        default:
                            // if user entered wrong value
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                }
                while (choice != 7);
            }
        }

        /// <summary>
        /// UpdateName method is used to Update the person name.
        /// </summary>
        /// <param name="result">The result parameter holds the person data object from file.</param>
        public void UpdateName(BookData result)
        {
            Console.WriteLine("Enter Full Name: ");
            string newFullName = Convert.ToString(Console.ReadLine());
            result.FullName = newFullName;

            // check name is valid or not
            if (this.regExUtility.IsFullName(newFullName))
            {
                // creating StreamReader class object to read data from json file
                StreamReader streamReader = new StreamReader(jsonFilePath);

                // storing data from json file into jsonFileData variable
                string jsonFileData = streamReader.ReadToEnd();

                // converting jsonobject data into string
                var convertedJson = JsonConvert.SerializeObject(newPerson);

                // closing the streamReader class object
                streamReader.Close();

                // writing all updated data into json file
                File.WriteAllText(jsonFilePath, convertedJson);

                Console.WriteLine("\n Name updated Successfully into Address Book");
            }
            else
            {
                throw new Exception("\n Name is Invalid");
            }
        }

        /// <summary>
        /// UpdateAddress method is used to Update the person address
        /// </summary>
        /// <param name="result">The result.</param>
        public void UpdateAddress(BookData result)
        {
            Console.WriteLine("Enter new Address : ");
            string newAddress = Convert.ToString(Console.ReadLine());
            result.Address = newAddress;

            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonFilePath);

            // storing data from json file into jsonFileData variable
            string jsonFileData = streamReader.ReadToEnd();

            // converting jsonobject data into string
            var convertedJson = JsonConvert.SerializeObject(newPerson);

            // closing the streamReader class object
            streamReader.Close();

            // writing all updated data into json file
            File.WriteAllText(jsonFilePath, convertedJson);

          Console.WriteLine("\n Address updated Successfully into Address Book");
        }

        /// <summary>
        /// UpdateCity method is used to Update the person city name.
        /// </summary>
        /// <param name="result">The result parameter holds the person data object from file.</param>
        public void UpdateCity(BookData result)
        {
            Console.WriteLine("Enter new City Name: ");
            string newCityName = Convert.ToString(Console.ReadLine());
            result.City = newCityName;

            // check name is valid or not
            if (this.regExUtility.IsCityName(newCityName))
            {
                // creating StreamReader class object to read data from json file
                StreamReader streamReader = new StreamReader(jsonFilePath);

                // storing data from json file into jsonFileData variable
                string jsonFileData = streamReader.ReadToEnd();

                // converting jsonobject data into string
                var convertedJson = JsonConvert.SerializeObject(newPerson);

                // closing the streamReader class object
                streamReader.Close();

                // writing all updated data into json file
                File.WriteAllText(jsonFilePath, convertedJson);
                Console.WriteLine("\n City Name updated Successfully into Address Book");            
            }
            else
            {
               throw new Exception("City Name is Invalid");
            }
        }

        /// <summary>
        /// UpdateState method is used to Update the person state name.
        /// </summary>
        /// <param name="result">The result parameter holds the person data object from file.</param>
        public void UpdateState(BookData result)
        {
            Console.WriteLine("Enter new State name : ");
            string newStateName = Convert.ToString(Console.ReadLine());
            result.State = newStateName;

            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonFilePath);

            // storing data from json file into jsonFileData variable
            string jsonFileData = streamReader.ReadToEnd();

            // converting jsonobject data into string
            var convertedJson = JsonConvert.SerializeObject(newPerson);

            // closing the streamReader class object
            streamReader.Close();

            // writing all updated data into json file
            File.WriteAllText(jsonFilePath, convertedJson);

            Console.WriteLine("\n State Name updated Successfully into Address Book");
        }

        /// <summary>
        ///  this  method is used to Update the person Zip code
        /// </summary>
        /// <param name="result">The result parameter holds the person data object from file.</param>
        public void UpdateZipCode(BookData result)
        {
            Console.WriteLine("Enter new Zip Code : ");
            string newZipCode = Convert.ToString(Console.ReadLine());
            result.Zip = newZipCode;

            // check name is valid or not
            if (this.regExUtility.IsNumber(newZipCode))
            {
                // creating StreamReader class object to read data from json file
                StreamReader streamReader = new StreamReader(jsonFilePath);

                // storing data from json file into jsonFileData variable
                string jsonFileData = streamReader.ReadToEnd();

                // converting jsonobject data into string
                var convertedJson = JsonConvert.SerializeObject(newPerson);

                // closing the streamReader class object
                streamReader.Close();

                // writing all updated data into json file
                File.WriteAllText(jsonFilePath, convertedJson);
                Console.WriteLine("\n Zip Code updated Successfully into Address Book");
            }
            else
            {
                throw new Exception("zip code is Invalid");
            }
        }

        /// <summary>
        ///  this method is used to Update the person contact number
        /// </summary>
        /// <param name="result">The result parameter holds the person data object from file.</param>
        public void UpdateContactNumber(BookData result)
        {
            Console.WriteLine("Enter new Contact Number: ");
            string newContactNumber = Convert.ToString(Console.ReadLine());
            result.Phone = newContactNumber;

            // check name is valid or not
            if (this.regExUtility.IsFullName(newContactNumber))
            {
                // creating StreamReader class object to read data from json file
                StreamReader streamReader = new StreamReader(jsonFilePath);

                // storing data from json file into jsonFileData variable
                string jsonFileData = streamReader.ReadToEnd();

                // converting jsonobject data into string
                var convertedJson = JsonConvert.SerializeObject(newPerson);

                // closing the streamReader class object
                streamReader.Close();

                // writing all updated data into json file
                File.WriteAllText(jsonFilePath, convertedJson);
                Console.WriteLine("\n Contact Number updated Successfully into Address Book");
            }
            else
            {
                throw new Exception("Contact number is Invalid");
            }
        }

        /// <summary>
        /// this method is used to sorts the book entry by zip.
        /// </summary>
        public void SortByZip()
        {
            List<BookData> newlistbyzip = new List<BookData>();

            // creating StreamReader class object to read data from json file
            StreamReader streamReader = new StreamReader(jsonFilePath);

            // storing data from json file into jsonFileData variable
            string jsonFileData = streamReader.ReadToEnd();

            // converting json file data into json object
            newPerson = JsonConvert.DeserializeObject<List<BookData>>(jsonFileData);
            int count = newPerson.Capacity;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (Convert.ToInt32(newPerson[i].Zip) > Convert.ToInt32(newPerson[j].Zip))
                    {
                        newlistbyzip.Add(newPerson[j]);
                        break;
                    }

                    newlistbyzip.Add(newPerson[i]);
                }
            }

            // converting object data into text formated data
            var convertedJson = JsonConvert.SerializeObject(newlistbyzip);

            // closing the streamReader class object
            streamReader.Close();

            // writing all updated data into json file
            File.WriteAllText(jsonFilePath, convertedJson);

            // if name was not found then close the streamreader class object 
            streamReader.Close();

            Console.WriteLine("\n Data is Sorted by Zip Code");
        }
    }
}
