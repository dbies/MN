using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace
{
    static class NoteType
    {
        static public Dictionary<string, string> noteMap = new Dictionary<string, string>
        {
           {"Whole Note", "\uD834\uDD5D"},
           {"Eight Note", "\uD834\uDD60"},
           {"Quarter Note", "\uD834\uDD5F"},
           {"Half Note", "\uD834\uDD5E"},
           {"Sixteenth Note", "\uD834\uDD61"},
           {"Multi Rest", "\uD834\uDD3A"},
           {"Whole Rest", "\uD834\uDD3B"},
           {"Half Rest", "\uD834\uDD3C"},
           {"Quarter Rest", "\uD834\uDD3D"},
           {"Eight Rest", "\uD834\uDD3E"},
           {"Single Barline", "\uD834\uDD00"},
           {"Double Barline", "\uD834\uDD01"},
           {"Final Barline", "\uD834\uDD02"},
           {"Five Line Staff", "\uD834\uDD1A"}
        };
    }
}
