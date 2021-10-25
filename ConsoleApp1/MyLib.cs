using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyLib
    {
        public static KetQua PTBacNhat(int a, int b, out float x)
        {
            x = 0;
            if (a == 0)
                if (b == 0)
                    return KetQua.VoSoNghiem;
                else
                    return KetQua.VoNghiem;
            else
            {
                x = (float)-b / a;
                return KetQua.Co1Nghiem;
            }
        }

        public static long TongNso(int n)
        {
            long rs = 0;
            for (int i = 0; i <= n; i++)
            {
                rs += i;
            }
            return rs;

        }
        public static long TongNversion2(int n)
        {
            long rs = 0;

            while (int i <= n)
        {
                rs += (long)i;
                i++;
            }
        }
        public static long TongNdeQuy(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + TongNdeQuy(n - 1);
        }
        public enum KetQua
        {
            VoNghiem,
            VoSoNghiem,
            Co1Nghiem,
            Co2Nghiem
        }


    }
    public class Point
    {
        public int x
        {
            get; set;
        }
        public int y
        {
            get; set;
        }
        public Point(int x, int y)
            {
            this.x = x;
            this.y = y;
        }
            
    public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;

        }
        // tính khoảng cách  từ điểm hiện tại đến điểm hiện tại
        public double Distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }

        public double Distance(Point p)
        {
            double d = Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y ,   2));
            return d;
        }
        public static double Distance()
        {

        }
    }


}

