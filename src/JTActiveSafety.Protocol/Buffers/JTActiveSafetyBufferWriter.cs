using System;

namespace JTActiveSafety.Protocol.Buffers
{
    /// <summary>
    /// 内存写入器
    /// ref:System.Buffers.Writer
    /// </summary>
    ref partial struct JTActiveSafetyBufferWriter
    {
        private Span<byte> _buffer;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        public JTActiveSafetyBufferWriter(Span<byte> buffer)
        {
            _buffer = buffer;
            WrittenCount = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        public Span<byte> Free => _buffer.Slice(WrittenCount);
        /// <summary>
        /// 
        /// </summary>
        public Span<byte> Written => _buffer.Slice(0, WrittenCount);
        /// <summary>
        /// 
        /// </summary>
        public int WrittenCount { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        public void Advance(int count)
        {
            WrittenCount += count;
        }
    }
}
