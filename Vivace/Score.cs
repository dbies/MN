using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace
{
    class Score
    {
        private string composer;
        private string arranger;
        private string lyricist;
        private string title;
        private string copyright;
        public string Composer 
        { 
             get { return composer; } 
             set { this.composer = value; } 
        }
        public string Arranger 
        {
            get { return arranger; }
            set { this.arranger = value; } 
        }
        public string Lyricist 
        {
            get { return lyricist; }
            set { this.lyricist = value; } 
        }
        public string Title 
        {
            get { return title; }
            set { this.title = value; } 
        }
        public string Copyright 
        {
            get { return copyright; }
            set { this.copyright = value; } 
        } //what is stored in here?
        List<Staff> staves = new List<Staff>();
        int numMeasures;
        List<string> instruments; //This is necessary for when data is passed to the Edit score screen.
                                    //It is passed as a score object and I believe only one object can be passed. Therefore, to 
                                    //instantiate the staves with the correct instruments we need this. We can just delete the info after
                                    //if we're that worried about a teensy bit of data hanging around here. 

        public Score(string composer, string arranger, string lyricist, string title, string copyright, int numMeasures)
        {
            this.composer = composer;
            this.arranger = arranger;
            this.lyricist = lyricist;
            this.title = title;
            this.copyright = copyright;
            this.numMeasures = numMeasures;
        }
        public int NumberOfInstruments() { return instruments.Count; }
        public void addInstruments(List<string> instruments)
        {
            this.instruments = instruments;
        }

        public override string ToString()
        {
            //check if null?
            return "debug::mscore.toString() -- " + composer + arranger + lyricist + title + copyright;
        }
        bool OpenXML() { return false; } // should return boolean indicating success as is kind of standard practice
        bool SaveXML() { return false;  } // same as OpenXML bool reasoning
        bool CreateNewStaff() { return false;  }
        string GetStaffInfo() { return ""; } //unsure of the return type of this function, also, it seems as if it should have parameters to indicate which staff
        void SendPlaybackInfo() { } //also seems like it needs parameters, maybe return type
        public void Initialize()
        {
            if (staves.Count==0)
            {
                for (int i = 0; i < instruments.Count; i++)
                {
                    Staff mStaff = new Staff(numMeasures, instruments[i]);
                    staves.Add(mStaff);
                }
            }
            return;
        }
        public Staff GetStaff(int ct)
        {
            return staves[ct];
        }
    }
}
