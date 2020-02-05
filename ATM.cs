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
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public  EventHandler RussianLangClick;
        private void RussianLang_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("");
            RussianLangClick.Invoke(sender, e); 
        }
        public EventHandler BelorussianLangClick;
        private void BelorussianLang_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("be-BY");
            BelorussianLangClick.Invoke(sender, e);
        }
        public EventHandler PolskiLangClick;
        private void PolskiLang_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("pl-PL");
            PolskiLangClick.Invoke(sender, e);
        }
        public EventHandler EnglishLangClick;
        private void EnglishLang_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en");
            EnglishLangClick.Invoke(sender, e);
        }
    }
}
