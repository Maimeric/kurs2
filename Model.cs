using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Model
    {
        List<StructCard> listStruct = new List<StructCard>();
        int index1 ;
        int InputNumb;
       
        public void InputNumbIn(int numb)
        {
            InputNumb = numb;
        }
        public int InputNumbOut()
        {
            return InputNumb;
        }
        public List<StructCard> list()
        {            
            return listStruct;
        }
        public void IndexIn(int index)
        {
            index1 = index;
        }
        public int IndexOut()
        {
            return index1;
        }

        public  bool equals(String str1, String str2)
        {
            return str1 == null ? str2 == null : str1 == str2;
        }       
    }
}
