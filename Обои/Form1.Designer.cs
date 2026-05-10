namespace Обои
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Ширина, см";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Высота, см";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 93);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Материал";
            // 
            // label4
            // 
            label4.Location = new Point(41, 161);
            label4.Name = "label4";
            label4.Size = new Size(240, 51);
            label4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(41, 125);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox1_TextChanged;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.KeyPress += comboBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 221);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Жалюзи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}
