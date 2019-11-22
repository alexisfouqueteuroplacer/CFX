using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFX.Structures
{
    public class StageExpectedCycleTime
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public StageExpectedCycleTime()
        {
            StageSequence = 1;
            ExpectedCycleTime = 0;
        }

        /// <summary>
        /// Sequence of this stage in the machine
        /// </summary>
        public int StageSequence
        {
            get;
            set;
        }

        /// <summary>
        /// The total amount of time that is expected to process one unit or group of units (as in the case of a carrier or panelized PCB), 
        /// assuming no blocked or starved conditions at the station. This includes both productive and non-productive time, such as transfer, 
        /// positioning, etc. but only for a given stage
        /// </summary>
        public double ExpectedCycleTime
        {
            get;
            set;
        }
    }
}
