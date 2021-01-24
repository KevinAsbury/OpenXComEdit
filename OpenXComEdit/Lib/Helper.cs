using System;

namespace OpenXComEdit.Lib
{
    public static class Helper
    {
        public static ulong LongRandom()
        {
            byte[] buf = new byte[8];
            new Random().NextBytes(buf);
            ulong longRand = BitConverter.ToUInt64(buf, 0);

            return (longRand % (ulong.MaxValue - 1)) + 1;
        }
    }
}