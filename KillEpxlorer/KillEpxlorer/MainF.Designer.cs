namespace KillEpxlorer
{
    partial class MainF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kill = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kill
            // 
            this.kill.BackColor = System.Drawing.Color.Red;
            this.kill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kill.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kill.Location = new System.Drawing.Point(0, 0);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(416, 68);
            this.kill.TabIndex = 0;
            this.kill.Text = "Kill explorer 💀";
            this.kill.UseVisualStyleBackColor = false;
            this.kill.Click += new System.EventHandler(this.kill_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LawnGreen;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(0, 82);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(416, 68);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start explorer 🤡";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Gainsboro;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.Crimson;
            this.Close.Location = new System.Drawing.Point(430, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Close.Size = new System.Drawing.Size(70, 150);
            this.Close.TabIndex = 2;
            this.Close.Text = "❌";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kill);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 150);
            this.panel1.TabIndex = 3;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(550, 200);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainF";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kill Explorer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainF_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Button kill;
        public Button Start;
        public Button Close;
        private Panel panel1;
    }
}