using Svg;
using System.Windows.Forms;
namespace WinForms_Ex_P_36__Step_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer timerCloseForm= new();
        List<string> pictures =
        [
            @"https://hips.hearstapps.com/hmg-prod/images/gettyimages-180680638-676f621f720bc.jpg?crop=0.8888888888888888xw:1xh;center,top&resize=1200:*",
            @"https://www.cdc.gov/healthy-pets/media/images/2024/04/GettyImages-598175960-cute-dog-headshot.jpg",
            @"https://blogscdn.thehut.net/app/uploads/sites/2405/2025/02/JWB-5-Image-1_1738922557.jpg"
        ];

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../../icons/icons8-ok-hand-emoji-96.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            MovePictureToCenter();
            //pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            //pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;

            timer1.Interval = 1000; // 1 секунда
            timer1.Start();
            timerCloseForm.Interval = 10000; // 10 секунд
            timerCloseForm.Start();
            timerCloseForm.Tick += TimerCloseForm_Tick;


        }

        private void TimerCloseForm_Tick(object? sender, EventArgs e)
        {
            MessageBox.Show("Time's up! Closing the form.");// "Час вийшов! Форма закривається."
            this.Close();
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            // якщо потрібно завантажити svg з файлу, попередньо встановити пакет Svg.Net через NuGet

            var svgDoc = SvgDocument.Open("../../../icons/heart-svgrepo-com.svg");

            // Малюємо у Bitmap (наприклад, 200x200 пікселів)
            timer1.Interval = 200;
            var bitmap = svgDoc.Draw(200, 200);
            pictureBox1.Image = bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Left += rnd.Next(-100, 100);
            pictureBox1.Top += rnd.Next(-100, 100);

            label1.Text = $"X: {pictureBox1.Left}, Y: {pictureBox1.Top}\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            MovePictureToCenter();

        }

        private void MovePictureToCenter()
        {
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.ClientSize.Height - pictureBox1.Height) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Aqua;
            //button1.BackColor = Color.Aqua;
            //button1.ForeColor = Color.Red;
        }
    }
}
