using System;
using System.Threading;

namespace bai_4
{
    class PTBH
    {
        protected int a, b, c;
        public PTBH()
        {
            a = b = c = 0;
        }
        public PTBH(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public void nhap()
        {
            Console.WriteLine("nhap he so a"); a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so b"); b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so c"); c = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("pt {0}x^2+{1}x+{2}=0", a, b, c);
        }
        public void giaipt()
        {
            int delta = (b * b) - 4 * a * c;

            if (a == 0)
            {
                Console.WriteLine("phuong trinh ko phai bac 2");
            }
            if (delta == 0)
            {
                Console.WriteLine("phuong trinh co nghiem kep" + -b / 2 * a);

            }
            else if (delta < 0)
            {
                Console.WriteLine("pt vo nghiem");
            }
            else
            {

                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("2 nhiem{0},{1}", x1, x2);
            }
        }
        class test
        {
            static void Main(string[] args)
            {
                PTBH a = new PTBH();
                a.nhap(); a.giaipt(); a.hien();
                Console.ReadLine();
            }
        }
    }
}
