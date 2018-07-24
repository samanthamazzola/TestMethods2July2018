using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //write a program that validates user name
            // catches if the input isn't valid input
            string userName = GetValidInput(@"^[A-Z]{1}[a-zA-Z]{0,29}$", "Please enter a valid name: ", "Sorry, name is not valid!");


            //write a program that validates email
            // catches if the input isn't valid input
            string userEmail = GetValidInput(@"^[a-zA-Z\d]{1,30}\@[a-zA-Z\d]{5,30}\.[a-z]{2,3}$", "Please enter a valid email address: ", "Sorry, email is not valid!");
            Console.WriteLine("Email " + userEmail + " is valid!");


            //write a program that validates phone number
            string phoneNumberInput = GetValidInput(@"^\d{3}\-\d{3}\-\d{4}$", "Please enter a valid phone number: ", "Sorry, phone number is not valid!");
            Console.WriteLine("Phone number is valid: " + phoneNumberInput);

            //write a program that validates date
            string dateInput = GetValidInput(@"^\d{2}\/\d{2}\/\d{4}$", "Please enter a valid date: ", "Sorry, date is not valid!"); 
            //for actual dates  ^(((0[1-9]|[12]\d|3[01])-(0[13578]|1[02])-((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)-(0[13456789]|1[012])-((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])-02-((19|[2-9]\d)\d{2}))|(29-02-((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$
        }
        //outside the main class
        public static string GetValidInput(string pattern, string userMessage, string errorMessage)
        //this method returns method based off of valid pattern input

        {
            Console.WriteLine(userMessage);
            string userInput = Console.ReadLine();


            while (!Regex.IsMatch(userInput, pattern))
            {
                Console.WriteLine(errorMessage);
                userInput = Console.ReadLine(); //loops back through original prompt until 
            }

            return userInput;
        }
    }
}

//check if the user input matches the pattern (regular expression)
// class Regex (see above the using statement for the Regex class made above)
// IsMatch (look at right click debug "quick fix"