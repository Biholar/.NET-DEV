using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cisarius
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string al = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя .,:123456789+-/!?ыёqwertyuiopasdfghjklzxcvbnm";

        private void bt_do_Click(object sender, EventArgs e)
        {
            textBox2.Text = Direction(textBox1.Text);
        }

        public string Direction(string input)
        {
            StringBuilder code = new StringBuilder();
            string s = textBox1.Text.ToLower();
            int step = Convert.ToInt32(updown.Value);
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < al.Length; j++)
                    if (s[i] == al[j]) code.Append(al[(j + step) % al.Length]);
            return code.ToString();

        }

        private void bt_undo_Click(object sender, EventArgs e)
        {
            textBox2.Text = DirectionBack(textBox2.Text);

        }
        public string DirectionBack(string input)
        {
            StringBuilder code = new StringBuilder();
            string s = textBox1.Text;
            int step = Convert.ToInt32(updown.Value);
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < al.Length; j++)
                    if (s[i] == al[j]) code.Append(al[(j - step + al.Length) % al.Length]);
            return code.ToString();

        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.RestoreDirectory = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(open.FileName);
                    textBox1.Text = (sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
                }
            }
            else MessageBox.Show("Text field is empty");
        }
    }
    }

