namespace ADO_NETv1
{
    partial class SearchUpdate
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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 63);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // button2
            // 
            button2.Location = new Point(520, 307);
            button2.Name = "button2";
            button2.Size = new Size(121, 52);
            button2.TabIndex = 22;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(207, 307);
            button1.Name = "button1";
            button1.Size = new Size(121, 52);
            button1.TabIndex = 21;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 203);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 20;
            label3.Text = "ADDRESS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 135);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 19;
            label2.Text = "NAME";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(269, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 31);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 31);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(363, 307);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 24;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // SearchUpdate
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
            Name = "SearchUpdate";
            Text = "SearchUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
    }
}