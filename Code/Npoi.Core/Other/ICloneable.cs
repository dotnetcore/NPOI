namespace System
{
#if !NET46
    public interface ICloneable
    {
        object Clone();
    }
#endif
}