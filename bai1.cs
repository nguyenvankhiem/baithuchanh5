using System;

namespace baithuchanh4
{
    class TienDien
    {
        protected int sodienthangtruoc, sodienthangnay, sodiendadung;
        private string tenchuho, diachi;
        protected int tiendien;
        public TienDien(int sodienthangtruoc, int sodienthangnay, string tienchuho, string diachi)
        {
            this.sodienthangnay = sodienthangnay;
            this.sodienthangtruoc = sodienthangtruoc;
            this.tenchuho = tenchuho;
            this.diachi = diachi;
        }
        public TienDien()
        {
            sodienthangtruoc = 0;
            sodienthangnay = 0;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten chu ho:");
            tenchuho = Console.ReadLine();
            Console.Write("Nhap dia chi chu ho:");
            diachi = Console.ReadLine();
            Console.Write("Nhap so cong to thang truoc:");
            sodienthangtruoc = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cong to thang nay:");
            sodienthangnay = int.Parse(Console.ReadLine());
            sodiendadung = sodienthangnay - sodienthangtruoc;
            Console.WriteLine($"So dien da dung trong thang nay la:{sodiendadung}so");
        }
        public void Hien()
        {
            Console.SetCursorPosition(0, 6); Console.WriteLine("Ten Chu Ho");
            Console.SetCursorPosition(tenchuho.Length + 10, 6); Console.WriteLine("Dia Chi");
            Console.SetCursorPosition(tenchuho.Length + 10 + diachi.Length + 6, 6); Console.WriteLine("So Dien Da Dung");
            Console.SetCursorPosition(tenchuho.Length + 10 + diachi.Length + 6 + 20, 6); Console.WriteLine("Tien Dien");
            Console.WriteLine($"{tenchuho}");
            Console.SetCursorPosition(tenchuho.Length + 10, 7); Console.WriteLine($"{diachi}");
            Console.SetCursorPosition(tenchuho.Length + 10 + diachi.Length + 6, 7); Console.WriteLine($"{sodiendadung}");
            Console.SetCursorPosition(tenchuho.Length + 10 + diachi.Length + 6 + 20, 7); Console.WriteLine($"{tiendien}");
        }
        public int TinhTienDien()
        {
            return sodiendadung * 500;
        }

    }
    class TienDienMoi : TienDien
    {
        private int dinhmuc;
        public TienDienMoi(int dinhmuc) : base()
        {
            this.dinhmuc = dinhmuc;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap dinh muc:");
            dinhmuc = int.Parse(Console.ReadLine());
        }
        public void Hien()
        {

            base.Hien();
        }
        public new int TinhTienDien()
        {
            if (base.sodiendadung < dinhmuc)
            {
                return base.tiendien * 600;
            }
            else
            {
                return base.tiendien * 500;
            }
        }

    }
    class bai1
    {
        static void Main(string[] args)
        {
            TienDien a = new TienDien();
            a.Nhap();
            a.TinhTienDien();
            a.Hien();
            Console.ReadKey();
        }
    }
}
