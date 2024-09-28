// See https://aka.ms/new-console-template for more information
using HW;

class Proggram
{
    public static void Main(string[] args)
    {
        var salaryUser = new SalaryUser();
        salaryUser.CalculateInterest(new Account() { Balance = 4000}); 

        Console.WriteLine();   
        var usualUser = new UsualUser();
        usualUser.CalculateInterest(new Account() { Balance = 900});
        Console.WriteLine();
    }
}
