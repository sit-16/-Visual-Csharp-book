namespace Комплектация_автомобиля
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(216, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 186);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 1;
            label1.Text = "Renault Duster";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 67);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 2;
            label2.Text = "Базовая цена: 2930000 ₽";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 94);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(47, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "ABS";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(39, 119);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(163, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Противотуманные фары";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += checkBox1_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(39, 144);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(100, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Паркотроник";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Click += checkBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 183);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(216, 215);
            label3.Name = "label3";
            label3.Size = new Size(313, 44);
            label3.TabIndex = 7;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(541, 278);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Label label3;
    }
}
