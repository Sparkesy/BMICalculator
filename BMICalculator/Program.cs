using System;

public class BMI
	{
	public static int weight;
	public static int height;
	public static int bmi;
    
	public static void Main()
		{ 
        calc();
		}

    static void calc()
    {
        
        Console.WriteLine("Please Enter your height in inches: ");
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your weight in pounds: ");
        weight = Convert.ToInt32(Console.ReadLine());


        bmi = weight / height * 703;
        

        if (bmi < 18) 
        {
            Console.WriteLine("Your BMI is: " + bmi + " ooh god your all skin and bone mun, get some meat in you");
            
            Console.WriteLine("Underweight: less than 18.5 Normal: between 18.5 and 24.9 Overweight: between 25 and 29.9 Obese: 30 or greater.");
            Console.WriteLine("press y to retry or n to exit");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {
                Console.Clear();
                calc();
            }
            else if (usercommand == "n")
            {
                Console.Clear();
                exit();
            }
        }
        else if (bmi > 30)
        {
            Console.WriteLine("Your BMI is: " + bmi + " Your a bit overwight, get ona weight watchers en.");
            Console.WriteLine("Underweight: less than 18.5 Normal: between 18.5 and 24.9 Overweight: between 25 and 29.9 Obese: 30 or greater.");
            Console.WriteLine("press y to retry or n to exit");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {
                Console.Clear();
                calc();
            }
            else if (usercommand == "n")
            {
                Console.Clear();
                exit();
            }
        }
        else
        {
            Console.WriteLine("Your BMI is:" + bmi + " Your fine mun no need to loose any weight.");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {
                Console.Clear();
                calc();
            }
            else if (usercommand == "n")
            {
                Console.Clear();
                exit();
            }
        }
    }
        
    static void exit()
        {
        Console.WriteLine("Thank you for using my program");
        Console.WriteLine("Find more interesting projects at my GitHub Repository: bit.ly/2YDCMYQ ");
        Console.WriteLine();
        Console.WriteLine("Program Developed by Jordan W Sparkes");
        Console.WriteLine("Program Developed using Visual Studio 2022 Proffesional Edition");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        Environment.Exit(0);
    }
    
}
