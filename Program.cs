using System;

namespace consoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            byte a = 2; //1 byte
            sbyte b = 3; // 1 byte
            short c = 5; // 2byte
            ushort d = 6; // 2 byte

            Int16 e = 9; //2byte
            int f = 10; // 4 byte
            Int32 g = 11; //4 byte
            Int64 z = 15; // 8 byte
            uint h = 4; // 4byte
            long l = 20; // 8 byte
            ulong ul = 25; // 8 byte

            // reel sayilar

            float fl = 5; // 4 byte 
            double db = 10; // 8 byte
            decimal dc = 11; // 16 byte

            char ch = '5'; // 2 byte
            string st = "halil"; // sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "h";
            object o2 = 'a';
            object o3 = 3.5;
            object o4 = 15;


            // String ifadeler

            string str1 = string.Empty;
            str1 = "halil Özcan";


            // değişken dönüşümleri

            string str20 = "15";
            int int20 = 20;

            string yeniDegisken = str20 + int20.ToString();

            Console.WriteLine(yeniDegisken);


            int int21 = int20 + Convert.ToInt32(str20); // cıktısı 35

            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);  // cıktısı 35

            Console.WriteLine(int22);   


            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour); 





        }
    }
}
