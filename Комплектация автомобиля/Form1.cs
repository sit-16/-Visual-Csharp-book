namespace Комплектация_автомобиля
{
    public partial class Form1 : Form
    {
        decimal baseCost = 1000000m;
        double discont = 0.01;
        public Form1()
        {
            InitializeComponent();
            this.label2.Text = $"Базовая цена: {baseCost:f2} \u20bd";
            this.label3.Text = string.Empty;
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            this.label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cost = baseCost;
            string st = "";
            if (this.checkBox1.Checked) cost += 100000;
            if (this.checkBox2.Checked) cost += 200000;
            if (this.checkBox3.Checked) cost += 300000;
            st = $"Цена в выбраной комплектации: {cost} \u20bd";

            if (this.checkBox1.Checked && this.checkBox2.Checked && this.checkBox3.Checked)
            {
                decimal disCost = cost * (decimal) discont;
                cost -= disCost;
                st += $"\nСкидка 1%: {disCost:f2} ₽\nИтоговая стоимость: {cost:f2} ₽";
            }
            this.label3.Text = st;
        }
    }
}
