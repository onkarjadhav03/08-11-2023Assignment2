using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use the TryParse method to convert a string to an integer.
            //If the conversion is successful, print the converted integer; otherwise, display an error message.

            string str;
            int a;
            bool res;

            Console.WriteLine("enter string value");
            str= Console.ReadLine();
            res = int.TryParse(str, out a);

            if (res)
            {
                Console.WriteLine("Stored value is:"+a);
                Console.WriteLine("datatype is:"+a.GetType());

            }
            else
            {
                Console.WriteLine("error!!");
            }

            //Use the Convert method to convert a string to a double.Handle any exceptions that may occur
            //during the conversion and print an appropriate error message.

            string str1;
            double num1;
           
            try
            {
                Console.WriteLine("enter string value");
                str1 = Console.ReadLine();
                num1 = Convert.ToDouble(str1);
                Console.WriteLine("Stored value is:" + num1);
                Console.WriteLine("datatype is:" + num1.GetType());
            }
            catch   (Exception e)
            {
                Console.WriteLine("Error!!"+e.Message);
            }


            //Use the Parse method to convert a string to a decimal.Handle any exceptions 
            //that may occur during the conversion and print an appropriate error message.

            string str2;
            decimal d;

          

            try
            {
                Console.WriteLine("enter string value");
                str2 = Console.ReadLine();
                d = decimal.Parse(str2);

                Console.WriteLine("Stored value is:" + d);
                Console.WriteLine("datatype is:" + d.GetType());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!" + e.Message);
            }


            //Convert a string to an integer using the TryParse method.
            //    If the conversion is successful, multiply the resulting integer by 5 and
            //    print the final value; otherwise, display an error message.

            string str3;
            int b;
            bool ans;

            Console.WriteLine("enter string value");
            str3 = Console.ReadLine();
            ans = int.TryParse(str3, out b);


            if (ans)
            {
                Console.WriteLine("resulting integer after multiplying by 5:\t"+(b*5));
                Console.WriteLine("datatype:"+ b.GetType());

            }
            else
            {
                Console.WriteLine("error!!");
            }

            //  Convert a string to a DateTime object using the Convert method.
            //    Handle any exceptions that may occur during the conversion and
            //print an appropriate error message.Then, subtract 1 month from the obtained DateTime object and display the result.


            string str4;
            DateTime doj;

           


            try
            {
                Console.WriteLine("enter date value");
                str4 = Console.ReadLine();
                DateTime date = Convert.ToDateTime(str4);
                Console.WriteLine("Original Date: " + date);

                // Subtract 1 month from the obtained DateTime
                date = date.AddMonths(-1);
                Console.WriteLine("Date with 1 month subtracted: " + date);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


            //Convert a string to a TimeSpan object using the Parse method.
            //Handle any exceptions that may occur during the conversion and print an appropriate error message.
            //    Then, add 2 hours to the obtained TimeSpan object and display the result.
            try
            {
               
                string inputString = "12:30:45";

            
                TimeSpan timeSpan = TimeSpan.Parse(inputString);

                timeSpan = timeSpan.Add(TimeSpan.FromHours(2));

                Console.WriteLine("Original TimeSpan: " + timeSpan.Subtract(TimeSpan.FromHours(2)));
                Console.WriteLine("TimeSpan after adding 2 hours: " + timeSpan);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
