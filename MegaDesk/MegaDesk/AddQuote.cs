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
    public partial class AddQuote : Form
    {
        DateTime dateToday = DateTime.Now.Date;
        Desk desk;
        DeskQuote quote;
        int deskArea;
        String rush;
        DisplayQuote displayQuoteView;
        MainMenu quoteToMenu;

        public AddQuote()
        {
            InitializeComponent();
            desk = new Desk();
            quote = new DeskQuote();

            dateField.Text = $"{dateToday:dd MMMM yyyy}";
            quote.PurchaseDate = $"{dateToday:dd MMMM yyyy}";

            selectWidthField.Minimum = Desk.MIN_WIDTH;
            selectWidthField.Maximum = Desk.MAX_WIDTH;
            selectDepthField.Minimum = Desk.MIN_DEPTH;
            selectDepthField.Maximum = Desk.MAX_DEPTH;
            selectDrawersField.Minimum = Desk.DRAWER_MIN;
            selectDrawersField.Maximum = Desk.DRAWER_MAX;

            deskMaterialField.Items.Add(DesktopMaterial.Laminate);
            deskMaterialField.Items.Add(DesktopMaterial.Oak);
            deskMaterialField.Items.Add(DesktopMaterial.Pine);
            deskMaterialField.Items.Add(DesktopMaterial.Rosewood);
            deskMaterialField.Items.Add(DesktopMaterial.Veneer);
            deskMaterialField.DropDownStyle = ComboBoxStyle.DropDown;

            RushOrderField.Items.Add("No rush");
            RushOrderField.Items.Add("3 Days");
            RushOrderField.Items.Add("5 Days");
            RushOrderField.Items.Add("7 Days");
            RushOrderField.DropDownStyle = ComboBoxStyle.DropDown;

            displayQuoteForm.Enabled = false;
        }

        private void displayQuoteForm_Click(object sender, EventArgs e)
        {
            quote.FirstName = firstNameField.Text;
            quote.LastName = lastNameField.Text;
            desk.Width = (int)selectWidthField.Value;
            desk.Depth = (int)selectDepthField.Value;
            desk.DrawerNum = (int)selectDrawersField.Value;
            desk.MaterialType = deskMaterialField.SelectedItem.ToString();
            rush = RushOrderField.SelectedItem.ToString();

            deskArea = quote.buildDesk(desk.Width, desk.Depth);
            quote.TotalCost = quote.calcCost(deskArea, desk.DrawerNum, desk.MaterialType);

            if (rush != "no rush")
            {
                if (rush == "3 Days")
                {
                    quote.RushCost = quote.calcRush(deskArea, 3);
                }
                else if (rush == "5 Days")
                {
                    quote.RushCost = quote.calcRush(deskArea, 5);
                }
                else // 7 days
                {
                    quote.RushCost = quote.calcRush(deskArea, 7);
                }
                quote.TotalCost += quote.RushCost;
            }

            quote.saveQuote();

            if (displayQuoteView == null)
            {
                displayQuoteView = new DisplayQuote();
            }
            Hide();
            displayQuoteView.Show();
        }

        private void addQuoteMain_Click(object sender, EventArgs e)
        {
            if (quoteToMenu == null)
            {
                quoteToMenu = new MainMenu();
            }
            Hide();
            quoteToMenu.Show();
        }

        private void input_firstName_Validating(object sender, CancelEventArgs e)
        {
            if (firstNameField.Text == string.Empty)
            {
                MessageBox.Show("Please enter the first name");
                firstNameField.BackColor = Color.LightPink;
            }
            else
            {
                firstNameField.BackColor = SystemColors.Window;
            }

            checkValidEntries();
        }
        private void input_lastName_Validating(object sender, CancelEventArgs e)
        {
            if (lastNameField.Text == string.Empty)
            {
                MessageBox.Show("Please enter the last name");
                lastNameField.BackColor = Color.LightPink;
            }
            else
            {
                lastNameField.BackColor = SystemColors.Window;
            }

            checkValidEntries();
        }
        private void input_deskMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (deskMaterialField.Text == string.Empty)
            {
                MessageBox.Show("Please select the material");
                deskMaterialField.BackColor = Color.LightPink;
            }
            else
            {
                deskMaterialField.BackColor = SystemColors.Window;
            }

            checkValidEntries();
        }
        private void input_rush_Validating(object sender, CancelEventArgs e)
        {
            if (RushOrderField.Text == string.Empty)
            {
                MessageBox.Show("Please select a rush option");
                RushOrderField.BackColor = Color.LightPink;
            }
            else
            {
                RushOrderField.BackColor = SystemColors.Window;
            }

            checkValidEntries();
        }

        private void selectWidthField_Validating(object sender, CancelEventArgs e)
        {
            if (desk.Width.GetType() == typeof(int)) {
                if (desk.Width >= Desk.MIN_WIDTH && desk.Width <= Desk.MAX_WIDTH)
                {
                    selectWidthField.BackColor = SystemColors.Window;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid option");
                selectWidthField.BackColor = Color.LightPink;
            }

            checkValidEntries();
        }

        private void selectDepthField_Validating(object sender, CancelEventArgs e)
        {
            if (desk.Depth.GetType() == typeof(int))
            {
                if (desk.Depth >= Desk.MIN_DEPTH && desk.Depth <= Desk.MAX_DEPTH)
                {
                    selectDepthField.BackColor = SystemColors.Window;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid option");
                selectDepthField.BackColor = Color.LightPink;
            }

            checkValidEntries();
        }

        private void selectDepthField_KeyUp(object sender, KeyEventArgs e)
        {
            char test = (char) desk.Depth;
            if (char.IsDigit(test))
            {
                checkValidEntries();
            }
        }

        private void checkValidEntries()
        {
            if (firstNameField.Text != string.Empty &&
            lastNameField.Text != string.Empty &&
            deskMaterialField.Text != string.Empty &&
            RushOrderField.Text != string.Empty)
            {
                displayQuoteForm.Enabled = true;
            }
        }
    }
}
