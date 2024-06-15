using System;

class GiftFromSanta
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());

        bool foundS = false;

        for (int i = M; i >= N; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == S)
                {
                    foundS = true;
                    break; 
                }

                Console.Write(i + " ");
            }
        }

        if (!foundS)
        {
            Console.WriteLine();
        }
    }
}
