using System;

[Flags]
public enum FlagsEnum
{
    Black = 0b00000,
    Magenta = 0b0001,
    Cyan = Magenta << 1,
    Yellow = Magenta << 2,

    // 
    Red = Magenta | Cyan,
    Green = Yellow | Cyan,
    Orange = Magenta | Yellow

}