using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.MyLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0;
            var rs = MyLib.PTBacNhat(20, 10, out x);
            if (rs=KetQua.VoSoNghiem)
                Console.WriteLine(" PT VÔ SỐ NGhiệm");
           else  if (rs = KetQua.VoNghiem)
                Console.WriteLine(" PT VÔ NGhiệm");
             else  
                Console.WriteLine($" PT có NGhiệm = {x}");

            Console.WriteLine("Hello");
            Console.ReadKey();

            int n = 5;
            var kq = MyLib.TongNso(n);



        }




    }
        
}
