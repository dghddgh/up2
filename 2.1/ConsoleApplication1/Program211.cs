using System;

namespace ConsoleApplication1
{
    class Program211
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите J ");
            string J = Console.ReadLine();
            Console.WriteLine("Введите S ");
            string S = Console.ReadLine();
            int count = 0;
            string[] subs = J.Split(' ');
            string[] stons = S.Split(' ');
            for (int i = 0; i < stons.Length; i++)
            {
                for (int j = 0; j < subs.Length; j++)
                {
                    if (stons[i] == subs[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Столько драгоценных камушков вышло ");
            Console.WriteLine(count);
            Console.WriteLine("Ну а вообще все камни хороши ");
            
        }
    }
}