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
            this.Switch_Button = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StateL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Switch_Button
            // 
            this.Switch_Button.BackColor = System.Drawing.Color.LawnGreen;
            this.Switch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Switch_Button.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch_Button.Location = new System.Drawing.Point(0, 82);
            this.Switch_Button.Name = "Switch_Button";
            this.Switch_Button.Size = new System.Drawing.Size(416, 68);
            this.Switch_Button.TabIndex = 1;
            this.Switch_Button.Text = "Start explorer 🤡";
            this.Switch_Button.UseVisualStyleBackColor = false;
            this.Switch_Button.Click += new System.EventHandler(this.Switch_Button_Click);
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
            this.panel1.Controls.Add(this.StateL);
            this.panel1.Controls.Add(this.Switch_Button);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 150);
            this.panel1.TabIndex = 3;
            // 
            // StateL
            // 
            this.StateL.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StateL.Location = new System.Drawing.Point(0, 0);
            this.StateL.Name = "StateL";
            this.StateL.Size = new System.Drawing.Size(416, 62);
            this.StateL.TabIndex = 3;
            this.StateL.Text = "Explorer is dead";
            this.StateL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        public Button Switch_Button;
        public Button Close;
        private Panel panel1;
        private Label StateL;
    }
}