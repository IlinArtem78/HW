using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class UsualUser: ICalculateInterest
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account)
        {
            account.Type = "Обычный пользователь"; 
            Console.WriteLine(account.Type);
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                 {
                     account.Interest -= account.Balance * 0.2;
                 }
                else if     (account.Balance != 1000)
                {
                    account.Interest -= account.Balance * 0.4;
                }

            Console.WriteLine("Процентная ставка {0}", account.Interest);
            Console.WriteLine("Баланс учетной записи {0}", account.Balance);
        }

       
    }
  
}
