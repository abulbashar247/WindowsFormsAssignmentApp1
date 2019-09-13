using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAssignmentApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderprice = "";

            if (orderComboBox.Text == "Black")
            {
                orderprice = 120;
            }
            if (orderComboBox.Text == "Cold")
            {
                orderprice = 120;
            }
            if (orderComboBox.Text == "Hot")
            {
                orderprice = 120;
            }
            if (orderComboBox.Text == "Reguler")
            {
                orderprice = 120;
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string customername = "";
            string contactno = "";
            string address = "";

            string order;
            string quantity;

            int ordertotal;

            customername = customerNameTextBox.Text;
            contactno = contactNoTextBox.Text;
            address = addressTextBox.Text;

            
            quantity = quantityTextBox.Text;


            ordertotal = (orderprice * quantity);
           


            showRichTextBox.Text = ( customername + contactno + address);
        }

        
    }
}
