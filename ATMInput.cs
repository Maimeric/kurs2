using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class ATMInput : Form
    {
        public ATMInput()
        {
            InitializeComponent();
        }
        
        public EventHandler InputNumbCardClick;       
        private void InputNumbCard_Click(object sender, EventArgs e)
        {
            InputNumbCardClick.Invoke(sender,e);
        }

        private void TextNumberCard_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < TextNumberCard.Text.Length; i++)
            {
                if (char.IsLetter(TextNumberCard.Text[i]))
                {
                    TextNumberCard.Text = TextNumberCard.Text.Remove(i, 1);
                }
            };
        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < TextPassword.Text.Length; i++)
            {
                if (char.IsLetter(TextPassword.Text[i]))
                {
                    TextPassword.Text = TextPassword.Text.Remove(i, 1);
                }
            }
        }
    }
}
