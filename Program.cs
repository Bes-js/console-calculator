using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiveBasicCalc
{
    internal class Program
    {
        public static void log(string x) { Console.WriteLine(x); }
        static void Main(string[] args)
        {
            firstBack:
            log("---- Hesap Makinesi ----");
            ConsoleKey key;
            double net = 0;
            bool config = false;
      
            try
            {
             
                log("Sayıyı Giriniz.");
                double number1 = double.Parse(Console.ReadLine());

                geri: 
                if (config == false) log("Sayıyı Giriniz."); else log("( İşlemi Sonlandırmak İçin Herhangi Bir Harf Yazınız )\nSayıyı Giriniz.");
                double number2 = double.Parse(Console.ReadLine());

                log("İşlemi Belirtiniz. ( Örn; +,-,*,/ veya % )");
                char five = char.Parse(Console.ReadLine());

                 if(net == 0) {

                switch (five)
                {
                    case '+':
                        net = number1 + number2;
                        break;
                    case '-':
                        net = number1 - number2;
                        break;
                    case '*':
                        net = number1 * number2;
                        break;
                    case '/':
                        net = number1 / number2;
                        break;
                    case '%':
                        net = number1 % number2;
                        break;
                }
                    config = true;
                log($"Sonuç; {net}");
                    goto geri;
                                }
                                else
                                {
                    switch (five)
                    {
                        case '+':
                            net = net + number2;
                            break;
                        case '-':
                            net = net - number2;
                            break;
                        case '*':
                            net = net * number2;
                            break;
                        case '/':
                            net = net / number2;
                            break;
                        case '%':
                            net = net % number2;
                            break;
                    }
                    log($"Sonuç; {net}");
                    goto geri;
                }
            }
            catch (Exception)
            {
                log("Veritabanı Sıfırlandı\n");
                goto firstBack;
            }




                Console.ReadKey();
        }
    }
}
