using System;


namespace CS_youtube_kurs
{
    class Program
    {
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

            string str = "Variables: ";
            Console.WriteLine(str+a+", "+ b + ", "+c + ", "+d + ", "+e + ", "+f + ", "+g + ", "+h + ", "+j);
            Console.ReadKey();
        }
    }
}
