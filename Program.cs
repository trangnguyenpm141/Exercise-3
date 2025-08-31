using System;
internal class  Exercise_03
{
    private static void Main(string[] args)
    {
        Ex01();
        Ex02();
    }
    //1. Game doan so
    static void Ex01()
    {
        double sotienquy = 100;
        int sovanthang = 0;
        int sovanthua = 0;

        Console.WriteLine("\nChao mung ban den voi tro choi Doan So!\n");
        do
        {
            if (sotienquy <= 0)
            {
                Console.WriteLine("Ban da het tien quy de choi! Tro choi ket thuc!");
                break;
            }
            Console.WriteLine($"So tien quy hien tai cua ban la: {sotienquy}$");
            Console.WriteLine("Level:\n\tKho: 4 lan choi\n\tTrung binh: 7 lan choi\n\tDe: 10 lan choi");
            Console.Write("Nhap level ban muon choi. [1-Kho ; 2-Trung binh ; 3-De]: ");
            int level;
            while (!int.TryParse(Console.ReadLine(), out level) || level < 1 || level > 3)
            {
                Console.WriteLine("Loi! Vui long nhap 1, 2 hoac 3.");
                Console.Write("Nhap level ban muon choi [1, 2, 3]: ");
            }

            int solanchoi = 0;
            double tienCuoc = 0;
            if (level == 1)
            {
                solanchoi = 4;
                tienCuoc = 4;
            }
            else if (level == 2)
            {
                solanchoi = 7;
                tienCuoc = 7;
            }
            else // level == 3
            {
                solanchoi = 10;
                tienCuoc = 10;
            }
            Random rnd = new Random();
            int comp_num = rnd.Next(0, 100) + 1;
            bool is_won = false;
            for (int i = 0; i < solanchoi; i++)
            {
                Console.Write($"{i + 1}. Ban doan so may? [1-100]: ");
                int user_num = Convert.ToInt32(Console.ReadLine());
                if (user_num == comp_num)
                {
                    Console.WriteLine("Chuc mung ban da doan dung!");
                    sotienquy += tienCuoc;
                    sovanthang++;
                    is_won = true;
                    break;
                }
                else
                {
                    if (user_num < comp_num)
                    {
                        Console.WriteLine("So ban doan nho hon so may nghi.");
                    }
                    else
                    {
                        Console.WriteLine("So ban doan lon hon so may nghi.");
                    }
                }
            }
            if (!is_won)
            {
                Console.WriteLine($"Ban da het so lan choi! So may nghi la: {comp_num}");
                sotienquy -= tienCuoc;
                sovanthua++;
            }
            Console.Write("\nBan co muon choi nua khong? <c/k> ");
            string tl = Console.ReadLine();
            if (tl.ToLower().Equals("k"))
            {
                Console.WriteLine("Tam biet va hen gap lai!");
                break;
            }
        }while (true);
        Console.WriteLine($"\nSo van ban da thang: {sovanthang}");
        Console.WriteLine($"So van ban da thua: {sovanthua}");
        Console.WriteLine($"So tien quy con lai cua ban: {sotienquy}$");
        Console.WriteLine("Cam on ban da choi tro choi!");
    }
    //2. Game tai xiu
    static void Ex02()
    {
        double sotienquy = 100;
        int sovanthang = 0;
        int sovanthua = 0;

        Console.WriteLine("\nChao mung ban den voi tro choi Tai Xiu!\n");
        do
        {
            if (sotienquy <= 0)
            {
                Console.WriteLine("\nBan da het tien! Tro choi ket thuc.");
                break;
            }
            Console.WriteLine($"\nSo tien quy hien tai cua ban la: {sotienquy}$");
            Console.Write("Ban doan la 'tai', 'xiu' hay '5'? ");
            string nguoichoidoan = Console.ReadLine().ToLower();
            Random rnd = new Random();
            int xucxac1 = rnd.Next(1, 6);
            int xucxac2 = rnd.Next(1, 6);
            int tong = xucxac1 + xucxac2;

            string ketqua = "";
            double tienthangthua = 0;

            if (tong > 5)
            {
                ketqua = "tai";
                tienthangthua = (nguoichoidoan == "tai") ? 5 : -5;
            }
            else if (tong < 5)
            {
                ketqua = "xiu";
                tienthangthua = (nguoichoidoan == "xiu") ? 5 : -5;
            }
            else // tong == 5
            {
                ketqua = "5";
                tienthangthua = (nguoichoidoan == "5") ? 15 : -5;
            }

            sotienquy += tienthangthua;

            Console.WriteLine($"\nKet qua: {xucxac1} + {xucxac2} = {tong}. => {ketqua.ToUpper()}");

            if (tienthangthua > 0)
            {
                Console.WriteLine($"Chuc mung, ban da thang ${tienthangthua}!");
                sovanthang++;
            }
            else
            {
                Console.WriteLine($"Rat tiec, ban da thua ${Math.Abs(tienthangthua)}.");
                sovanthua++;
            }
            Console.Write("\nBan co muon choi nua khong? <c/k> ");
            string tl = Console.ReadLine().ToLower();
            if (tl.ToLower().Equals("k"))
            {
                break;
            }

        } while (true);
        Console.WriteLine($"So van thang: {sovanthang}");
        Console.WriteLine($"So van thua: {sovanthua}");
        Console.WriteLine($"So tien con lai: {sotienquy}$");
        Console.WriteLine("Tam biet va hen gap lai!");
    }
}
