using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.EnumerableMethods
{
    public class OrderByMethod
    {
        public static IEnumerable<Band> OrderByNameSql(IEnumerable<Band> fullBandsInfo)
        {
            return from band in fullBandsInfo
                   orderby band.Name
                   select band;
        }

        public static IEnumerable<Band> OrderByNameLinq(IEnumerable<Band> fullBandsInfo)
        {
            return fullBandsInfo.OrderBy(band => band.Name);
        }
    }
}   
