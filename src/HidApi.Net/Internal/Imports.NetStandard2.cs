#if NETSTANDARD2_0
using System.ComponentModel;

namespace System.Text
{
    internal static class EncodingExtensions
    {
        public static string GetString(this Encoding encoding, ReadOnlySpan<byte> bytes)
        {
            return encoding.GetString(bytes.ToArray());
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}
#endif
