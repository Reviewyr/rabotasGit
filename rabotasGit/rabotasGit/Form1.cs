namespace rabotasGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            textBox.Text = "Здравствуйте, смотрящие, как у вас дела, чем занимаетесь?";
            newForm.Controls.Add(textBox);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form redForm = new Form();
            redForm.Size = new Size(200, 200);
            redForm.BackColor = Color.Red;
            redForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form squareForm = new Form();
            squareForm.Size = new Size(200, 200);
            Graphics graphics = squareForm.CreateGraphics();

            int sideLength = Math.Min(squareForm.Width, squareForm.Height) / 2; // Размер стороны квадрата равен минимальному размеру окна
            Pen pen = new Pen(Color.Black, 2); // Цвет линии и толщина

            Point startPoint = new Point((squareForm.ClientRectangle.Width - sideLength) / 2, (squareForm.ClientRectangle.Height - sideLength) / 2); // Точка старта рисуния

            graphics.Clear(Color.White); // Очищаем фон перед рисовкой
            graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, sideLength, sideLength); // Рисуем квадрат
            squareForm.ShowDialog();
        }
    }
}