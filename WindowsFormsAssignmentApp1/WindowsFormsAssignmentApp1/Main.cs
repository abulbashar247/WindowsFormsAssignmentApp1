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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void coffeeShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffee_Shop Main = new Coffee_Shop();
            // Set the parent form of the child window.  
            Main.MdiParent = this;
            // Display the new form.  
            Main.Show();
        }

        private void class3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3 Main = new Class3();
            // Set the parent form of the child window.  
            Main.MdiParent = this;
            // Display the new form.  
            Main.Show();
        }
    }
}
