using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reapEAT
{
    class MeasureType
    {
        public byte id;
        public string plural;
        public string single;
        
        public MeasureType(byte id, string plural, string single)
        {
            this.id = id;
            this.plural = plural;
            this.single = single;
        }
    }
}
