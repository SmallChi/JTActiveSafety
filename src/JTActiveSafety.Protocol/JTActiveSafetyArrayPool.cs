using System.Buffers;

namespace JTActiveSafety.Protocol
{
    internal static class JTActiveSafetyArrayPool
    {
        private readonly static ArrayPool<byte> ArrayPool;

        static JTActiveSafetyArrayPool()
        {
            ArrayPool = ArrayPool<byte>.Create();
        }

        public static byte[] Rent(int minimumLength)
        {
            return ArrayPool.Rent(minimumLength);
        }

        public static void Return(byte[] array, bool clearArray = false)
        {
            ArrayPool.Return(array, clearArray);
        }
    }
}
