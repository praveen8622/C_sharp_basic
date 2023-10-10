namespace ADO_NETv1
{
    partial class SearchRecord
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
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(436, 283);
            button2.Name = "button2";
            button2.Size = new Size(121, 52);
            button2.TabIndex = 14;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(254, 283);
            button1.Name = "button1";
            button1.Size = new Size(121, 52);
            button1.TabIndex = 13;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 179);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 12;
            label3.Text = "ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 111);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 11;
            label2.Text = "NAME";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 15;
            label1.Text = "ID";
            // 
            // SearchRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "SearchRecord";
            Text = "SearchRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}