using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWIthStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            FunWithStringBuilder();
            StringInterpolation();
        }

        private static void StringInterpolation()
        {
            // local variabls we will plug into our larger string
            int age = 12;
            string name = "Jason";
            //using curling bracket syntax
            string greetings = string.Format("Hello {0}! You are {1} years old this month", name, age);
            Console.WriteLine(greetings);
            
            //using string interpolation
            string greetings1 = $"Hello {name.ToLower()} You will soon be {age} years old";
            string greetings2 = $"My name is {name.ToLower()}"; 

            Console.WriteLine(greetings1);
            Console.WriteLine(greetings2);
        }

        private static void FunWithStringBuilder()
        {
            Console.WriteLine("=> using the string builder");
            StringBuilder sb = new StringBuilder("****** Fantastic Games *******");
            sb.Append("\n");
            sb.AppendLine("New Life");
            sb.AppendLine("Paradise to come");
            sb.AppendLine("Good Health" + " Peace");
            sb.AppendLine("That is wonderful!");
            Console.WriteLine(sb.ToString());
            sb.Replace("Paradise", "New World");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} character",sb.Length);
            Console.WriteLine();




        }

        private static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic string functionality");
            string firstName = "Osazee";
            Console.WriteLine("My First Name is: {0}",firstName);
            Console.WriteLine("{0} has {1} character",firstName,firstName.Length);
            Console.WriteLine("{0} to Upper Case is {1}",firstName,firstName.ToUpper());
            Console.WriteLine("{0} to Lower Case is {1}", firstName, firstName.ToLower());
            Console.WriteLine("Does {0} contain z {1}",firstName,firstName.Contains('z'));
            Console.WriteLine("First name after replace: \"{0} \"\n",firstName.Replace("e","Isere"));//inserting
            //" and new line with \" and \n commands
            Console.WriteLine("My Full name is {0} ", firstName.Insert(0,"Isere "));
            Console.WriteLine("Every one loves\"Hello World\"\a"); //triggers a system alert(beep)
            Console.WriteLine("C:\\Users\\Osazee\\source\\repos\\FunWIthStrings\\FunWIthStrings\\bin\\Debug\a");
            Console.WriteLine("\n\n\n\a");
            Console.WriteLine(@"C:\Users\Osazee\source\repos\FunWIthStrings\FunWIthStrings\"); //preceding a string
            //with @ symbol prints it verbatim
            //verbatim helps to also preserve white space and double quote
            string longString = @"This is very 
                         very 
                              very
                                 ""long string""";
            Console.WriteLine(longString);
            string s1 = "Osazee";
            string s2 = "OsaZeE";
            Console.WriteLine("compare{0} with {1} ignoring case is{2}",s1,s2,s1.Equals(s2,StringComparison.CurrentCulture));
            Console.WriteLine("compare{0} with {1} ignoring case is{2}", s1, s2, s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("compare{0} with {1} ignoring case is{2}", s1, s2, s1.Equals(s2, StringComparison.InvariantCulture));
            Console.WriteLine("compare{0} with {1} ignoring case is{2}", s1, s2, s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("compare{0} with {1} ignoring case is{2}", s1, s2, s1.Equals(s2, StringComparison.Ordinal));
            Console.WriteLine("compare{0} with {1} ignoring case is{2}", s1, s2, s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
           

        }
    }
}
