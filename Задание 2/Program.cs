using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Задание 2.Рассмотрим компьютерную сеть с настроенной TCP/IP маршрутизацией. Будем рассматривать некоторую ее модификацию. А именно в этой сети находить N подсетей. Каждая подсеть характеризуется своей маской. Маска подсети представляет собой 4 однобайтных числа, разделенных точкой. Причем для масок выполнено следующее свойство: если представить маску в двоичном виде, то сначала она будет содержать k единиц, а потом q нулей, причем k + q = 32. Например, 255.255.255.0 — маска подсети, а 192.168.0.1 — нет.");
            Console.WriteLine("Поясним, как получается двоичное представление IP - адреса.Для этого числа, составляющие IP - адрес, представляются в двоичной системе счисления(при этом каждое из них дополняется ведущими нулями до длины в 8 цифр), после чего удаляются точки.Получившееся 32 - битное число и есть двоичное представление IP - адреса.Например, для адреса 192.168.0.1 этот процесс выглядит так: 192.168.0.1 → 11000000.10101000.00000000.00000001 → 11000000101010000000000000000001.Таким образом, двоичным представлением IP - адреса 192.168.0.1 является 11000000101010000000000000000001.");
            Console.WriteLine("Будем говорить, что два компьютера с IP1 и IP2 лежат в подсети, если IP1  Mask = IP2  Mask, где Mask — маска этой подсети, а  — операция побитового логического «и». IP компьютера представляет собой так же 4 однобайтных числа, разделенных точкой.");
            Console.WriteLine("Вам даны M пар IP адресов компьютеров.Для каждой из них Вам надо определить, в скольких подсетях из заданных они лежат. ");
            Console.ResetColor();
            string s;
            string[] split;
            int n, itog, m, a, b, c, k, b11, b12, b13, b14, b21, b22, b23, b24;
            bool flag;
            Console.WriteLine("Введите количество подсетей");
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            int.TryParse(split[0], out n);
            Console.WriteLine("Введите  маски подсетей");
            int[,] mask = new int[n, 4];
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                split = s.Split(new char[] { ' ', '.' });
                int.TryParse(split[0], out mask[i, 0]);
                int.TryParse(split[1], out mask[i, 1]);
                int.TryParse(split[2], out mask[i, 2]);
                int.TryParse(split[3], out mask[i, 3]);
            }
            Console.WriteLine("Введите количество IP - адресов");
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            int.TryParse(split[0], out m);
            Console.WriteLine("Введите пары IP - адресов через пробел");
            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine();
                split = s.Split(new char[] { ' ', '.' });
                int.TryParse(split[0], out b11);
                int.TryParse(split[1], out b12);
                int.TryParse(split[2], out b13);
                int.TryParse(split[3], out b14);
                int.TryParse(split[4], out b21);
                int.TryParse(split[5], out b22);
                int.TryParse(split[6], out b23);
                int.TryParse(split[7], out b24);
                itog = 0;
                for (int j = 0; j < n; j++)
                {
                    flag = true;
                    if ((b11 & mask[j, 0]) != (b21 & mask[j, 0])) flag = false;
                    if ((b12 & mask[j, 1]) != (b22 & mask[j, 1])) flag = false;
                    if ((b13 & mask[j, 2]) != (b23 & mask[j, 2])) flag = false;
                    if ((b14 & mask[j, 3]) != (b24 & mask[j, 3])) flag = false;
                    if (flag) itog++;
                }
                Console.WriteLine(itog);

            }

            Console.ReadLine();
        }
    }
}
