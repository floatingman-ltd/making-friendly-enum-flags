using System;

namespace AsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var cyan = TypesEnum.Cyan;

            Console.WriteLine($">{new String('=', 10)} long hand with if {new String('=', 10)}<");
            if (((int)cyan & (int)FlagsEnum.Cyan) == (int)FlagsEnum.Cyan) Console.WriteLine($"Cyan contains cyan");
            if (((int)cyan & (int)FlagsEnum.Green) == (int)FlagsEnum.Cyan) Console.WriteLine($"Green contains cyan");
            if (((int)cyan & (int)FlagsEnum.Orange) == (int)FlagsEnum.Cyan) Console.WriteLine($"Orange contains cyan");
            else Console.WriteLine("Orange does not contain cyan");

            Console.WriteLine($">{new String('=', 10)} long hand with ?: {new String('=', 10)}<");
            Console.WriteLine($"Cyan {((((int)cyan & (int)FlagsEnum.Cyan) == (int)FlagsEnum.Cyan) ? "contains" : "does not contain")} cyan");
            Console.WriteLine($"Green {((((int)cyan & (int)FlagsEnum.Green) == (int)FlagsEnum.Cyan) ? "contains" : "does not contain")} cyan");
            Console.WriteLine($"Orange {((((int)cyan & (int)FlagsEnum.Orange) == (int)FlagsEnum.Cyan) ? "contains" : "does not contain")} cyan");

            Console.WriteLine($">{new String('=', 10)} HasFlag with ?: {new String('=', 10)}<");
            Console.WriteLine($"Cyan {(FlagsEnum.Cyan.HasFlag((FlagsEnum)cyan) ? "contains" : "does not contain")} cyan");
            Console.WriteLine($"Green {(FlagsEnum.Green.HasFlag((FlagsEnum)cyan) ? "contains" : "does not contain")} cyan");
            Console.WriteLine($"Orange {(FlagsEnum.Orange.HasFlag((FlagsEnum)cyan) ? "contains" : "does not contain")} cyan");
        }
    }
}
