using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.View
{
    public partial class ATMMenu : Form
    {
        public ATMMenu()
        {
            InitializeComponent();
        }

        public EventHandler AddBalansButtonClick;
        private void AddBalansButton_Click(object sender, EventArgs e)
        {
            AddBalansButtonClick.Invoke(sender, e);
        }
        public EventHandler BalanceButtonClic;
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            BalanceButtonClic.Invoke(sender, e);
        }

        public EventHandler EndButtonClick;
        private void EndButton_Click(object sender, EventArgs e)
        {
            EndButtonClick.Invoke(sender, e);
        }

        public EventHandler CutBalanceButtonClick;
        private void CutBalanceButton_Click(object sender, EventArgs e)
        {
            CutBalanceButtonClick.Invoke(sender, e);
        }
       
    }
}
