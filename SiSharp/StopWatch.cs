using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiSharp
{
    class StopWatch
    {
        private readonly DateTime _start;
        private DateTime _end;
        
        public StopWatch()
        {
            _start = DateTime.Now;
        }

        public DateTime Start
        {
            get
            {
                return _start;
            }
        }

        public DateTime End
        {
            get
            {
                return _end;
            }
        }

        public TimeSpan TimeSpan ()
        {
            TimeSpan _result;

            _end = DateTime.Now;

            _result = End - Start;

            return _result;
        }

    }
}
