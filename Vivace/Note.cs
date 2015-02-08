using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace
{
    class Note
    {
        private int rhythm;
        private int pitch;
        private int volume;

        public Note()
        {
            rhythm = -1;
            pitch = -1;
            volume = -1;
        }
        public Note(string rh)
        {
            switch (rh){
                case "Whole Note": rhythm=4; break;
                case "Eight Note":break;
                case "Quarter Note":break;
                case "Half Note":break;
                case "Sixteenth Note":break;
                case "Multi Rest":break;
                case "Whole Rest":break;
                case "Half Rest":break;
                case "Quarter Rest":break;
                case "Eight Rest":break;
            }
            pitch = -1;
            volume = -1;
        }
        public int Rhythm
        {
            get { return rhythm; }
        }
        public int Pitch
        {
            get { return pitch; }
        }
        public int Volume
        {
            get { return volume; }
        }
        
    }
}
