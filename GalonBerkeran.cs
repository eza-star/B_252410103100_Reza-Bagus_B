using System;
using System.Collections.Generic;
using System.Text;

namespace UTSPBO
{
    internal class GalonBerkeran(string v1, string v2, int v3, string v4)
    {
        private string v1 = v1;
        private string v2 = v2;
        private int v3 = v3;
        private string v4 = v4;

        public required string JenisKeran { get; internal set; }

        public static implicit operator GalonBerkeran((string, string, int, string) v)
        {
            throw new NotImplementedException();
        }
    }
}
