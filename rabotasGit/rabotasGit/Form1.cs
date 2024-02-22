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
    }
}