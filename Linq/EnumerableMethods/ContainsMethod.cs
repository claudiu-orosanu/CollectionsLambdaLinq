using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.EnumerableMethods
{
    public class ContainsMethod
    {
        public static bool Contains(IEnumerable<Band> fullBandsInfo, Band band)
        {
            return fullBandsInfo.Contains(band);
        }
    }
}
