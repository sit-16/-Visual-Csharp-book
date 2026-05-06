namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_calc.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
                if (textBox1.Text.Contains(',') || textBox1.Text.Length == 0)
                    e.Handled = true;
                else return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) this.button_calc.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label_out.Text = string.Empty;
            if (textBox1.Text.Length == 0)
                this.button_calc.Enabled = false;
            else
                this.button_calc.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            double funt = Double.TryParse(textBox1.Text, out funt) ? funt : 0;
            double kg = funt * 0.4095;
            this.label_out.Text = $"{funt:n3} f = {kg:n3} кг";
        }
    }
}
