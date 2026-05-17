namespace Просмотр_иллюстраций
{
    public partial class Form1 : Form
    {
        int pbW, pbH, pbX, pbY;
        string aPath;
        public Form1()
        {
            InitializeComponent();
            pbW = pictureBox1.Width;
            pbH = pictureBox1.Height;
            pbX = pictureBox1.Location.X;
            pbY = pictureBox1.Location.Y;
            listBox1.Sorted = true;

            DirectoryInfo di;
            di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            aPath = di.FullName;

            //Сформировать список изображений
            FillListBox(aPath);
        }

        private Boolean FillListBox(string aPath)
        {
            DirectoryInfo di = new DirectoryInfo(aPath);
            FileInfo[] fi = di.GetFiles("*.jpg");
            listBox1.Items.Clear();
            foreach (var item in fi)
            {
                listBox1.Items.Add(item.Name);
            }
            label1.Text = aPath;
            if (fi.Length == 0) return false;
            else listBox1.SelectedIndex = 0;
            return true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double mh, mw;
            pictureBox1.Visible = false;
            pictureBox1.Left = pbX;
            pictureBox1.Top = pbY;
            // Загружаем изображение
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = new Bitmap(aPath + "\\" + listBox1.SelectedItem.ToString());
            if ((pictureBox1.Image.Width > pbW) || (pictureBox1.Image.Height > pbH))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                mh = (double)pbH / (double)pictureBox1.Image.Height;
                mw = (double)pbW / (double)pictureBox1.Image.Width;
                label2.Text = "mH - " + mh.ToString("F");
                label3.Text = "mW - " + mw.ToString("F");

                if (mw > mh)
                {
                    pictureBox1.Width = Convert.ToInt16(pictureBox1.Image.Width * mh);
                    pictureBox1.Height = pbH;
                }
                else
                {
                    pictureBox1.Width = pbW;
                    pictureBox1.Height = Convert.ToInt16(pictureBox1.Image.Height * mw);
                }
            }
            //разместить картинку в центре изображения 
            pictureBox1.Left = pbX + (pbW - pictureBox1.Width) / 2;
            pictureBox1.Top = pbY + (pbH - pictureBox1.Height) / 2;
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Выберите папку,\nв которой находятся иллюстрации";
            fb.ShowNewFolderButton = false;

            //Отображаем новое окно
            if (fb.ShowDialog() == DialogResult.OK)
            {
                //пользователь выбрал лиалог и щёлкнул на кнопке ОК
                aPath = fb.SelectedPath;
                label1.Text = aPath;

                if (!FillListBox(fb.SelectedPath))
                {
                    //в каталоге нет картинок
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
