using System;

public class Program
{
    // Calculator 1 functions
    public static double increase(double calc1number, double calc1percentage)
    {
        double multiplier = Math.Round(1 + (calc1percentage / 100), 2);
        Console.WriteLine($"Multiplier used: ×{multiplier}");
        return Math.Round(calc1number * multiplier, 2);
    }
    public static void increaseExplanation(double calc1number, double calc1percentage)
    {
        double newNumber = calc1percentage / 100;
        double multiplier = Math.Round(1 + (calc1percentage / 100), 2);
        double calc1answer = Math.Round(calc1number * multiplier, 2);
        Console.WriteLine($"1. Take {calc1percentage}% and divide it by 100 which gives {newNumber}.\n2. Add 1 to {newNumber} — which represents an increase — to give the multiplier {multiplier}.\n3. Multiply {calc1number} by {multiplier} using a calculator which gives {calc1answer}.");
    }
    public static double decrease(double calc1number, double calc1percentage)
    {
        double multiplier = Math.Round(1 - (calc1percentage / 100), 2);
        Console.WriteLine($"Multiplier used: ×{multiplier}");
        return Math.Round(calc1number * multiplier, 2);
    }
    public static void decreaseExplanation(double calc1number, double calc1percentage)
    {
        double newNumber = calc1percentage / 100;
        double multiplier = Math.Round(1 - (calc1percentage / 100), 2);
        double calc1answer = Math.Round(calc1number * multiplier, 2);
        Console.WriteLine($"1. Take {calc1percentage}% and divide it by 100 which gives {newNumber}.\n2. Minus {newNumber} from 1 — which represents a decrease — to give the multiplier {multiplier}.\n3. Multiply {calc1number} by {multiplier} using a calculator which gives {calc1answer}.");
    }

    // Calculator 2 functions
    public static double function1(double number1, double number2)
    {
        return Math.Round((number1 / number2) * 100, 2);
    }

    public static double function2(double number1, double number2)
    {
        return Math.Round((number2 / number1) * 100, 2);
    }

    // Calculator 3 functions
    public static double simple(double calc3number, double calc3percentage, double calc3years)
    {
        double interest = Math.Round(calc3number * (calc3percentage / 100) * calc3years, 2);
        Console.WriteLine($"Interest: £{interest}");
        return calc3number + interest;
    }

    public static double compound(double calc3number, double calc3percentage, double calc3years, int calc3times)
    {
        double interest = Math.Round(calc3number * (Math.Pow(1 + ((calc3percentage / 100) / calc3times), calc3times * calc3years)), 2);
        Console.WriteLine($"Interest: £{interest}");
        return calc3number + interest;
    }

        public static void Main()
        {
        // Calculator 1 variables
        double calc1number;
        double calc1percentage;
        string calc1function;
        double calc1answer;
        string calc1explanation;

        // Calculator 2 variables
        double calc2number1;
        double calc2number2;
        double calc2answer1;
        double calc2answer2;

        // Calculator 3 variables
        double calc3number;
        double calc3percentage;
        double calc3years;
        string calc3years2;
        int calc3times;
        string calc3function;
        double calc3answer;

        // Using a switch statement to choose which calculator to use
        Console.WriteLine("Welcome to Percentage Calculator.");
        modeInput:
        Console.WriteLine("\nType '1' for percentage increase/decrease calculator.\nType ‘2’ to find out what percentage two numbers are of each other.\nType '3' for interest calculator.");
        int mode = Int32.Parse(Console.ReadLine());
        if (mode != 1 && mode != 2 && mode != 3)
        {
            Console.WriteLine("Please try again.");
            goto modeInput;
        }
        switch (mode)
        {
            // Calculator 1
            case 1:
                // Asking for the original number
                Console.WriteLine("Please enter the number you'd like to increase/decrease by a percentage amount.");
                calc1numberInput:
                try
                {
                    calc1number = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto calc1numberInput;
                }

                // Asking for the percentage
                Console.WriteLine("Now please enter the percentage you'd like to increase/decrease your number by.");
                calc1percentageInput:
                try
                {
                    calc1percentage = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter numbers only.");
                    goto calc1percentageInput;
                }

                // Checking which function to use + getting the answer from the function
                Console.WriteLine("Would you like to increase or decrease your number by the percentage amount? Type '+' for increase and '-' for decrease.");
                calc1functionInput:
                calc1function = Console.ReadLine();
                if (calc1function == "+")
                {
                    calc1answer = increase(calc1number, calc1percentage);
                    Console.WriteLine($"Answer is: {calc1answer}");

                    // Asking if the user would like an explanation for the answer
                    calc1explanationInput:
                    Console.WriteLine("Would you like an explanation for the answer? Type 'Y' for yes and 'N' for no.");
                    calc1explanation = Console.ReadLine();
                    if (calc1explanation == "Y" || calc1explanation == "y")
                    {
                        increaseExplanation(calc1number, calc1percentage);
                        goto modeInput;
                    }
                    else if (calc1explanation == "N" || calc1explanation == "n")
                    {
                        // Looping the program
                        goto modeInput;
                    }
                    else
                    {
                        Console.WriteLine("Please try again.");
                        goto calc1explanationInput;
                    }
                }
                else if (calc1function == "-")
                {
                    calc1answer = decrease(calc1number, calc1percentage);
                    Console.WriteLine($"Answer is: {calc1answer}");

                    // Asking if the user would like an explanation for the answer
                    calc1explanationInput:
                    Console.WriteLine("Would you like an explanation for the answer? Type 'Y' for yes and 'N' for no.");
                    calc1explanation = Console.ReadLine();
                    if (calc1explanation == "Y" || calc1explanation == "y")
                    {
                        decreaseExplanation(calc1number, calc1percentage);
                        goto modeInput;
                    }
                    else if (calc1explanation == "N" || calc1explanation == "n")
                    {
                        // Looping the program
                        goto modeInput;
                    }
                    else
                    {
                        Console.WriteLine("Please try again.");
                        goto calc1explanationInput;
                    }
                }
                else
                {
                    Console.WriteLine("Please try again.");
                    goto calc1functionInput;
                }
            // Calculator 2
            case 2:
                // Asking for the first number
                Console.WriteLine("Please enter a number.");
                calc2number1Input:
                try
                {
                    calc2number1 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto calc2number1Input;
                }

                // Asking for the second number
                Console.WriteLine("Now please enter the second number.");
                calc2number2Input:
                try
                {
                    calc2number2 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter numbers only.");
                    goto calc2number2Input;
                }

                // Getting the answers from the functions
                calc2answer1 = function1(calc2number1, calc2number2);
                calc2answer2 = function2(calc2number1, calc2number2);
                Console.WriteLine($"{calc2number1} is {calc2answer1}% of {calc2number2}.\n{calc2number2} is {calc2answer2}% of {calc2number1}.");

                // Looping program
                goto modeInput;
            // Calculator 3
            case 3:
                // Asking for the original amount of money
                Console.WriteLine("Please enter the original amount.");
                calc3numberInput:
                try
                {
                    calc3number = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                    goto calc3numberInput;
                }

                // Asking for the interest percentage
                Console.WriteLine("Now please enter the interest percentage.");
                calc3percentageInput:
                try
                {
                    calc3percentage = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter numbers only.");
                    goto calc3percentageInput;
                }

                // Asking for the amount of years of interest
                Console.WriteLine("Now please enter after how many years you'd like to know the new value.");
                calc3yearsInput:
                try
                {
                    calc3years = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter numbers only.");
                    goto calc3yearsInput;
                }
                if (calc3years <= 0)
                {
                    Console.WriteLine("You can not have a negative amount of years. Try again.");
                    goto calc3yearsInput;
                }
                else if (calc3years > 1)
                {
                    calc3years2 = "years";
                }
                else
                {
                    calc3years2 = "year";
                }

                // Checking which function to use + getting the answer from the function
                Console.WriteLine("Type 's' for simple interest or 'c' for compound interest.");
                calc3functionInput:
                calc3function = Console.ReadLine();
                if (calc3function == "s")
                {
                    calc3answer = simple(calc3number, calc3percentage, calc3years);
                    Console.WriteLine($"The total amount after {calc3years} {calc3years2} at {calc3percentage}% simple interest is £{calc3answer}.");
                }
                else if (calc3function == "c")
                {
                    Console.WriteLine("How many times is the interest rate compounded per year?");
                    calc3timesInput:
                    try
                    {
                        calc3times = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter numbers only.");
                        goto calc3timesInput;
                    }
                    calc3answer = compound(calc3number, calc3percentage, calc3years, calc3times);
                    Console.WriteLine($"The total amount after {calc3years} {calc3years2} at {calc3percentage}% compound interest is £{calc3answer}.");
                }
                else
                {
                    Console.WriteLine("Please try again.");
                    goto calc3functionInput;
                }

                // Looping the program
                goto modeInput;
        }
    }
}