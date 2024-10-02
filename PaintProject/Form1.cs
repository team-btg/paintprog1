namespace PaintProject
{
    public partial class Form1 : Form
    {
        bool mouseDown = false;
        Bitmap myBitMap;
        public Form1()
        {
            InitializeComponent();
            myBitMap = new Bitmap(Size.Width, Size.Height);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.Write("");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.Write("");
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown)
                return;
            Graphics graphics = Graphics.FromImage(myBitMap);
            Pen p = new Pen(Color.Red, 2);
            graphics.DrawLine(p, e.Y, e.X, e.X + 1, e.Y + 1);
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitMap, 0, 0);
        }
    }
}
