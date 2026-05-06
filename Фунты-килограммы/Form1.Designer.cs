namespace Фунты_килограммы
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
            buttonOk = new Button();
            label1 = new Label();
            textBoxInput = new TextBox();
            label_output = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(109, 61);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(100, 24);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Вес в фунтах";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(109, 23);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(238, 23);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            textBoxInput.KeyPress += textBoxInput_KeyPress;
            // 
            // label_output
            // 
            label_output.Location = new Point(26, 100);
            label_output.Name = "label_output";
            label_output.Size = new Size(321, 35);
            label_output.TabIndex = 3;
            label_output.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 161);
            Controls.Add(label_output);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Controls.Add(buttonOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фунты-килограммы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Label label1;
        private TextBox textBoxInput;
        private Label label_output;
    }
}
