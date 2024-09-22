namespace WinForms01
{
    public partial class Form1 : Form
    {
        private int currentColorIndex = 0;
        private Color[] colors = { Color.Red, Color.Yellow, Color.Green };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, Width - button2.Width);
            int y = rnd.Next(0, Height - button2.Height);

            x = Math.Max(0, Math.Min(x, Width - button2.Width));
            y = Math.Max(0, Math.Min(y, Height - button2.Height));

            button2.Location = new Point(x, y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - Width);
            int y = rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - Height);
            Location = new Point(x, y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = colors[currentColorIndex];
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
        }
    }
}
