using System.Diagnostics;

namespace ProtoZeroSharp;

[DebuggerDisplay("{Text}")]
internal class Utf8StringDebugView
{
    public Utf8StringDebugView(Utf8String utf8String)
    {
        Text = utf8String.ToString();
    }

    public string Text { get; }
}