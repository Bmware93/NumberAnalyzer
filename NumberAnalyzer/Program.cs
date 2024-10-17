// See https://aka.ms/new-console-template for more

// If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60
// If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”

// If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25
// If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive
// If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the number analyzer game!");
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        bool userWantsToReplay = false;

        do
        {
            Console.WriteLine($"Thank you for playing {userName}!");
            Console.WriteLine("Please enter a whole number between 1 and 100: ");
            string userResponse = Console.ReadLine();

            //Converting users response to an int
            int userResponseAsInt = int.Parse(userResponse);

            //Checking that users response is within valid range
            while (userResponseAsInt < 1 || userResponseAsInt > 100)
            {
                Console.WriteLine("You've entered an invalid option. Please enter a number between 1 and 100");
                userResponse = Console.ReadLine();
                userResponseAsInt = int.Parse(userResponse);
            }
            // if response is even
            if (userResponseAsInt % 2 == 0)
            {
                if (userResponseAsInt >= 2 && userResponseAsInt <= 24)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (userResponseAsInt >= 26 && userResponseAsInt <= 60)
                {
                    Console.WriteLine("Even and between 26 and 60 inclusive");
                }
                else
                {
                    Console.WriteLine("Even and greater than 60");
                }
            }
            //if response is odd
            if (userResponseAsInt % 2 != 0)
            {
                if (userResponseAsInt < 60)
                {
                    Console.WriteLine("Odd and less than 60");
                }
                else
                {
                    Console.WriteLine("Odd and greater than 60");
                }
            }
            Console.WriteLine($"Would you like to play again {userName}?");
            userResponse = Console.ReadLine();

            if(userResponse.Contains('y'))
            {
                userWantsToReplay = true;
            } else
            {
                userWantsToReplay = false;
            }

        } while (userWantsToReplay == true);
        

    }
 

}






