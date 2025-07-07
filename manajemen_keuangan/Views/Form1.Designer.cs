namespace manajemen_keuangan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.radioButtonTUNAI = new System.Windows.Forms.RadioButton();
            this.radioButtonNONTUNAI = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(23, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "JENIS TRANSAKSI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(23, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TANGGAL TRANSAKSI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(23, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOMINAL TRANSAKSI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.Location = new System.Drawing.Point(250, 164);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(390, 26);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNominal.Location = new System.Drawing.Point(240, 282);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(390, 26);
            this.textBoxNominal.TabIndex = 7;
            this.textBoxNominal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(250, 242);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(281, 26);
            this.dateTimePickerTanggal.TabIndex = 8;
            // 
            // radioButtonTUNAI
            // 
            this.radioButtonTUNAI.AutoSize = true;
            this.radioButtonTUNAI.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonTUNAI.Location = new System.Drawing.Point(250, 198);
            this.radioButtonTUNAI.Name = "radioButtonTUNAI";
            this.radioButtonTUNAI.Size = new System.Drawing.Size(121, 24);
            this.radioButtonTUNAI.TabIndex = 9;
            this.radioButtonTUNAI.TabStop = true;
            this.radioButtonTUNAI.Text = "Peminjaman";
            this.radioButtonTUNAI.UseVisualStyleBackColor = false;
            this.radioButtonTUNAI.CheckedChanged += new System.EventHandler(this.radioButtonTUNAI_CheckedChanged);
            // 
            // radioButtonNONTUNAI
            // 
            this.radioButtonNONTUNAI.AutoSize = true;
            this.radioButtonNONTUNAI.BackColor = System.Drawing.Color.PaleVioletRed;
            this.radioButtonNONTUNAI.Location = new System.Drawing.Point(398, 196);
            this.radioButtonNONTUNAI.Name = "radioButtonNONTUNAI";
            this.radioButtonNONTUNAI.Size = new System.Drawing.Size(123, 24);
            this.radioButtonNONTUNAI.TabIndex = 10;
            this.radioButtonNONTUNAI.TabStop = true;
            this.radioButtonNONTUNAI.Text = "Pembayaran";
            this.radioButtonNONTUNAI.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(49, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::manajemen_keuangan.Properties.Resources.a407e78c_af40_4d18_ac09_4c278364dc84;
            this.panel1.Location = new System.Drawing.Point(133, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 136);
            this.panel1.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(713, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::manajemen_keuangan.Properties.Resources.Flag_map_of_Cambodia_svg;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonNONTUNAI);
            this.Controls.Add(this.radioButtonTUNAI);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.textBoxNominal);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "manajemen_keuangan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.RadioButton radioButtonTUNAI;
        private System.Windows.Forms.RadioButton radioButtonNONTUNAI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
    }
}

