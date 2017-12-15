using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
   // delegate void sms(string messege);
        
    class Program
    {
        delegate void readmoney();
        string reg;
      // Func<string, string>m=new Func<string, string>(ofice.show);// сообщение для менеджера о операции
       
        static Action<string> err = error;//Сообщение для пользователя о ошибке
       static Action<string> inc = Incasator.incasator;
        static void Main(string[] args)
        {
          
           Acaunt Bank=new Acaunt(string.Format("Zero 1"), 7, 1777); 
           Bank.putMoney(6000, inc);
            Bank.outMoney(8000);
            Bank.ReadMoney();
            Console.ReadKey();
        }
        public static void error(string messege)
        {
            Console.WriteLine(messege);
        }
    }

}
