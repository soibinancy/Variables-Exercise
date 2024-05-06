using System.Transactions;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Soibi";
            int myAge = 36;
            Double avg = 98.00;
            decimal myWallet = 400.00m;
            bool isStrong = true;
            char initial = 'S';
            
            // Writing the variables to the console
            Console.WriteLine($"Name: {myName}\nAge: {myAge}\nAverage: {avg}\nCurrency: {myWallet}\nStrong: {isStrong}\nInitial: {initial}");

        }
    }
}
