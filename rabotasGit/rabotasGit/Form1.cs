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
            textBox.Text = "������������, ���������, ��� � ��� ����, ��� �����������?";
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

            int sideLength = Math.Min(squareForm.Width, squareForm.Height) / 2; // ������ ������� �������� ����� ������������ ������� ����
            Pen pen = new Pen(Color.Black, 2); // ���� ����� � �������

            Point startPoint = new Point((squareForm.ClientRectangle.Width - sideLength) / 2, (squareForm.ClientRectangle.Height - sideLength) / 2); // ����� ������ �������

            graphics.Clear(Color.White); // ������� ��� ����� ��������
            graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, sideLength, sideLength); // ������ �������
            squareForm.ShowDialog();
        }
    }
}