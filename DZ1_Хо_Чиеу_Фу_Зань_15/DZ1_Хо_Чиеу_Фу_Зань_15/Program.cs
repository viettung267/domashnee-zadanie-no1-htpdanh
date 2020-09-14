using System;

namespace DZ1_Хо_Чиеу_Фу_Зань_15
{
    
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            float alpha;
            Console.Write("Enter corner alpha : ");
            alpha = float.Parse(Console.ReadLine());
            while ((alpha <= 0) || (alpha >= 360))
            {
                Console.WriteLine("it's wrong, please try again with 0<alpha<360");
                alpha = float.Parse(Console.ReadLine());
            }
            float x = (float)(alpha / 180) * pi ;
            Console.Write("{0} (градусов) = {1} (радионов)", alpha, x);
            Console.ReadLine();
        }
    }
}
