namespace Assignment5._1._1
{
    internal class Program
    {

        static bool checkPalindrome(int n)
        {

            int reverse = 0;
            int temp = n;
            while (temp != 0)
            {
                reverse = (reverse * 10) + (temp % 10);
                temp = temp /= 10;
            }
            return (reverse == n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number to see if it is a palindrome");    
            string input = Console.ReadLine();
            int userInput;

            if (int.TryParse(input, out userInput))
            {
                if (checkPalindrome(userInput))
                {
                    Console.WriteLine("It is a palindrome");
                }
                else
                {
                    Console.WriteLine("It is not a palindrome");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }
    }
}
