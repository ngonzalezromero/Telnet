using System.Threading;
using System.Threading.Tasks;

namespace PrimS.Telnet
{
    /// <summary>
    /// An implementation of a network stream to read from and write to.
    /// </summary>
    public class NetworkStream : INetworkStream
    {
        private readonly System.Net.Sockets.NetworkStream stream;

        /// <summary>
        /// Initialises a new instance of the <see cref="NetworkStream" /> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public NetworkStream(System.Net.Sockets.NetworkStream stream)
        {
            this.stream = stream;
        }

        /// <summary>
        /// Reads the next byte.
        /// </summary>
        /// <returns>
        /// The next byte read.
        /// </returns>
        public int ReadByte()
        {
            return this.stream.ReadByte();
        }

        /// <summary>
        /// Writes the byte.
        /// </summary>
        /// <param name="value">The value to write.</param>
        public void WriteByte(byte value)
        {
            this.stream.WriteByte(value);
        }

        /// <summary>
        /// Writes the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="count">The count.</param>
        /// <param name="cancellationToken">The cancellationToken.</param>
        /// <returns>
        /// An awaitable task.
        /// </returns>
        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return this.stream.WriteAsync(buffer, offset, count, cancellationToken);
        }

    }
}