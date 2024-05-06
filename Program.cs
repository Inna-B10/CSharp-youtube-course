using System;


namespace CS_youtube_kurs
{
    class Program
    {
        public static float Sum (int x, float y)
        {
            return(x + y);
        }
        static void Main()
        {
            sbyte a = -128;     //range -128 to 127                         8-bit
            byte b = 255;       //range 0 to 255                            8-bit
            short c = -32768;   //range -32,768 to 32,767                   16-bit
            ushort d = 65535;   //range 0 to 65,535                         16-bit
            int e = -10;        //range -2,147,483,648 to 2,147,483,647     32-bit
            uint f = 5;         //range 0 to 4,294,967,295                  32-bit
            long g = -9223372036854775808;   //range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807        64-bit
            float h = -4.5345f;
            double j = 5.324d;

            char symbol = 'A';
            bool isFirst = false;
            string str = "Variables: ";
            Console.WriteLine(str+a+", "+ b + ", "+c + ", "+d + ", "+e + ", "+f + ", "+g + ", "+h + ", "+j);
            //Console.ReadKey();


            //int num_1 = 0, num_2 = 0;
            //int num_1, num_2;

            int num_1=Convert.ToInt32(Console.ReadLine())*2;
            //num_1 = num_1*2;
            //num_1 *= 2;

           //float num_2 = (float)Convert.ToDouble(Console.ReadLine());
           float num_2=float.Parse(Console.ReadLine())+10f;
            Console.WriteLine(Sum(num_1, num_2));
            //Console.ReadKey();


            Console.WriteLine(Math.Abs(-20));
            Console.WriteLine(Math.Ceiling(4.11f));
            Console.WriteLine(Math.Floor(4.99f));
            Console.WriteLine(Math.Round(4.56f));
            Console.ReadKey();
        }
    }
}
