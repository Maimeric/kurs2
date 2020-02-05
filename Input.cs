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
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        public EventHandler InputButtonClick;
        private void InputButton_Click(object sender, EventArgs e)
        {
            InputButtonClick.Invoke(sender, e);
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < TextInput.Text.Length; i++)
            {
                if (char.IsLetter(TextInput.Text[i]))
                {
                    TextInput.Text = TextInput.Text.Remove(i, 1);
                }
            };
        }
    }
}
