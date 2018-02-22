using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001HW2
{
    class Yönler
    {
        public int[,] alan = new int[8, 8];
        public void IlkVezirYerlestir()
        {
            Console.WriteLine("İlk vezirimizi random olarak atıyoruz:::");
            Random rnd = new Random();
            int satir;
            int sutun;
            int str = rnd.Next(0, 8);
            int stn = rnd.Next(0, 8);
            Console.WriteLine("Satır:" + str);
            Console.WriteLine("Sutun:" + stn);
            satir = str;
            sutun = stn;
            int[] dizi = { 0, 2, 4, 6, 3, 1, 5, 7 };//1 satır aşağı ve 2 satır sağa kayma hali bu sayılara göre şekilleniyor.
            for (int i = 0; i < alan.GetLength(0); i++)//ilk vezirin random atamasını bu forda gerçekleştiriyoruz.
            {
                for (int j = 0; j < alan.GetLength(1); j++)
                {
                    if (i == str && j == stn)
                    {
                        Console.Write("V ");
                    }
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("vezir hareketlerin yerleştirilmesi aşağıda verilmiştir:::");
            int degis = str;
            for (int k = 0; k < dizi.Length; k++)
            {
                if (satir == dizi[k])
                {
                    int l = sutun + 1;
                    while (l <= alan.GetLength(1))
                    {
                        if (l == 8)
                        {
                            l = 0;
                        }
                        for (int t = k + 1; t <= dizi.Length; t++)
                        {
                            if (t == 8)
                                t = 0;
                            if (degis == dizi[t])
                                break;
                            if (l == 8)
                                l = 0;
                            else
                            {
                                satir = dizi[t];
                                sutun = l;
                                alan[satir, sutun] = 1;
                                l++;
                            }
                        }
                        break;
                    }
                }
            }
            for (int n = 0; n < alan.GetLength(0); n++)
            {
                for (int m = 0; m < alan.GetLength(1); m++)
                {
                    if (alan[n, m] == 1 || (n == str && m == stn))
                    {
                        Console.Write("V ");
                    }

                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
