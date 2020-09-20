using System;

namespace Homework1
{

    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            float alpha;
            Console.Write("Enter angle alpha : ");
            alpha = float.Parse(Console.ReadLine());
            while ((alpha <= 0) || (alpha >= 360))
            {
                Console.WriteLine("it's wrong, please try again with 0<alpha<360");
                alpha = float.Parse(Console.ReadLine());
            }
            float x = (float)(alpha / 180) * pi;
            Console.Write("{0} (degree) = {1} (radian)", alpha, x);
            Console.ReadLine();
        }
    }
}