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
        double itemPrice;
        public Home()
        {
            InitializeComponent();
       
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ordercombobox;
            ordercombobox = orderComboBox.Text;
            

            if (ordercombobox.ToString() == "Black")
            {
                itemPrice = 120;
            }
            if (ordercombobox.ToString() == "Cold")
            {
                itemPrice = 100;
            }
            if (ordercombobox.ToString() == "Hot")
            {
                itemPrice = 90;
            }
            if (ordercombobox.ToString() == "Reguler")
            {
                itemPrice = 80;
            }
            
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string customername = "";
            string contactno = "";
            string address = "";
            string item = "";
            string orderquantity = "";
            
            customername = customerNameTextBox.Text;
            contactno = contactNoTextBox.Text;
            address = addressTextBox.Text;
            item = orderComboBox.Text;
            orderquantity = quantityTextBox.Text;
            

            double unitprice = Convert.ToDouble(itemPrice);
            double quantity = Convert.ToDouble(quantityTextBox.Text);
            double grandtotal = unitprice * quantity;
            double total = grandtotal;
                    
            showRichTextBox.Text = ("Customer Name : " + customername + "\r" 
                         + "Contact No : " + contactno + "\r" 
                         + "Address : " + address + "\r" 
                         + "Item Name : " + item + "\r" 
                         + "Per Pcs Rate : " + itemPrice + "\r" 
                         + "Quantity : " + orderquantity + "\r"
                         + "Total Taka : " + total);

        }

    }
}
