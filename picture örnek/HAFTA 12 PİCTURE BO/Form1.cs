namespace HAFTA_12_PİCTURE_BO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == "ARABA")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\cengiz\\Desktop\\örnek\\ARABA.jpeg");
            }
            else if (listBox1.SelectedItem == "HAYVAN")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\cengiz\\Desktop\\örnek\\HAYVAN.jpeg");
            }
            else if (listBox1.SelectedItem == "İNSAN")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\cengiz\\Desktop\\örnek\\insan4.jpg");
            }
            else
            {
                MessageBox.Show("SEÇENEKLERİ SEÇİNİZ");
            }
        }
    }
}