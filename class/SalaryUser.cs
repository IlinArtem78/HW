using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class SalaryUser : ICalculateInterest
    {
        public void CalculateInterest(Account account)
        {
            account.Type = "Зарплатный пользователь";
            Console.WriteLine(account.Type);
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
            Console.WriteLine("Процентная ставка {0}", account.Interest);
            Console.WriteLine("Баланс учетной записи {0}", account.Balance);
        }
    }
}
