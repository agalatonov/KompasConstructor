using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompasConstructor.Core.Entities
{
    public class DrillParams
    {
        public string Length { get; }

        public DrillParams(string length)
        {
            Length = length;
        }
    }
}
