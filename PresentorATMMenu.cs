using ATM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Presentors;
using System.Windows.Forms;
namespace ATM.Presentors
{
    class PresentorATMMenu
    {
        ATMMenu atmMenu;
        Model myModel;
        int i ;
        public PresentorATMMenu(ATMMenu view, Model m)
        {
            atmMenu = view;
            myModel = m;
            atmMenu.AddBalansButtonClick += AddBalansButtonClickHandel;
            atmMenu.BalanceButtonClic += BalanceButtonClicHandel;
            atmMenu.EndButtonClick += EndButtonClickHandel;
            atmMenu.CutBalanceButtonClick += CutBalanceButtonClickHandel;
          
        }

        void PolNaTelClickHandler(object sender, EventArgs e)
        {

        }

        void AddBalansButtonClickHandel(object sender, EventArgs e)
        {
            i = myModel.IndexOut();
            Input input = new Input();
            _ = new PresentorInput(input, myModel);
            input.ShowDialog();
            myModel.list()[i].setBalance(WorkWithBalance.AddBalans(myModel.InputNumbOut(), myModel.list()[i].getBalance()));
            IOF.OutputXmlFile(myModel.list());
            input.Close();
        }
        void BalanceButtonClicHandel(object sender,EventArgs e)
        {
            i = myModel.IndexOut();
            MessageBox.Show(myModel.list()[i].getBalance().ToString());
        }

        void CutBalanceButtonClickHandel(object sender, EventArgs e)
        {
            i = myModel.IndexOut();
            Input input = new Input();
            _ = new PresentorInput(input, myModel);
            input.ShowDialog();
            myModel.list()[i].setBalance(WorkWithBalance.CutBalans(myModel.InputNumbOut(), myModel.list()[i].getBalance()));
            IOF.OutputXmlFile(myModel.list());
            input.Close();
        }
        void EndButtonClickHandel(object sender, EventArgs e)
        {
            atmMenu.Hide();
        }
    }
}
