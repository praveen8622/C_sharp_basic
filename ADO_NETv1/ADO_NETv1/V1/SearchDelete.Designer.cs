namespace ADO_NETv1
{
    partial class SearchDelete
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
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(374, 322);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 33;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 78);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 32;
            label1.Text = "ID";
            // 
            // button2
            // 
            button2.Location = new Point(531, 322);
            button2.Name = "button2";
            button2.Size = new Size(121, 52);
            button2.TabIndex = 31;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 322);
            button1.Name = "button1";
            button1.Size = new Size(121, 52);
            button1.TabIndex = 30;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 218);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 29;
            label3.Text = "ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 150);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 28;
            label2.Text = "NAME";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 31);
            textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 31);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 25;
            // 
            // SearchDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "SearchDelete";
            Text = "SearchDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}