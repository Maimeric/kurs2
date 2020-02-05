using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Presentors;
using ATM.View;
using System.IO.Ports;
namespace ATM.Presentors
{
    class PresentorATMInput
    {
        ATMInput atmInput;
        Model myModel;
        public PresentorATMInput(ATMInput view, Model m)
        {
            atmInput = view;
            myModel = m;
            atmInput.InputNumbCardClick += InputNumbCardClickHandeler;
        }
        void InputNumbCardClickHandeler(object sender, EventArgs e)
        {
            if (Check.ProvValidCard(atmInput.TextNumberCard.Text, atmInput.TextNumberCard.Text.Length))
            {
                int numb = 0;
                numb = IOF.InputXmlFile(numb, "Card.xml", myModel.list());
                for (int i = 0; i < numb; i++)
                {
                    if (myModel.equals(myModel.list()[i].getNumbcard(), atmInput.TextNumberCard.Text))
                    {
                        if (atmInput.TextPassword.Text ==myModel.list()[i].getPaswrod().ToString())
                        {                           
                            atmInput.Hide();
                            ATMMenu ATMMenu = new ATMMenu();
                            _ = new PresentorATMMenu(ATMMenu, myModel);
                            myModel.IndexIn(i);
                            ATMMenu.ShowDialog();
                            atmInput.Show();
                            atmInput.Hide();
                        }
                        else
                        {
                            atmInput.label3.Text = "Error Pasword";
                        }                       
                    }
                    else
                    {
                        atmInput.label3.Text = "Number Card is'n Valid";
                    }
                }
            }
        }
    }
}
