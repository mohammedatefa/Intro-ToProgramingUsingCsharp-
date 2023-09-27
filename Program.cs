internal class Program
{
    private static void Main(string[] args)
    {
        // 1-print "Hello World"
        Console.WriteLine("Hello World");

        Console.WriteLine("-----------------------------------------------------------------------------");
        // 2-print ASCII number of a char
        Console.WriteLine("enter your char");
        char alphapitic = char.Parse(Console.ReadLine());
        Console.WriteLine("you enter " + alphapitic + " the ascii is :-  " + Convert.ToInt32(alphapitic));

        Console.WriteLine("-----------------------------------------------------------------------------");
        // 3-print a float number entered by the user
        Console.WriteLine("enter float number");
        float fNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("you enter " + fNumber);

        Console.WriteLine("-----------------------------------------------------------------------------");
        // 4- add two integers

        Console.WriteLine("enter the first number");
        int number_1 = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the second number");
        int number_2 = int.Parse(Console.ReadLine());

        Console.WriteLine("the sum of the two numbers you entered is :- " + (number_1 + number_2));

        Console.WriteLine("-----------------------------------------------------------------------------");

        // 5- print Hexa of a number
        Console.WriteLine("enter your number");
        int HNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("you enter " + HNumber + " the hexa is :- " + HNumber.ToString("X"));

        Console.WriteLine("-----------------------------------------------------------------------------");

        // 6- compute Quotient and Remainder
        Console.WriteLine("enter the two numbers");

        int dividend = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine());

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        Console.WriteLine(" The Quotient: " + quotient);
        Console.WriteLine(" The Remainder: " + remainder);

        Console.WriteLine("-----------------------------------------------------------------------------");

        // 7-  Check Whether a Number is Even or Odd
        Console.WriteLine("enter the numbers");

        int checkedNumber = int.Parse(Console.ReadLine());
        if (checkedNumber % 2 == 0)
        {
            Console.WriteLine("the number you are entered is EVEN");
        }
        else
        {
            Console.WriteLine("the number you are entered is ODD");

        }
        Console.WriteLine("-----------------------------------------------------------------------------");

        // 8- 
        Console.WriteLine("enter the number1");
        int lnumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number1");
        int lnumber2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the number1");
        int lnumber3 = int.Parse(Console.ReadLine());
        int largeNumber;

        if (lnumber1 > lnumber2 && lnumber1 > lnumber3)
        {
            largeNumber = lnumber1;
        }
        else if (lnumber2 > lnumber1 && lnumber2 > lnumber3)
        {
            largeNumber = lnumber2;
        }
        else
        {
            largeNumber = lnumber3;
        }

        Console.WriteLine("the largest number of three numbers " + largeNumber);
        Console.WriteLine("-----------------------------------------------------------------------------");

        //-9
        Console.Write("Enter your degree:- ");
        string degree = Console.ReadLine();

        string grade;

        switch (degree)
        {
            case "A":
                grade = "Excellent";
                break;
            case "B":
                grade = "Very Good";
                break;
            case "C":
                grade = "Good";
                break;
            case "D":
                grade = "Fair";
                break;
            case "E":
                grade = "Failed";
                break;
            default:
                grade = "not found degree";
                break;
        }

        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("-----------------------------------------------------------------------------");

        // 10-Program to print total of numbers when it gets to 100. 
        Console.WriteLine("enter the number");
        int cnumber = int.Parse(Console.ReadLine());

        while (cnumber < 100)
        {
            Console.WriteLine(cnumber);
            cnumber++;
        }
        Console.WriteLine("-----------------------------------------------------------------------------");

        // 11- 11.	Program to Generate Multiplication Table 


        Console.WriteLine("enter the number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Multiplication Table for " + number + ":");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine(number + " * " + i + " = " + result);
        }

        //12-Program to Check Whether a Character is an Alphabet or not

        Console.Write("Enter a your character: ");
        char mychar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (Char.IsLetter(mychar))
        {
            Console.WriteLine(mychar + " is an alphabet.");
        }
        else
        {
            Console.WriteLine(mychar + " is not an alphabet.");
        }
    }
}
