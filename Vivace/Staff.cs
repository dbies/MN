using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivace
{
    class Staff
    {
        List<Measure> measures;
        string instrument;

        public Staff(int numMeasures, string instrument)
        {
            measures = new List<Measure>();
            this.instrument = instrument;
            for (int i = 0; i < numMeasures; i++)
            {
                Measure mMeasure = new Measure();
                measures.Add(mMeasure);
            }
        }
        public void CreateNewMeasure() 
        {
            Measure m_measure = new Measure();
            measures.Add(m_measure);
        } 
        string GetMeasureInfo() { return ""; }//unsure of return type, also what parameters
        public Measure GetNextMeasure()
        {
            Measure current = null;
            for (int i=0; i<measures.Count; i++)
            {
                if (!measures[i].IsFull())
                {
                    current = measures[i];
                    break;
                }
            }
            return current;
        }
    }
}
