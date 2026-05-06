namespace Конвертор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tBoxText = sender.Equals(this.textBox1) ? textBox1.Text : textBox2.Text;
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',' && tBoxText.Length > 0 && tBoxText.IndexOf(',') == -1) return;
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty) this.button1.Enabled = true;
            else
            {
                this.button1.Enabled = false;
                this.label3.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal res;
            decimal rate = decimal.TryParse(textBox1.Text, out res) ? res : 0;
            decimal price = decimal.TryParse(textBox2.Text, out res) ? res : 0;
            res = rate * price;
            this.label3.Text = $"{res:F2} \u20BD";
        }
    }
}
