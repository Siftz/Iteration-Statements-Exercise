namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void DescendNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                 Console.WriteLine(i); // not to self find alt for Console.WriteLine
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void UpByThrees999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
            
        }
        
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }
        
            
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void PosOrNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanYouVote()
        {
            Console.WriteLine("What is your age?");
            var userInput = int.TryParse(Console.ReadLine(), out int ageOfUser);
            while (userInput == false)
            {
                Console.WriteLine("Please try to enter a valid age: ");
                userInput = int.TryParse(Console.ReadLine(), out ageOfUser);
            }

            if (ageOfUser >= 18)
            {
                Console.WriteLine($"Congratulations! You are allowed to vote at {ageOfUser}.");
            }
            else
            {
                Console.WriteLine($"You are not allowed to vote at {ageOfUser} please wait until you are older.");
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static void IsInRange()
        {
            Console.WriteLine("Please provide a number!");
            var userGuess = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!userGuess)
            {
                Console.WriteLine("Please provide a valid number!");
                userGuess = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"Your number {userNumber} is within the winning range!");
            }
            else
            {
                Console.WriteLine($"Your number {userNumber} is not within the winning range. Better luck next time!");
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplication(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {number * i}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            DescendNumbers1000();
            UpByThrees999();
            Program program = new Program();
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"Are the numbers {num1}, {num2} equal? " + program. AreNumbersEqual(num1, num2));
            EvenOrOdd((10));
            PosOrNeg(-6);
            CanYouVote();
            IsInRange();
            DisplayMultiplication(6);
        }
    }
}
