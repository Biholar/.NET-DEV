using Microsoft.Win32;
using System.Diagnostics;
using System.Text;

namespace KillEpxlorer
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
            ExplorerCheck();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Process[] runingProcess;
        public int? ExpIndex;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MainF_MouseDown(object sender, MouseEventArgs e)
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

        private void Switch_Button_Click(object sender, EventArgs e)
        {
           
            if (ExpIndex != null)
            {
                KillExplorer();
            }
            else
            {
                SpawnExplorer();
            }
            ExplorerCheck();
        }

        public void KillExplorer()
        {
            RegistryKeyEdit(0);
            runingProcess[ExpIndex.Value].Kill();
          
        }

        public void SpawnExplorer()
        {
            RegistryKeyEdit(1);
            Process.Start(@"C:\Windows\explorer.exe");
           
        }

        public void LabelByState()
        {
            if (ExpIndex != null)
            {
                Switch_Button.BackColor = Color.Red;
                Switch_Button.Text = "Kill explorer "+Encoding.UTF8.GetString(new byte[] { 0xF0, 0x9F, 0x92, 0x80 });
                StateL.Text = "Explorer is alive";
            }
            else
            {
                Switch_Button.BackColor = Color.LawnGreen;
                Switch_Button.Text = "Start explorer "+Encoding.UTF8.GetString(new byte[] { 0xF0, 0x9F, 0xA4, 0xA1 });
                StateL.Text = "Explorer is dead";
            }
        }

        public void ExplorerCheck ()
        { 
            Thread.Sleep(100);
            runingProcess = Process.GetProcesses();
            for (int i = 0; i < runingProcess.Length; i++)
            {
                if (runingProcess[i].ProcessName == "explorer")
                {
                    ExpIndex = i; 
                    break;
                }
                else ExpIndex = null;
            }
            LabelByState();
        }

        public void RegistryKeyEdit (int key)
        {
            RegistryKey ourKey = Registry.LocalMachine;
            ourKey = ourKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            ourKey.SetValue("AutoRestartShell", key);
        }

       
    }
}