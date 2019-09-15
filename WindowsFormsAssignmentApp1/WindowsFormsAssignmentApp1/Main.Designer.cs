namespace WindowsFormsAssignmentApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coffeeShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.class3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coffeeShopToolStripMenuItem,
            this.class3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coffeeShopToolStripMenuItem
            // 
            this.coffeeShopToolStripMenuItem.Name = "coffeeShopToolStripMenuItem";
            this.coffeeShopToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.coffeeShopToolStripMenuItem.Text = "Coffee Shop";
            this.coffeeShopToolStripMenuItem.Click += new System.EventHandler(this.coffeeShopToolStripMenuItem_Click);
            // 
            // class3ToolStripMenuItem
            // 
            this.class3ToolStripMenuItem.Name = "class3ToolStripMenuItem";
            this.class3ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.class3ToolStripMenuItem.Text = "Class3";
            this.class3ToolStripMenuItem.Click += new System.EventHandler(this.class3ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coffeeShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem class3ToolStripMenuItem;
    }
}