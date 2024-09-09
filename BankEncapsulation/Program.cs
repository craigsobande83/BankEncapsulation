namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
          var craigsAccount = new BankAccount ();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            craigsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you ! Your balance is now {craigsAccount.GetBalance()}");
        }
    }
}
