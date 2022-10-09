using System.Runtime.InteropServices;
namespace Simple_API
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int SetWindowText(int hwnd, string lpstring);

        [DllImport("kernel32.dll")]
        private static extern int SetVolumeLabel(string lpRootPathName, string lpVolumeName);

        [DllImport("user32.dll")]
        private static extern int ShowCursor(int bShow);

        [DllImport("user32.dll")]
        private static extern int SetCaretBlinkTime(int wMSeconds);

        [DllImport("kernel32.dll")]
        private static extern int WinExec(string lpCmdLine, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern int LoadKeyboardLayout(string pwszKLID, int flags);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h = SetWindowText((int)this.Handle, textBox1.Text);
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetVolumeLabel("c:\\", textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowCursor(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowCursor(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetCaretBlinkTime(int.Parse(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WinExec(textBox4.Text, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadKeyboardLayout("",1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadKeyboardLayout("00000429", 1);
        }
    }
}