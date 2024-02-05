#if NETSTANDARD2_0 || DEFINE_ISEXTERNALINIT
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}
#endif