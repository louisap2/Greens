using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greens
{
    public class GreensLogic
    {
        public int GetActiveGreensCount()
        {
            return GetActiveGreensCount("");
        }

        public int GetActiveGreensCount(string nameStart)
        {
            using (var db = new greens_dbEntities())
            {
                if (!string.IsNullOrEmpty(nameStart))
                {
                    return db.Greens.Where(s => s.name.StartsWith(nameStart)).Count();
                }
                else
                    return db.Greens.Count();
            }
        }
    }
}
