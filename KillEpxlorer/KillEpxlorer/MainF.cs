using Microsoft.Win32;
using System.Diagnostics;

namespace KillEpxlorer
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MainF_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kill_Click(object sender, EventArgs e)
        {
            RegistryKey ourKey = Registry.LocalMachine;
            ourKey = ourKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            ourKey.SetValue("AutoRestartShell", 0);
            // Store all running process in the system
            Process[] runingProcess = Process.GetProcesses();
            for (int i = 0; i < runingProcess.Length; i++)
            {
                // compare equivalent process by their name
                if (runingProcess[i].ProcessName == "explorer")
                {
                    // kill  running process
                    runingProcess[i].Kill();
                }

            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            RegistryKey ourKey = Registry.LocalMachine;
            ourKey = ourKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            ourKey.SetValue("AutoRestartShell", 1);
            Process myProcess = Process.Start(@"C:\Windows\explorer.exe");
            
        }
    }
}