namespace ADO_NETv1
{
    partial class mainwindow
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
            menuStrip1 = new MenuStrip();
            formsToolStripMenuItem = new ToolStripMenuItem();
            connectDBToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            searchUpdateToolStripMenuItem = new ToolStripMenuItem();
            searchDeleteToolStripMenuItem = new ToolStripMenuItem();
            displayAllToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            formsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectDBToolStripMenuItem, insertToolStripMenuItem, searchToolStripMenuItem, searchUpdateToolStripMenuItem, searchDeleteToolStripMenuItem, displayAllToolStripMenuItem });
            formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            formsToolStripMenuItem.Size = new Size(78, 29);
            formsToolStripMenuItem.Text = "Forms";
            // 
            // connectDBToolStripMenuItem
            // 
            connectDBToolStripMenuItem.Name = "connectDBToolStripMenuItem";
            connectDBToolStripMenuItem.Size = new Size(270, 34);
            connectDBToolStripMenuItem.Text = "ConnectDB";
            connectDBToolStripMenuItem.Click += connectDBToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(270, 34);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(270, 34);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // searchUpdateToolStripMenuItem
            // 
            searchUpdateToolStripMenuItem.Name = "searchUpdateToolStripMenuItem";
            searchUpdateToolStripMenuItem.Size = new Size(270, 34);
            searchUpdateToolStripMenuItem.Text = "SearchUpdate";
            searchUpdateToolStripMenuItem.Click += searchUpdateToolStripMenuItem_Click;
            // 
            // searchDeleteToolStripMenuItem
            // 
            searchDeleteToolStripMenuItem.Name = "searchDeleteToolStripMenuItem";
            searchDeleteToolStripMenuItem.Size = new Size(270, 34);
            searchDeleteToolStripMenuItem.Text = "SearchDelete";
            searchDeleteToolStripMenuItem.Click += searchDeleteToolStripMenuItem_Click;
            // 
            // displayAllToolStripMenuItem
            // 
            displayAllToolStripMenuItem.Name = "displayAllToolStripMenuItem";
            displayAllToolStripMenuItem.Size = new Size(270, 34);
            displayAllToolStripMenuItem.Text = "DisplayAll";
            displayAllToolStripMenuItem.Click += displayAllToolStripMenuItem_Click;
            // 
            // Mainwindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Mainwindow";
            Text = "Mainwindow";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formsToolStripMenuItem;
        private ToolStripMenuItem connectDBToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem searchUpdateToolStripMenuItem;
        private ToolStripMenuItem searchDeleteToolStripMenuItem;
        private ToolStripMenuItem displayAllToolStripMenuItem;
    }
}