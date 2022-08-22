namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Programs:");
            Console.WriteLine(" [1]: Student information");
            Console.WriteLine(" [2]: Passed or failed");
            Console.WriteLine(" [3]: Back in 30 minutes");
            Console.WriteLine(" [4]: Month printer");
            Console.WriteLine(" [5]: Foreign language");
            Console.WriteLine(" [6]: Theater Promotions");
            Console.WriteLine(" [7]: Divisible by 3");
            Console.WriteLine(" [8]: Sum of odd numbers");
            Console.WriteLine(" [9]: Multiplication table");
            Console.WriteLine(" [10]: Even number");
            Console.Write("Choose a program: ");
            int program = int.Parse(Console.ReadLine());
            Console.Clear();

            if (program == 1)
            {//! Problem 1: Student information
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter student's average grade: ");
            double grade = double.Parse(Console.ReadLine());
            Console.Write($"Name: {name}, Age: {age}, Grade: {grade:F2}");}

            if (program == 2)
            {//! Problem 2/3: Passed or failed
            Console.Write("Enter grade: ");
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.Write("Passed!");
            }
            else
            {
                Console.Write("Failed!");
            } }

            if (program == 3)
            {//! Problem 4: Back in 30 minutes
            Console.Write("Enter hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            Console.Write($"{hours}:{minutes:D2}");}

            if (program == 4)
            {//! Problem 5: Month Printer
            Console.Write("Enter a number between 1 and 12: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.Write("January");
                    break;
                case 2:
                    Console.Write("February");
                    break;
                case 3:
                    Console.Write("March");
                    break;
                case 4:
                    Console.Write("April");
                    break;
                case 5:
                    Console.Write("May");
                    break;
                case 6:
                    Console.Write("June");
                    break;
                case 7:
                    Console.Write("July");
                    break;
                case 8:
                    Console.Write("August");
                    break;
                case 9:
                    Console.Write("September");
                    break;
                case 10:
                    Console.Write("October");
                    break;
                case 11:
                    Console.Write("November");
                    break;
                case 12:
                    Console.Write("December");
                    break;
                default:
                    Console.Write("Error!");
                    break;
            }}

            if (program == 5)
            {//! Problem 6: Foreing languages
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                    Console.Write("English");
                    break;
                case "England":
                    Console.Write("English");
                    break;
                case "Spain":
                    Console.Write("Spanish");
                    break;
                case "Argentina":
                    Console.Write("Spanish");
                    break;
                case "Mexico":
                    Console.Write("Spanish");
                    break;
                default:
                    Console.Write("unknown");
                    break;
            }}

            if (program == 6)
            {//! Problem 7: Theatre promotions
            Console.Write("Is it a Weekday, Weekend or Holiday: ");
            string day = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (age >= 0 && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 5;
                        break;
                    default:
                        Console.Write("Error!");
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 18;
                        break;
                    case "Weekend":
                        price = 20;
                        break;
                    case "Holiday":
                        price = 12;
                        break;
                    default:
                        Console.Write("Error!");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        price = 12;
                        break;
                    case "Weekend":
                        price = 15;
                        break;
                    case "Holiday":
                        price = 10;
                        break;
                    default:
                        Console.Write("Error!");
                        break;
                }
            }
            else
            {
                Console.Write("Error!");
            }
            if (price != 0)
            {
                Console.Write($"{price}$");
            }}

            if (program == 7)
            {//! Problem 8: Divisible by 3
            for (int i = 3; i <= 100; i += 3)
            {
                Console.Write(i + " ");
            }}

            if (program == 8)
            {//! Problem 9: Sum of odd numbers
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum: {sum}");}

            if (program == 9)
            {//! Problem 10/11: Multiplication table
            Console.Write("Enter a number between 1 and 100: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter starting multiplier: ");
            string start = Console.ReadLine();
            int multiplicationStart = 0;
            if (start.Contains(""))
            {
                multiplicationStart = 1;
            }
            else
            {
                multiplicationStart = int.Parse(start);
            }
            for (int i = multiplicationStart; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
            if (multiplicationStart > 10)
            {
                Console.WriteLine($"{number} X {start} = {number * multiplicationStart}");
            }}

            if (program == 10)
            {//! Problem 12: Even number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            while (number % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Even number entered: {Math.Abs(number)}");}
        }
    }
}