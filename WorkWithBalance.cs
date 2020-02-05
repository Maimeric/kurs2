using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class WorkWithBalance
    {
        public static int AddBalans(int numb, int balans)
        {
            balans += numb;
            return balans;
        }
        public static int CutBalans(int numb, int balans)
        {
            balans -= numb;
            return balans;
        }
        
    }
}
