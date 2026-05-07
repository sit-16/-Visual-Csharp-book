namespace Фото
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
            this.label1.Text = string.Empty;
            this.button1.Enabled = false;
        }



        private void radioButton1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cost = 0m;
            decimal summ = 0m;
            int number = int.TryParse(textBox1.Text, out int res) ? res : 0;
            if (radioButton1.Checked) cost = 0.1m;
            else if (radioButton2.Checked) cost = 0.2m;
            else if (radioButton3.Checked) cost = 0.3m;
            summ = number * cost;
            label1.Text = $"Цена: {cost:f2} \u20BD\nКоличество: {number} шт.\nСумма заказа: {summ:f2} \u20BD";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter && textBox1.Text.Length > 0)
                    this.button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) this.button1.Enabled = true;
            else this.button1.Enabled = false;
        }
    }
}
