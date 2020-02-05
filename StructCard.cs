using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class StructCard
    {
        public string numbcard { set; get; }        
        public int pasword { set; get; }
        public int balance { set; get; }
      //  public string cvcode { set; get; }

        public StructCard()
        {

        }
        public StructCard(string s, int a, int b)
        {
            numbcard = s;
            pasword = a;
            balance = b;
       //     cvcode = r;
        }
        public string getNumbcard()
        {
            return numbcard;
        }
        public int getPaswrod()
        {
            return pasword;
        }
        public int getBalance()
        {
            return balance;
        }
        public int setBalance(int numb)
        {
            return balance = numb;
        }
        //public string getCvcode()
        //{
        //    return cvcode;
        //}
    }
}
