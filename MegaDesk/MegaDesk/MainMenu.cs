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
    public partial class MainMenu : Form
    {
        AddQuote addQuote;
        ViewAllQuotes viewAllQuotes;
        SearchQuotes searchQuotes;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void new_quote_Click(object sender, EventArgs e)
        {
            if (addQuote == null)
            {
                addQuote = new AddQuote();
            }
            Hide();
            addQuote.Show();
        }

        private void view_quotes_Click(object sender, EventArgs e)
        {
            if (viewAllQuotes == null)
            {
                viewAllQuotes = new ViewAllQuotes();
            }
            Hide();
            viewAllQuotes.Show();
        }

        private void search_quotes_Click(object sender, EventArgs e)
        {
            if (searchQuotes == null)
            {
                searchQuotes = new SearchQuotes();
            }
            Hide();
            searchQuotes.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
