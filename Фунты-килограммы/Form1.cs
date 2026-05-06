using Microsoft.VisualBasic;

namespace Фунты_килограммы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
                if (!textBoxInput.Text.Contains(',')) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (textBoxInput.Text.Length > 0)
                        buttonOk.Focus();
                }
                else return;
            }
            e.Handled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            double foot = Convert.ToDouble(textBoxInput.Text);
            double kg = foot * 132;
            this.label_output.Text = $"{foot.ToString("n")} футов = {kg.ToString("n")} кг";
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            this.label_output.Text = "";
        }
    }
}
