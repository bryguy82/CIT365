using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        MainMenu allQuotesToMenu;
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            if (allQuotesToMenu == null)
            {
                allQuotesToMenu = new MainMenu();
            }
            Hide();
            allQuotesToMenu.Show();
        }
    }
}