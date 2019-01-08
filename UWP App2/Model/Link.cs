using System;

namespace UWP_App2.Model
{
    public sealed class Link
    {
        public string Text { get; internal set; }
        public Uri Target { get; internal set; }
    }
}
