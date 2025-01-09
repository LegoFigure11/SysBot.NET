using System.Threading;
using System.Threading.Tasks;

namespace SysBot.Base
{
    /// <summary>
    /// Bare minimum methods required to interact with a <see cref="IConsoleConnection"/> in an asynchronous manner.
    /// </summary>
    public interface IConsoleConnectionAsync : IConsoleConnection
    {
        Task<int> SendAsync(byte[] buffer, CancellationToken token);

        Task<byte[]> ReadBytesAsync(ulong offset, int length, CancellationToken token);
        Task WriteBytesAsync(byte[] data, ulong offset, CancellationToken token);
        Task<byte[]> PixelPeek(CancellationToken token);
        Task<long> GetUnixTime(CancellationToken token);
        Task ResetTime(CancellationToken token);
        Task TimeSkipForward(CancellationToken token);
        Task DaySkip(CancellationToken token);
        Task DaySkipBack(CancellationToken token);
        Task ResetTimeNTP(CancellationToken token);
    }
}
