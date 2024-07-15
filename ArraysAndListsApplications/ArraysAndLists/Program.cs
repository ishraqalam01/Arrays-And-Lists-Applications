//Name: Ishraq Alam
//Date: April 11, 2024
//Title: A6IshraqAlam
//Purpose: To create 4 applications using arrays. 
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A6IshraqAlam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu 
            string strUser;
            int intMenuChoice;

            Console.WriteLine("Welcome to Ishraq's Assignment 6 Submission. Please select a question from the menu to run."); //Background information

            while (true) // infinite loop
            {

                Console.WriteLine(" ");
                Console.WriteLine("What would you like to view? Choose from 1-4. If you wish to exit, please enter 5."); //Asks user to choose option
                Console.WriteLine("1. Random Stats Application");
                Console.WriteLine("2. Grade Information Application");
                Console.WriteLine("3. Grocery List Application");
                Console.WriteLine("4. Class List Application");
                Console.WriteLine("5. Exit");
                strUser = Console.ReadLine();
                intMenuChoice = Int32.Parse(strUser);

                if (intMenuChoice == 1) //Question 1
                {
                    Console.Clear();
                    RandomStats();
                    Console.Clear();

                }

                else if (intMenuChoice == 2) //Question 2
                {
                    Console.Clear();
                    GradesInformation();
                    Console.Clear();

                }

                else if (intMenuChoice == 3) //Question 3 
                {
                    Console.Clear();
                    GroceryList();
                    Console.Clear();
                }

                else if (intMenuChoice == 4) //Question 4 
                {
                    Console.Clear();
                    ClassList();
                    Console.Clear();
                }

                else if (intMenuChoice == 5) //Exit program
                {
                    Console.Clear();
                    break; //breaks out of loop
                }

                else //Invalid entry 
                {
                    Console.Clear();
                    Console.WriteLine("That is not an option! Please try again. ");

                }

            }



        }

        public static void RandomStats() //Question 1 method
        {
            //Title: A6Q1RandomStatsIA
            //Purpose: To ask a user for a number, then display the number of occurrences of random numbers between 0 and 9 until the user's number. 

            //Variable Declaration
            string strUser; //Yogurt container 
            int intNumberCapacity = 0; //The number the user enters 
            int intRandomNum = 0; //The random numbers produced 
            int[] intOccurrences; //Array where each location represents the random number produced. 
            string strRestartOrExit; //Represents the choice for the user to continue or exit. 
            
            
            //Input
            Console.WriteLine("Enter a number: "); //Where user enters number
            strUser = Console.ReadLine();
            intNumberCapacity = Int32.Parse(strUser);
            Random RandomClass = new Random(); //Assigns randomclass used for producing new numbers

            while (true) //Infinite loop 
            {
                int intCounter0 = 0, intCounter1 = 0, intCounter2 = 0, intCounter3 = 0, intCounter4 = 0, intCounter5 = 0, intCounter6 = 0, intCounter7 = 0, intCounter8 = 0, intCounter9 = 0; //For counting the number of times number appeared

                //Process
                if (intNumberCapacity > 0) //to check if user enters valid number above 0
                {
                    intOccurrences = new int[intNumberCapacity]; //creates array with limit set to what the user entered 

                    for (int i = 0; i < intOccurrences.Length; i++) //loop used to produce new random numbers where each number is a spot in the array 
                    {

                        intRandomNum = RandomClass.Next(0, 10); //random num from 0 to 9

                        intOccurrences[i] = intRandomNum; //sets value in locations 
                    }

                    //Loop that continues until all locations in the array are complete with a random number in it. In each if statement, respective counters are added, acting like a counter used to find how many times a random num appears in the array
                    for (int i = 0; i < intOccurrences.Length; i++)
                    {
                        if (intOccurrences[i] == 0)
                        {
                            intCounter0++;
                        }

                        else if (intOccurrences[i] == 1)
                        {
                            intCounter1++;
                        }

                        else if (intOccurrences[i] == 2)
                        {
                            intCounter2++;
                        }

                        else if (intOccurrences[i] == 3)
                        {
                            intCounter3++;
                        }

                        else if (intOccurrences[i] == 4)
                        {
                            intCounter4++;
                        }

                        else if (intOccurrences[i] == 5)
                        {
                            intCounter5++;
                        }

                        else if (intOccurrences[i] == 6)
                        {
                            intCounter6++;
                        }

                        else if (intOccurrences[i] == 7)
                        {
                            intCounter7++;
                        }

                        else if (intOccurrences[i] == 8)
                        {
                            intCounter8++;
                        }

                        else if (intOccurrences[i] == 9)
                        {
                            intCounter9++;
                        }



                    }
                    //Output

                    //Displays the results using string.format in an organized way and showing the numbers in the counters
                    Console.WriteLine("Number      Occurrences");
                    Console.Write("0");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter0));
                    Console.Write("1");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter1));
                    Console.Write("2");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter2));
                    Console.Write("3");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter3));
                    Console.Write("4");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter4));
                    Console.Write("5");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter5));
                    Console.Write("6");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter6));
                    Console.Write("7");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter7));
                    Console.Write("8");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter8));
                    Console.Write("9");
                    Console.WriteLine(String.Format("{0,13: 0}", intCounter9));

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Would you like to assign a new set of integers and try again?\n If you would like to exit, please type EXIT, then press enter twice. Type anything else to get a new set of integers!"); //Asks if user wants to continue or stop

                    strUser = Console.ReadLine();
                    strRestartOrExit = strUser;

                    if (strRestartOrExit == "EXIT") //Exits loop 
                    {

                        break;
                    }

                    else
                    {
                        Console.Clear();
                    }

                }

                else //If user enters invalid entry / negative number, restarting the method 
                {
                    Console.WriteLine("Please enter a positive number.");
                }


            }

            Console.ReadKey(); //Ends program
        }

        public static void GradesInformation() //Question 2 method 
        {
            //Title: A6Q2GradesInformationIA
            //Purpose: To ask the user to enter 5 - 15 grades, then display a menu to receieve more information about the grades they entered. 



            //Variable Declaration
            string strUser; //Yogurt container
            int intGrade; //Grade entered by the user 
            int intGradeNumberCounter = 0; //Used for displaying the number of grades the user has entered already and to check if 5 grades were entered 
            int[] intAllGrades = new int[15]; //Fixes value of array to be 15
            int[] intTempAllGrades; //Used to change value of array 
            int intLocation = 0; //Location of values in array 
            int intMenuChoice; //User's choice of what to do in menu
            double dblSum = 0; //The sum used in average calculation
            double dblAverage = 0; //Final average using grade values
            int intDeletedGrade; //The grade the user wants to get rid of 
            int[] intTempDeletedGrades; //Temporary array after deleting grade
            int intChangedGrade; //The location of the grade the user wants to change 
            int[] intTempChangedGrade; //Temporary array with changed grade
            int intNewGrade; //Grade they want to replace it with 



            //Input
            Console.WriteLine("Hello! Please enter grade values (0-100) into the program. You may enter any number of grades from 5 to 15, and stop at any time. You will then be taken to a menu with more options!"); //background info 
            Console.WriteLine(" ");
            do
            {
                intGradeNumberCounter = intLocation + 1; // 1 added to location of grade
                while (true) //Infinite loop 
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter grade number " + intGradeNumberCounter + ". If you wish to stop adding grades, please type the sentinel number, '-99'. Note: You must enter at least 5 grades to proceed."); //Asks user to enter the grade
                    strUser = Console.ReadLine();
                    intGrade = Int32.Parse(strUser);


                    if (intGrade != -99 && intGrade >= 0 && intGrade <= 100) //Not terminal number, and grade is between 0-100
                    {
                        intAllGrades[intLocation] = intGrade;
                        intLocation++;
                        break; //goes to next grade entry 
                    }

                    else if (intGrade == -99 && intGradeNumberCounter > 5) //If user enters 5 grades and enters terminal number 
                    {
                        intTempAllGrades = new int[intLocation]; //Creates new array with grades and shortens array

                        for (int j = 0; j < intTempAllGrades.Length; j++) //Copies all grades into new array 
                        {
                            intTempAllGrades[j] = intAllGrades[j];

                        }

                        intAllGrades = new int[intTempAllGrades.Length]; //Resets array to length of temporary aray 

                        for (int k = 0; k < intAllGrades.Length; k++) //Pastes copied grades into reset array 
                        {
                            intAllGrades[k] = intTempAllGrades[k];
                        }

                        break; //Exits this loop 
                    }

                    else if (intGrade == -99 && intGradeNumberCounter < 6) //If user enters terminal number but hasn't entered 5 grades 
                    {
                        Console.WriteLine("You must enter at least 5 grades!");
                    }

                    else if (intGrade < 0 || intGrade > 100 && intGrade != -99) //if user enters invalid entry outside of 0-100
                    {
                        Console.WriteLine("Your grade must be a number between 0 and 100!");
                    }

                }

                if (intGrade == -99) //Breaks out of bigger loop if terminal number entered 
                {
                    break;
                }

            } while (intLocation < intAllGrades.Length); //Condition for loop: as long as location is less than length of array ( 15 )


            //Process and Output

            while (true) //Infinite loop 
            {
                //Menu
                Console.WriteLine(" ");
                Console.WriteLine("MENU - Please select what you'd like to do or view by typing the number corresponding to each option.");
                Console.WriteLine("1. Number of Values in the Array");
                Console.WriteLine("2. List the Values in the Array");
                Console.WriteLine("3. Average of All Grades");
                Console.WriteLine("4. Delete a Specific Value");
                Console.WriteLine("5. Clear All Values in the Array");
                Console.WriteLine("6. Change a Specific Value");
                Console.WriteLine("7. Exit (Type 7, then press enter twice)");
                Console.WriteLine(" ");
                strUser = Console.ReadLine();
                intMenuChoice = Int32.Parse(strUser);


                if (intMenuChoice == 1) //Option 1 
                {
                    Console.Clear();
                    Console.WriteLine("There are " + intAllGrades.Length + " values in the array. "); //Outputs number of array values
                }

                else if (intMenuChoice == 2) //Option 2 
                {
                    Console.Clear();
                    Console.Write("Here are all of the values listed in the array: ");
                    for (int j = 0; j < intAllGrades.Length; j++) //Outputs the values of the location by using a loop 
                    {
                        if (j == intAllGrades.Length - 1) //Last number doesn't have a comma 
                        {
                            Console.Write(intAllGrades[j]); //Outputs last number

                        }

                        else
                        {
                            Console.Write(intAllGrades[j] + ","); //Other numbers have a comma after 
                        }

                    }

                    Console.WriteLine(" ");
                }

                else if (intMenuChoice == 3) //Option 3 
                {
                    Console.Clear();
                    for (int j = 0; j < intAllGrades.Length; j++) //Adds all values in the array
                    {
                        dblSum = dblSum + intAllGrades[j];
                    }

                    dblAverage = dblSum / (double)intAllGrades.Length; //Temporarily casts, and turns array length into double, divides, then finds average. 
                    dblAverage = Math.Round(dblAverage, 2); //Rounds average to 2 decimals 

                    dblSum = 0;
                    Console.WriteLine("The average of the grades you have listed to the nearest 2 decimals is: " + dblAverage);

                }

                else if (intMenuChoice == 4) //Option 4 
                {
                    Console.Clear();
                    while (true) //Infinite loop 
                    {
                        Console.WriteLine("What is the location of the grade number would you like to delete? Note: Locations are 1 less than the grade number itself. For example, the location of the first grade is 0, the second is 1, and the third is 2, etc.");
                        Console.WriteLine("Current Grades: ");

                        for (int j = 0; j < intAllGrades.Length; j++) //Shows user the grades they entered previously 
                        {
                            Console.WriteLine("Grade " + (j + 1) + ": " + intAllGrades[j]);
                        }

                        strUser = Console.ReadLine();
                        intDeletedGrade = Int32.Parse(strUser);

                        if (intDeletedGrade < intAllGrades.Length && intDeletedGrade >= 0) //If location of grade is valid 
                        {
                            intTempDeletedGrades = new int[intAllGrades.Length - 1]; //Creates temporary array for copying all grades except deleted grade

                            for (int j = 0; j < intDeletedGrade; j++) //Copies all grades until deleted grade location
                            {
                                intTempDeletedGrades[j] = intAllGrades[j];
                            }

                            for (int k = intDeletedGrade; k < intTempDeletedGrades.Length; k++) //Copies all grades after deleted grade location 
                            {
                                intTempDeletedGrades[k] = intAllGrades[k + 1];
                            }

                            intAllGrades = new int[intTempDeletedGrades.Length]; //Resets array

                            for (int l = 0; l < intAllGrades.Length; l++) //Pastes copied info into array 
                            {
                                intAllGrades[l] = intTempDeletedGrades[l];
                            }

                            Console.WriteLine("Successfully deleted!");
                            break;
                        }

                        else //If location is outside of length of array 
                        {
                            Console.WriteLine("That is not a location in the array!");
                        }

                    }

                }

                else if (intMenuChoice == 5) //Option 5 
                {
                    Console.Clear();
                    intAllGrades = new int[1]; //Sets array to 1
                    intAllGrades[0] = -1; //Sets value of array location 0 to -1

                    Console.WriteLine("Successfully cleared!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Updated Array: ");

                    for (int j = 0; j < intAllGrades.Length; j++) //Shows the updated array 
                    {
                        Console.WriteLine("Grade " + (j + 1) + ": " + intAllGrades[j]);
                    }


                }

                else if (intMenuChoice == 6) //Option 6 
                {
                    Console.Clear();
                    while (true) //Infinite loop 
                    {
                        while (true) //Infinite nested loop 
                        {
                            Console.WriteLine("What is the location of the grade you would like to change? Note: Locations are 1 less than the grade number itself. For example, the location of the first grade is 0, the second is 1, and the third is 2, etc.");
                            strUser = Console.ReadLine();
                            intChangedGrade = Int32.Parse(strUser); //Location of changed value 


                            if (intChangedGrade < intAllGrades.Length && intChangedGrade >= 0) //If location is within array boundary 
                            {
                                Console.WriteLine("What grade would you liked to replace it with? Please enter a value between 0 and 100. ");
                                strUser = Console.ReadLine();
                                intNewGrade = Int32.Parse(strUser); //Value of new grade 

                                break; //breaks out of loop 
                            }

                            else //invalid entry that asks them again 
                            {
                                Console.WriteLine("That location does not exist in the array. Please try again.");
                                Console.WriteLine(" ");
                            }


                        }



                        if (intChangedGrade < intAllGrades.Length && intChangedGrade >= 0 && intNewGrade >= 0 && intNewGrade <= 100) //if new grade is valid 
                        {

                            intTempChangedGrade = new int[intAllGrades.Length]; //Creates temporary array 

                            for (int j = 0; j < intChangedGrade; j++) //Copies all values into temporary array 
                            {
                                intTempChangedGrade[j] = intAllGrades[j];
                            }

                            for (int k = intChangedGrade; k == intChangedGrade; k++) //Changes value of array location user entered in temp array 
                            {
                                intTempChangedGrade[k] = intNewGrade;
                            }

                            for (int l = intChangedGrade + 1; l < intTempChangedGrade.Length; l++) //Copies values after changed location 
                            {
                                intTempChangedGrade[l] = intAllGrades[l];
                            }

                            intAllGrades = new int[intTempChangedGrade.Length]; //Resets array 

                            for (int m = 0; m < intAllGrades.Length; m++) //Pastes new values into reset array 
                            {
                                intAllGrades[m] = intTempChangedGrade[m];
                            }

                            Console.WriteLine("Successfully updated!");
                            Console.WriteLine(" ");
                            break; //escapes loop 

                        }

                        else //if input exceeds boundary 
                        {
                            Console.WriteLine("That is an invalid entry. Please try again!");
                        }


                    }




                }

                else if (intMenuChoice == 7) //Option 7
                {
                    break; //Exits method 
                }

                else //Invalid entry, restarts loop and asks again 
                {
                    Console.Clear();
                    Console.WriteLine("That is an invalid option. Please choose an option from the menu. ");
                }



            }




            Console.ReadKey(); //Ends program 




        }











        public static void GroceryList() //Question 3 method 
        {
            //Title: A6Q3GroceryListIA
            //Purpose: To keep track of the user's grocery list. It asks the user for the number of items they'd like to purchase, then for them to input those items. They will have the option to view, add, change, and delete items. 


            //Variable Declaration
            string strUser; //Yogurt container 
            int intItemDisplay; //Used for displaying and showing item number
            int intNumberOfItems; //Number of items user wants in their list 
            string[] strItems; //Array for storing items in the grocery list 
            string strIndividualItem; //Stores item names in array 
            int intDecision; //What user wants to do in menu with array 
            string[] strTemp; //Temporary array for adding item
            string strNewItem; //User enters new item name 
            int intDeleteLocation; //The location of what user wants to delete 
            string[] strDeleteTemp; //Array used for storing information when deleting item 
            int intChangeLocation; //Location of what user wants to change 
            string strChangedItem; //What user wants to replace with


            //Input
            Console.WriteLine("How many items would you like your grocery list to include?");
            strUser = Console.ReadLine();
            intNumberOfItems = Int32.Parse(strUser);

            strItems = new string[intNumberOfItems]; //Array setting location with number of items user entered 

            for (int i = 0; i < strItems.Length; i++)
            {
                intItemDisplay = i + 1; //Adds 1 to make convenient for user 
                Console.WriteLine("Please enter item number " + intItemDisplay);
                strUser = Console.ReadLine();
                strIndividualItem = strUser;
                strItems[i] = strIndividualItem; //Sets value of each location in array with item user entered 
            }

            //Process and Output
            while (true) //Infinite loop 
            {

                Console.ForegroundColor = ConsoleColor.Magenta; //Menu in magenta 
                Console.WriteLine("What would you like to do with your grocery list? Please choose the number corresponding to your choice. ");
                Console.WriteLine("1. View items");
                Console.WriteLine("2. Add item");
                Console.WriteLine("3. Delete item");
                Console.WriteLine("4. Change item");
                Console.WriteLine("5. Exit grocery list");
                Console.ForegroundColor = ConsoleColor.White;

                strUser = Console.ReadLine();
                intDecision = Int32.Parse(strUser);

                if (intDecision == 1) //Option 1 
                {
                    Console.Clear();
                    for (int i = 0; i < strItems.Length; i++) //Displays items by going through each location in loop 
                    {
                        intItemDisplay = i + 1;
                        Console.WriteLine("Item " + intItemDisplay + ":" + strItems[i]);
                    }
                    Console.WriteLine(" ");
                }

                else if (intDecision == 2) //Option 2 
                {
                    Console.Clear();
                    strTemp = new string[strItems.Length + 1]; //new array for adding 

                    for (int i = 0; i < strItems.Length; i++) //Copies information into temp array 
                    {
                        strTemp[i] = strItems[i];
                    }

                    Console.WriteLine("What item would you like to add?");
                    strUser = Console.ReadLine();
                    strNewItem = strUser;

                    strTemp[strTemp.Length - 1] = strNewItem; //Adds new item to the last location 

                    strItems = new string[strTemp.Length]; //resets array 

                    for (int i = 0; i < strItems.Length; i++) //pastes items and new item into old array 
                    {
                        strItems[i] = strTemp[i];

                    }

                    Console.WriteLine("Succesfully added!");
                    Console.WriteLine(" ");
                }

                else if (intDecision == 3) //option 3 
                {
                    Console.Clear();
                    while (true) //Infinite loop 
                    {

                        Console.WriteLine("What item would you like to delete from your grocery list? Please enter the index location value. (Note: Item 1 location is 0, Item 2 location is 1, etc.)");
                        strUser = Console.ReadLine();
                        intDeleteLocation = Int32.Parse(strUser);

                        if (intDeleteLocation < strItems.Length && intDeleteLocation >= 0) //If location of deleted item is within boundaries of array and above 0 
                        {
                            strDeleteTemp = new string[strItems.Length - 1]; //Creates new array with length 1 less than current array 

                            for (int i = 0; i < intDeleteLocation; i++) //Copies information into new array until deleted location 
                            {
                                strDeleteTemp[i] = strItems[i];
                            }

                            for (int i = intDeleteLocation; i < strDeleteTemp.Length; i++) //Copies information after deleted location
                            {
                                strDeleteTemp[i] = strItems[i + 1];
                            }

                            strItems = new string[strItems.Length - 1]; //Resets array 
                            for (int i = 0; i < strItems.Length; i++) //Pastes items into array 
                            {
                                strItems[i] = strDeleteTemp[i];
                            }

                            Console.WriteLine("Succesfully deleted!");
                            Console.WriteLine(" ");
                            break;

                        }

                        else //Invalid entry 
                        {
                            Console.WriteLine("That location is outside of the boundaries. Please try again.");
                            Console.WriteLine(" ");
                        }

                    }


                }

                else if (intDecision == 4) //Option 4 
                {
                    Console.Clear();
                    while (true) //Infinite loop 
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Which item would you like to change in your grocery list? Please enter the index location value. (Note: Item 1 location is 0, Item 2 location is 1, etc.)");
                        strUser = Console.ReadLine();
                        intChangeLocation = Int32.Parse(strUser);

                        if (intChangeLocation < strItems.Length && intChangeLocation >= 0) //If the change location is valid and above or equal to 0 
                        {
                            Console.WriteLine("What would you like to replace the item with?");
                            strUser = Console.ReadLine();
                            strChangedItem = strUser;
                            strItems[intChangeLocation] = strChangedItem; //Replaces changed location with new item 

                            Console.WriteLine("Successfully changed to " + strChangedItem);
                            Console.WriteLine(" ");
                            break;
                        }

                        else //Invalid location 
                        {
                            Console.WriteLine("That location is outside of the boundary!");
                            Console.WriteLine(" ");
                        }


                    }




                }

                else if (intDecision == 5) //Exits method 
                {

                    break;
                }

                else //Invalid entry 
                {

                    Console.WriteLine("Please choose one of the available options.");
                    Console.WriteLine(" ");
                }

            }

            Console.ReadKey(); //Ends program

        }

        public static void ClassList() //Question 4 method 
        {
            //Title: A6Q4ClassListIA
            //Purpose: To manage a class list of names. The user will be able to add, delete, and reset the list. 

            //Variable Declaration
            string strUser; //Yogurt container 
            string[] strClassList = new string[1]; //New array with value of 1 
            strClassList[0] = "StudentName"; //Sets value of array to studentname
            int intDecision; //User's option in menu 
            int intStudentCounter; //Counts number of students 
            string[] strTempAddedStudent; //Temporary array for adding students 
            string strNewStudent; //Name of new student added
            string[] strTempDeletedStudent; //Temporary array for deleting students 
            int intDeletedStudent; //Location of removed student 




            //Input
            while (true) //Infinite loop 
            {
                Console.WriteLine("What would you like to do? Please enter the number corresponding to your decision."); //Menu 
                Console.WriteLine("1. View Current Class List");
                Console.WriteLine("2. Add New Student");
                Console.WriteLine("3. Delete Student Name");
                Console.WriteLine("4. Reset Class List");
                Console.WriteLine("5. Exit Program");
                strUser = Console.ReadLine();
                intDecision = Int32.Parse(strUser);


                //Process and Output
                if (intDecision == 1) //Option 1 
                {
                    Console.Clear();
                    Console.WriteLine("Current Student List: ");


                    for (int i = 0; i < strClassList.Length; i++) //Outputs all values in each location of array 
                    {
                        intStudentCounter = i + 1;
                        Console.WriteLine(intStudentCounter + ". " + strClassList[i]);

                    }

                }

                else if (intDecision == 2) //Option 2 
                {
                    while (true) //Infinite loop 
                    {
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("What is the name of the student you would like to add to the list? If you changed your mind, please type -1 to return to the menu. ");
                        strUser = Console.ReadLine();
                        strNewStudent = strUser; //New student name 

                        if (strNewStudent == "-1") //Returns back to menu 
                        {
                            break;
                        }
                        else if (strClassList[0] == "StudentName") //If it is first time adding student and it says studentname, then it will update location 0 of array to new name. 
                        {
                            strClassList[0] = strNewStudent;
                            Console.WriteLine("Successfully added!");
                            break;
                        }

                        else //Any other situation 
                        {
                            strTempAddedStudent = new string[strClassList.Length + 1]; //Sets temporary array length to 1 more than what it was before 

                            for (int i = 0; i < strClassList.Length; i++) //Copies old values into temp array 
                            {
                                strTempAddedStudent[i] = strClassList[i];

                            }

                            strTempAddedStudent[strTempAddedStudent.Length - 1] = strNewStudent; //Value of last position in array is name of new student 

                            strClassList = new string[strTempAddedStudent.Length]; //Resets array 

                            for (int i = 0; i < strClassList.Length; i++) //Pastes values into old array 
                            {
                                strClassList[i] = strTempAddedStudent[i];
                            }

                            Console.WriteLine("Successfully added!");
                            break; //Exits loop 
                        }



                    }



                }

                else if (intDecision == 3) //Option 3 
                {
                    Console.Clear();
                    while (true) //Infinite loop 
                    {
                        Console.WriteLine("Which student would you like to remove? Please enter the index location (ex. Student 1 has a location of 0, Student 2 has a location of 1, Student 3 has a location of 2, etc.). If you changed your mind, please type '-1'. ");
                        strUser = Console.ReadLine();
                        intDeletedStudent = Int32.Parse(strUser); //Location of removed student 

                        if (intDeletedStudent == -1) //Returns to menu 
                        {
                            break;
                        }

                        else if (strClassList[0] == "StudentName" && strClassList.Length == 1 || strClassList.Length < 1) //If it is studentname in first location, there can't be a name to remove 
                        {
                            Console.WriteLine("There's nothing to remove!");
                            break;
                        }

                        else if (strClassList.Length < 2) //If length is below 2, can't delete a student since they can reset anyway
                        {
                            Console.WriteLine("You must have at least 2 people in your classlist to remove a student. If you wish to reset, please go back to the menu and choose the appropriate number.");
                            break;
                        }

                        else if (intDeletedStudent < 0 || intDeletedStudent > strClassList.Length) //invalid array location 
                        {
                            Console.WriteLine("That value is not a location in the array. Please try again with a location inside of the array.");

                        }

                        else
                        {
                            strTempDeletedStudent = new string[strClassList.Length - 1]; //Creates temp array 

                            for (int i = 0; i < intDeletedStudent; i++) //Copies names until deleted location into temp array 
                            {
                                strTempDeletedStudent[i] = strClassList[i];

                            }

                            for (int i = intDeletedStudent; i < strTempDeletedStudent.Length; i++) //Copies names after deleted location into temp array 
                            {

                                strTempDeletedStudent[i] = strClassList[i + 1];
                            }

                            strClassList = new string[strTempDeletedStudent.Length]; //Resets array 

                            for (int i = 0; i < strClassList.Length; i++) //Pastes names from temp array into old array 
                            {
                                strClassList[i] = strTempDeletedStudent[i];
                            }

                            Console.WriteLine("Successfully removed!");
                            break;
                        }


                    }

                }

                else if (intDecision == 4) //Option 4 
                {
                    Console.Clear();
                    strClassList = new string[1]; //Resets array 
                    strClassList[0] = "StudentName"; //Sets value to StudentName again 

                    Console.WriteLine("Successfully reset!");

                }

                else if (intDecision == 5) //Option 5 
                {
                    Console.Clear();
                    break; //Exits the menu 
                }

                else //Invalid entry 
                {
                    Console.Clear();
                    Console.WriteLine("That is not an option. Please choose a menu option from 1-5. ");
                }



            }




            Console.ReadKey(); //Ends program 
        }








    }
}














