public class ClassEnum
{
    public Values Value;
    public enum Values
    {
        Magenta = 0b0001,
        Cyan = Magenta << 1,
        Yellow = Magenta << 2,
        // 
        Red = Magenta | Cyan,
        Green = Yellow | Cyan,
        Orange = Magenta | Yellow
    }

}