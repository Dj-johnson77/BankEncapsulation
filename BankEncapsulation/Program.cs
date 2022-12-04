namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var donaldsAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            var myDeposit = double.Parse(Console.ReadLine());
            donaldsAccount.Deposit(myDeposit);
            Console.WriteLine($"Thank you. Your balance is now {donaldsAccount.GetBalance()}");
        }
    }
}
