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
    public partial class SearchQuotes : Form
    {
        MainMenu searchQuotesToMenu;
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            if (searchQuotesToMenu == null)
            {
                searchQuotesToMenu = new MainMenu();
            }
            Hide();
            searchQuotesToMenu.Show();
        }
    }
}
