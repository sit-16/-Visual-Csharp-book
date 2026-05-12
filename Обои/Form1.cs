using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Обои
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int> BlindsTypes = new Dictionary<string, int>()
        {
            {"пластик", 50},
            {"алюминий", 100},
            {"бамбук", 75},
            {"соломка", 70},
            {"текстиль", 60}
        };
        public Dictionary<string, int> BlindsTypesSorted = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            string[] BlindsNames = BlindsTypes.Keys.ToArray();
            BlindsNames.Sort();
            foreach (var item in BlindsNames)
            {
                this.comboBox1.Items.Add(item);
                BlindsTypesSorted.Add(item, BlindsTypes[item]);
            }
            this.comboBox1.SelectedIndex = 0;
            this.button1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(this.textBox1) && this.textBox1.Text.Length > 0)
                        this.textBox2.Focus();
                    else if (sender.Equals(this.textBox2) && this.textBox2.Text.Length > 0)
                        this.comboBox1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] listBlinds = BlindsTypesSorted.Keys.ToArray();
            if (char.IsLetter(e.KeyChar))
                for (int i = 0; i < listBlinds.Length; i++)
                    if (listBlinds[i].StartsWith(char.ToLower(e.KeyChar)))
                        this.comboBox1.SelectedIndex = i;
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    this.button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "")
                this.button1.Enabled = true;
            else this.button1.Enabled = false;
            this.label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            int l = int.TryParse(this.textBox1.Text, out res) ? res : 0;
            int w = int.TryParse(this.textBox2.Text, out res) ? res : 0;
            int cost = BlindsTypesSorted[this.comboBox1.Text];
            decimal price =  l * w / 1000 * cost;
            this.label4.Text = $"Размеры: высота {l} см, шрина {w} см " +
                $"\nМатериал: {this.comboBox1.Text}" +
                $"\nЦена: {price:f2} руб./м.кв.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label4.Text = "";
        }
    }
}
