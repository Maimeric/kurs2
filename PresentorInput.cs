using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.View;
using System.Windows.Forms;
namespace ATM.Presentors
{
    class PresentorInput
    {
        Input input;
        Model myModel;

        public PresentorInput(Input view, Model m)
        {
            input = view;
            myModel = m;
            input.InputButtonClick += InputButtonClickHandel;
           
        }
        void InputButtonClickHandel(object sender, EventArgs e)
        {
            int addnumb;
            do
            {
                addnumb = Convert.ToInt32(input.TextInput.Text) ;
                if (addnumb < 1)
                {
                  MessageBox.Show("Бессмысленый ввод, введите сумму больше 0.");
                }

            } while (addnumb<1);

            myModel.InputNumbIn(addnumb);
            input.Hide();
        }
    }
}
