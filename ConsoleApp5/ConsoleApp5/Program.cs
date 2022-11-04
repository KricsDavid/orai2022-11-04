using System;

namespace ConsoleApp5
{
    class Program
    {
        static void ShowWindow(int kx, int ky, int szelesseg, int magassag,
        bool vanKeret, ConsoleColor szin)
        {
            Console.ForegroundColor = szin;
            for (int aktSorIndexe = ky; aktSorIndexe < ky + magassag; aktSorIndexe++)
            {
                for (int aktOszlopIndexe = kx; aktOszlopIndexe < kx + szelesseg; aktOszlopIndexe++)
                {
                    Console.SetCursorPosition(aktOszlopIndexe, aktSorIndexe);
                    if (vanKeret)
                    {
                        if (aktOszlopIndexe == kx || aktOszlopIndexe == kx + szelesseg - 1
                            || aktSorIndexe == ky || aktSorIndexe == ky + magassag - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            Console.ForegroundColor = szin;
                        }
                    }
                    Console.Write('█');
                }
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            ShowWindow(12,10,85,25,true,ConsoleColor.Red);
            Console.ReadKey();
        }
    }
}