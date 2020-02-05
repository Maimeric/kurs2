using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Presentors;

namespace ATM.Presentors
{
    class PresentorATM
    {
        Model myModel;
        ATM atm;

        public PresentorATM(ATM view, Model m)
        {
            atm = view;
            myModel = m;
            atm.RussianLangClick += RussianLangClickHandeler;
            atm.BelorussianLangClick += BelorussianLangClickHandler;
            atm.PolskiLangClick += PolskiLangClickHandlerHandler;
            atm.EnglishLangClick += EnglishLangClickHandler;
        }
        void RussianLangClickHandeler(object sender, EventArgs e)
        {
            atm.Hide();
            ATMInput ATMInput = new ATMInput();
            _ = new PresentorATMInput(ATMInput, myModel);
            ATMInput.ShowDialog();
            ATMInput.Close();
            atm.Show();
        }
        
        void BelorussianLangClickHandler(object sender, EventArgs e)
        {
            atm.Hide();
            ATMInput ATMInput = new ATMInput();
            _ = new PresentorATMInput(ATMInput, myModel);
            ATMInput.ShowDialog();
            atm.Show();
        }

        void PolskiLangClickHandlerHandler(object sender,EventArgs e)
        {
            atm.Hide();
            ATMInput ATMInput = new ATMInput();
            _ = new PresentorATMInput(ATMInput, myModel);
            ATMInput.ShowDialog();
            atm.Show();
        }

        void EnglishLangClickHandler(object sender, EventArgs e)
        {
            atm.Hide();
            ATMInput ATMInput = new ATMInput();
            _ = new PresentorATMInput(ATMInput, myModel);
            ATMInput.ShowDialog();
            atm.Show();
        }

    }
}
