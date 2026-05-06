namespace WinFormsApp1
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
            label_in = new Label();
            textBox1 = new TextBox();
            label_out = new Label();
            button_calc = new Button();
            SuspendLayout();
            // 
            // label_in
            // 
            label_in.Anchor = AnchorStyles.Left;
            label_in.AutoSize = true;
            label_in.Location = new Point(11, 28);
            label_in.Name = "label_in";
            label_in.Size = new Size(77, 15);
            label_in.TabIndex = 0;
            label_in.Text = "Вес в фунтах";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label_out
            // 
            label_out.BorderStyle = BorderStyle.Fixed3D;
            label_out.Location = new Point(94, 67);
            label_out.Name = "label_out";
            label_out.Size = new Size(208, 27);
            label_out.TabIndex = 2;
            // 
            // button_calc
            // 
            button_calc.BackgroundImageLayout = ImageLayout.None;
            button_calc.Location = new Point(11, 67);
            button_calc.Name = "button_calc";
            button_calc.Size = new Size(63, 30);
            button_calc.TabIndex = 3;
            button_calc.Text = "OK";
            button_calc.UseVisualStyleBackColor = true;
            button_calc.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 146);
            Controls.Add(button_calc);
            Controls.Add(label_out);
            Controls.Add(textBox1);
            Controls.Add(label_in);
            Name = "Form1";
            Text = "Перевод фунтов в килограммы";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_in;
        private TextBox textBox1;
        private Label label_out;
        private Button button_calc;
    }
}
