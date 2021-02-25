namespace Cisarius
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgpan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_open = new System.Windows.Forms.Button();
            this.updown = new System.Windows.Forms.NumericUpDown();
            this.bt_undo = new System.Windows.Forms.Button();
            this.bt_do = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bgpan.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgpan
            // 
            this.bgpan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bgpan.Controls.Add(this.label2);
            this.bgpan.Controls.Add(this.label1);
            this.bgpan.Controls.Add(this.panel2);
            this.bgpan.Controls.Add(this.panel1);
            this.bgpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgpan.Location = new System.Drawing.Point(0, 0);
            this.bgpan.Name = "bgpan";
            this.bgpan.Size = new System.Drawing.Size(800, 538);
            this.bgpan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(585, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вивод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввод";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.bt_open);
            this.panel2.Controls.Add(this.updown);
            this.panel2.Controls.Add(this.bt_undo);
            this.panel2.Controls.Add(this.bt_do);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 2;
            // 
            // bt_open
            // 
            this.bt_open.BackColor = System.Drawing.Color.MintCream;
            this.bt_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_open.Location = new System.Drawing.Point(13, 8);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(108, 35);
            this.bt_open.TabIndex = 4;
            this.bt_open.Text = "Open txt";
            this.bt_open.UseVisualStyleBackColor = false;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // updown
            // 
            this.updown.BackColor = System.Drawing.SystemColors.Info;
            this.updown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updown.Location = new System.Drawing.Point(736, 13);
            this.updown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.updown.Name = "updown";
            this.updown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updown.Size = new System.Drawing.Size(52, 27);
            this.updown.TabIndex = 3;
            this.updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_undo
            // 
            this.bt_undo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_undo.BackColor = System.Drawing.Color.MintCream;
            this.bt_undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_undo.Location = new System.Drawing.Point(465, 8);
            this.bt_undo.Name = "bt_undo";
            this.bt_undo.Size = new System.Drawing.Size(153, 35);
            this.bt_undo.TabIndex = 2;
            this.bt_undo.Text = "Розшифрувати";
            this.bt_undo.UseVisualStyleBackColor = false;
            this.bt_undo.Click += new System.EventHandler(this.bt_undo_Click);
            // 
            // bt_do
            // 
            this.bt_do.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_do.BackColor = System.Drawing.Color.MintCream;
            this.bt_do.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_do.Location = new System.Drawing.Point(296, 8);
            this.bt_do.Name = "bt_do";
            this.bt_do.Size = new System.Drawing.Size(153, 35);
            this.bt_do.TabIndex = 1;
            this.bt_do.Text = "Шифрувати";
            this.bt_do.UseVisualStyleBackColor = false;
            this.bt_do.Click += new System.EventHandler(this.bt_do_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 460);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MintCream;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(411, 10);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(379, 440);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MintCream;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 440);
            this.textBox1.TabIndex = 0;
            // 
            // open
            // 
            this.open.DefaultExt = "txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(670, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зсув";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MintCream;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(137, 8);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(108, 35);
            this.save.TabIndex = 6;
            this.save.Text = "Save out";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.bgpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cesarius";
            this.bgpan.ResumeLayout(false);
            this.bgpan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel bgpan;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bt_undo;
        public System.Windows.Forms.Button bt_do;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown updown;
        public System.Windows.Forms.OpenFileDialog open;
        public System.Windows.Forms.Button bt_open;
        public System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

