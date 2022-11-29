using BMICalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class BMI
{
    public static List<Top> toplist;
    public static int weight;
    public static int height;
    public static int bmi;
    public static string name;
    public static void Main()
    {
        toplist = new List<Top>();
        Welcome();
       
    }
    static void Welcome()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "===== BMI Calculator ====="));
        Console.WriteLine();
        Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Press any key to continue"));
        Console.ReadKey();
        menu();
    }
    static void menu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1: Calculate BMI");
        Console.WriteLine("2: BMI Ranges");
        Console.WriteLine("3: Past Calculations");
        Console.WriteLine("4: Exit");
        Console.WriteLine();

        string usercommand = Console.ReadLine();
        if (usercommand == "1")
        {
            calc();
        }
        else if (usercommand == "2")
        {
           info();
        }
        else if (usercommand == "3")
        {
           lastTests();
        }
        else if (usercommand == "4")
        {
           exit();
        }
    }
    static void info()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Underweight = less than 18.5");
        Console.WriteLine("Normal: between 18.5 and 24.9");
        Console.WriteLine("Overweight: between 25 and 29.9");
        Console.WriteLine("Obese: 30 or greater");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to return to menu");
        Console.ReadKey();
        menu();
    }
    static void lastTests()
    {
        Console.Clear();
        Console.WriteLine("===== Last 10 Results =====");
        if (toplist.Count > 0)
        {
            foreach (Top item in toplist)
            {
                Console.WriteLine($"Name: {item.Name} - Product Price: {item.BMI}.");
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to return to menu");
        Console.ReadKey();
        menu();
    }
    static void calc()
    {
        try
        {
            var toplist = new Top();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            //Top.Name = name;
            Console.WriteLine("Please Enter your height in inches: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your weight in pounds: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            bmi = weight * 703 / (height * height);
            //toplist.Add(score);
            if (bmi < 18)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your BMI is:" + bmi);
                Console.WriteLine("oh god your all skin and bone mun, get some meat on you");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
            else if (bmi>18.5&&bmi<29.9)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your BMI is: " + bmi);
                Console.WriteLine("Your a bit overwight, get on the weight watchers i would.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
            else if (bmi > 30)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your BMI is: " + bmi);
                Console.WriteLine("Your a very overweight, go seek medical advice.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your BMI is:" + bmi); 
                Console.WriteLine("Your fine mun no need to loose any weight.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                again();
            }
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error {e.Message}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            again();
        }
    }
    private static void again()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("if you wish to rerun the program press 'y' otherwise press 'n' to return to menu.");
        string usercommand = Console.ReadLine().ToLower();
        if (usercommand == "y")
        {

            calc();

        }
        else if (usercommand == "n")
        {
            menu();
        }
    }

    private static void exit()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Thank you for using my program");
        Console.WriteLine("Find more interesting projects at my GitHub Repository: bit.ly/2YDCMYQ ");
        Console.WriteLine();
        Console.WriteLine("Program Developed by Jordan W Sparkes");
        Console.WriteLine("Program Developed using Visual Studio 2019 Community edition");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        Environment.Exit(0);
    }
}