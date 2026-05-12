using System.Security.Cryptography.Pkcs;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        private const int bw = 40, bh = 22; // размер кнопок
        private const int dx = 5, dy = 5; // растояние между кнопками
        private Button[] btn = new Button[15];
        char[] btnText = {'7','8','9','+',
                          '4','5','6','-',
                          '1','2','3','=',
                          '0', ',', 'c' };
        int[] btnTag = {7, 8, 9, -3,
                        4, 5, 6, -4,
                        1, 2, 3, -2,
                        0, -1, -5 };
        private double ac = 0; // аккумулятор
        private int op = 0; // код операции
        private Boolean fd = true;
        // fd == true - ждём первую цифру числа,
        // например после нажатия кнопки "+"
        // fd == false - ждём слудующую цифру

        public Form1()
        {
            InitializeComponent();
            // установить размер клиентской области формы
            this.ClientSize =
                new Size(4 * bw + 5 * dx, 5 * bh + 7 * dy);
            this.label1.SetBounds(dx, dy, 4 * bw + 3 * dx, bh);
            this.label1.Text = "0";

            // создать кнопки
            int k = 0;
            int x, y;

            y = label1.Bottom + dy;
            for (int i = 0; i < 4; i++)
            {
                x = dx;
                for (int j = 0; j < 4; j++)
                {
                    if (!((i == 3) && (j == 0)))
                    {
                        //создать и настроить кнопку
                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();
                        //задать функцию обработки события Click                       
                        this.btn[k].Click += Button_Click;
                        // кнопка операции
                        if (btnTag[k] < 0)
                        {
                            btn[k].BackColor = SystemColors.ControlLight;
                        }
                        //поместить кнопку на форму
                        this.Controls.Add(btn[k]);
                        x += bw + dx;
                        k++;
                    }
                    else
                    {
                        //создать и настроить кнопку 0
                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, 2 * bw + dx, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();
                        //задать функцию обработки события Click                       
                        this.btn[k].Click += Button_Click;
                        //поместить кнопку на форму
                        this.Controls.Add(btn[k]);
                        x += 2 * bw + 2 * dx;
                        k++;
                        j++;
                    }                    

                }
                y += bh + dy;
            }
        }
        private void Button_Click(object? sender, System.EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn == null) return;
            if (Convert.ToInt32(btn.Tag) > 0)
            {
                if (fd)
                {
                    // на индикаторе 0, это первая цифра
                    this.label1.Text = btn.Text;
                    fd = false;
                }
                else
                {
                    this.label1.Text += btn.Text;
                    return;
                }
            }
            //ноль
            if (Convert.ToInt32(btn.Tag) == 0)
            {
                if (fd) this.label1.Text = btn.Text;
                if (this.label1.Text != "0") this.label1.Text += btn.Text;
                return;
            }
            //запятая
            if (Convert.ToInt32(btn.Tag) == -1)
            {
                if (fd)
                {
                    this.label1.Text = "0,";
                    fd = false;
                }
                else if (!this.label1.Text.Contains(',')) this.label1.Text += btn.Text;
                return;
            }
            //"c" - очистить
            if (Convert.ToInt32(btn.Tag) == -5)
            {
                this.label1.Text = "0";
                fd = true;
                ac = 0;
                op = 0;
                return;
            }
            // кнопки "+","-","="
            if (Convert.ToInt32(btn.Tag) < -1)
            {
                double n; // число на индикаторе
                n = Convert.ToDouble(this.label1.Text);
                //Нажатие клавиши операции означает что пользователь ввёл операнд.
                //Если в аккомуляторе есть число, то выполним операцию.
                //Иначе запомним операцию, что выполнить при следующем нажатии клавиши операции.
                if (ac != 0)
                {
                    switch (op)
                    {
                        case -3:
                            ac += n;
                            break;
                        case -4:
                            ac -= n;
                            break;
                        case -2:
                            ac = n;
                            break;
                    }
                    this.label1.Text = ac.ToString();
                }
                else
                {
                    ac = n;
                }

                op = Convert.ToInt32(btn.Tag);
                fd = true;

            }
        }
    }
}
