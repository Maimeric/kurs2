using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ATM
{
    class Check
    {
        //public static bool ShablonNomberOfCard(string str)
        //{
        //    Regex regex = new Regex(@"\d{4}-\d{4}-\d{4}");
        //    MatchCollection matches = regex.Matches(str);
        //    if (matches.Count > 0)
        //        return true;
        //    else
        //        return false;
        //}
        public static bool ProvValidCard(string NumbCard, int Lenght)
        {
            int summFerst = 0;
            int summAns = 0;
            if (Lenght % 2 == 0)
            {
                for (int i = 0; i < Lenght; i++)
                {
                    summFerst = int.Parse(NumbCard[i].ToString());
                    if ((i + 1) % 2 != 0)
                    {
                        summFerst *= 2;
                        if (summFerst > 9)
                        {
                            int tens, fersDig;
                            tens = summFerst % 10;
                            fersDig = summFerst / 10;
                            summAns += (tens + fersDig);
                        }
                        else
                            summAns += summFerst;
                    }
                    else
                        summAns += summFerst;
                }
            }
            else
            {
                for (int i = 0; i < Lenght; i++)
                {
                    summFerst = int.Parse(NumbCard[i].ToString());
                    if ((i + 1) % 2 == 0)
                    {
                        summFerst *= 2;
                        if (summFerst > 9)
                        {
                            int tens, fersDig;
                            tens = summFerst % 10;
                            fersDig = summFerst / 10;
                            summAns += (tens + fersDig);
                        }
                        else
                            summAns += summFerst;
                    }
                    else
                        summAns += summFerst;
                }
            }
            if (summAns % 10 == 0)
                return true;
            else
                return false;
        }//+
    }
}// посмотреть много поточность и почему вылазит раньше времениw