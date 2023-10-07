class Program
{
    static ConsoleKeyInfo key;
    static void Main(string[] args)
    {
        Console.WriteLine ("Приветик, это консольное пианинко!");
        Console.WriteLine ("Если хочешь переклучать октавы, тогда нажимай F1 или F2");
        Console.WriteLine ("    W(C#) E(D#)      T(F#) Y(G#) U(A#)");
        Console.WriteLine (" A(C)  S(D)  D(E) F(F)  G(G)  H(A)   J(H)");


        int[] def = new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
        while (true)
        {
            OneOctava(def);
            if (key.Key == ConsoleKey.F1)
            {
                def = new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
            }
            else if (key.Key == ConsoleKey.F2)
            {
                def = new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
            }
        }
    }

    static void OneOctava(int[] Hertz)
    {
        /*            ConsoleKeyInfo Octava = Console.ReadKey(true);
                    if (Octava.Key == ConsoleKey.F1)
                    {*/
        List<string> noty = new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        key = Console.ReadKey(true);
        while (true)
        {
            if (key.Key == ConsoleKey.A)
            {
                Console.Beep(Hertz[0], 400);
                Console.WriteLine(noty[0]);
            }
            else if (key.Key == ConsoleKey.W)
            {
                Console.Beep(Hertz[1], 400);
                Console.WriteLine(noty[1]);
            }
            else if (key.Key == ConsoleKey.S)
            {
                Console.Beep(Hertz[2], 400);
                Console.WriteLine(noty[2]);
            }
            else if (key.Key == ConsoleKey.E)
            {
                Console.Beep(Hertz[3], 400);
                Console.WriteLine(noty[3]);
            }
            else if (key.Key == ConsoleKey.D)
            {
                Console.Beep(Hertz[4], 400);
                Console.WriteLine(noty[4]);
            }
            else if (key.Key == ConsoleKey.F)
            {
                Console.Beep(Hertz[5], 400);
                Console.WriteLine(noty[5]);
            }
            else if (key.Key == ConsoleKey.T)
            {
                Console.Beep(Hertz[6], 400);
                Console.WriteLine(noty[6]);
            }
            else if (key.Key == ConsoleKey.G)
            {
                Console.Beep(Hertz[7], 400);
                Console.WriteLine(noty[7]);
            }
            else if (key.Key == ConsoleKey.Y)
            {
                Console.Beep(Hertz[8], 400);
                Console.WriteLine(noty[8]);
            }
            else if (key.Key == ConsoleKey.H)
            {
                Console.Beep(Hertz[9], 400);
                Console.WriteLine(noty[9]);
            }
            else if (key.Key == ConsoleKey.U)
            {
                Console.Beep(Hertz[10], 400);
                Console.WriteLine(noty[10]);
            }
            else if (key.Key == ConsoleKey.J)
            {
                Console.Beep(Hertz[11], 400);
                Console.WriteLine(noty[11]);
            }
            else if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
            {
                return;
            }
            key = Console.ReadKey(true);
        }
       
    }
}


/*Должны быть и белые и черные клавиши. Клавиши пианино это ваши клавиши на клавиатуре
Должно быть переключение между октавами по нажатию клавиш F1, F2, F3 и т.п., зависит от того, сколько октав у вас будет
Каждая октава должна хранится в массиве
(например, int[] firstOctave = new int[] { 200, 300, 400 }, каждое значение - частота волны ноты в герцах.
    Так для каждой октавы)
Вывод звука должен быть в отдельном методе. Изменение октавы должно быть в отдельном методе,
    метод должен вернуть нужный массив звуков. Остальные методы по желанию*/