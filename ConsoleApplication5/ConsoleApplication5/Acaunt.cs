using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication5
{
    class Acaunt
    {
        private int money;
        private int number;
        public string adress;
       public Acaunt(string a, int n, int m)
        {
            adress = a;
            number = n;
            money = m;
        }
   
    public    void ReadMoney()
        {
            Console.WriteLine("Банкомат №"+number+"\n");
            Console.WriteLine("Адрес - "+adress+"\n");
            Console.WriteLine("\nОстаток денег на счету - "+money+"\n");
        }
    public void putMoney(int y, Action<string> metod)
    {
        money += y;
        metod(string.Format("\nНа счет поступило - "+y+"грн\n"+"Баланс - "+money+"грн"));
    }
    static Menedger ofice = new Menedger();

    Func<string, string> m = new Func<string, string>(ofice.show);// сообщение для менеджера о операции
    public void outMoney(int o)
    {
        if (money >= o)
        {
            money -= o;
          Console.WriteLine(m(string.Format("\nСo счета снятo - " + o + "грн" + "\nБаланс - " + money + "грн\n")));
        }
        else Console.WriteLine(m(string.Format("Недостаточно средств на счету - попробуйте снять меньшую сумму")));
       
    }
    }
}
