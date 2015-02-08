using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace
{
    class Measure
    {
        Tuple<int, int> timeSignature;
        int tempo;
        List<Note> notes;
        bool full;

        public Measure()
        {
            this.tempo = -1;
            this.notes = new List<Note>();
            this.timeSignature = null;
            full = false;
        }
        public void CreateNewNote(Note nt) 
        {
            if (NoteFits(nt))
            {
                notes.Add(nt);
            }
        } //maybe bool
        string GetNoteInfo() { return ""; } //unsure of return type;
        public bool IsFull()
        { 
            return full;
        }
        public bool NoteFits(Note nt) { return true; }
    }
}
