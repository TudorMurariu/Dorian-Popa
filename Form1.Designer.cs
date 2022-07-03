namespace Dorian_Popa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fucku = new System.Windows.Forms.Label();
            this.fuckoff = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.hp1 = new System.Windows.Forms.PictureBox();
            this.hp2 = new System.Windows.Forms.PictureBox();
            this.hp3 = new System.Windows.Forms.PictureBox();
            this.Lada = new System.Windows.Forms.PictureBox();
            this.sticla4 = new System.Windows.Forms.PictureBox();
            this.sticla3 = new System.Windows.Forms.PictureBox();
            this.sticla2 = new System.Windows.Forms.PictureBox();
            this.sticla5 = new System.Windows.Forms.PictureBox();
            this.sticla6 = new System.Windows.Forms.PictureBox();
            this.sticla1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hp1);
            this.panel1.Controls.Add(this.fucku);
            this.panel1.Controls.Add(this.hp2);
            this.panel1.Controls.Add(this.hp3);
            this.panel1.Controls.Add(this.fuckoff);
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.Lada);
            this.panel1.Controls.Add(this.sticla4);
            this.panel1.Controls.Add(this.sticla3);
            this.panel1.Controls.Add(this.sticla2);
            this.panel1.Controls.Add(this.sticla5);
            this.panel1.Controls.Add(this.sticla6);
            this.panel1.Controls.Add(this.sticla1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 448);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(375, 27);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(32, 32);
            this.score.TabIndex = 8;
            this.score.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Acum este radul lui Genutu !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fucku
            // 
            this.fucku.AutoSize = true;
            this.fucku.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fucku.Location = new System.Drawing.Point(161, 172);
            this.fucku.Name = "fucku";
            this.fucku.Size = new System.Drawing.Size(350, 46);
            this.fucku.TabIndex = 3;
            this.fucku.Text = "daca imi permiteti";
            this.fucku.Visible = false;
            this.fucku.Click += new System.EventHandler(this.fucku_Click);
            // 
            // fuckoff
            // 
            this.fuckoff.AutoSize = true;
            this.fuckoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fuckoff.Location = new System.Drawing.Point(198, 71);
            this.fuckoff.Name = "fuckoff";
            this.fuckoff.Size = new System.Drawing.Size(274, 69);
            this.fuckoff.TabIndex = 4;
            this.fuckoff.Text = "chiar trist";
            this.fuckoff.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(556, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // hp1
            // 
            this.hp1.BackColor = System.Drawing.Color.Red;
            this.hp1.Location = new System.Drawing.Point(76, 339);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(19, 26);
            this.hp1.TabIndex = 11;
            this.hp1.TabStop = false;
            // 
            // hp2
            // 
            this.hp2.BackColor = System.Drawing.Color.Red;
            this.hp2.Location = new System.Drawing.Point(50, 339);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(19, 26);
            this.hp2.TabIndex = 10;
            this.hp2.TabStop = false;
            this.hp2.Click += new System.EventHandler(this.hp2_Click);
            // 
            // hp3
            // 
            this.hp3.BackColor = System.Drawing.Color.Red;
            this.hp3.Location = new System.Drawing.Point(25, 339);
            this.hp3.Name = "hp3";
            this.hp3.Size = new System.Drawing.Size(19, 26);
            this.hp3.TabIndex = 9;
            this.hp3.TabStop = false;
            // 
            // Lada
            // 
            this.Lada.Image = global::Dorian_Popa.Properties.Resources.piscina;
            this.Lada.Location = new System.Drawing.Point(161, 383);
            this.Lada.Name = "Lada";
            this.Lada.Size = new System.Drawing.Size(146, 65);
            this.Lada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lada.TabIndex = 7;
            this.Lada.TabStop = false;
            // 
            // sticla4
            // 
            this.sticla4.Image = ((System.Drawing.Image)(resources.GetObject("sticla4.Image")));
            this.sticla4.Location = new System.Drawing.Point(97, 172);
            this.sticla4.Name = "sticla4";
            this.sticla4.Size = new System.Drawing.Size(58, 84);
            this.sticla4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticla4.TabIndex = 6;
            this.sticla4.TabStop = false;
            // 
            // sticla3
            // 
            this.sticla3.Image = ((System.Drawing.Image)(resources.GetObject("sticla3.Image")));
            this.sticla3.Location = new System.Drawing.Point(249, 71);
            this.sticla3.Name = "sticla3";
            this.sticla3.Size = new System.Drawing.Size(58, 84);
            this.sticla3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticla3.TabIndex = 5;
            this.sticla3.TabStop = false;
            // 
            // sticla2
            // 
            this.sticla2.Image = ((System.Drawing.Image)(resources.GetObject("sticla2.Image")));
            this.sticla2.Location = new System.Drawing.Point(161, 71);
            this.sticla2.Name = "sticla2";
            this.sticla2.Size = new System.Drawing.Size(58, 84);
            this.sticla2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticla2.TabIndex = 4;
            this.sticla2.TabStop = false;
            // 
            // sticla5
            // 
            this.sticla5.Image = ((System.Drawing.Image)(resources.GetObject("sticla5.Image")));
            this.sticla5.Location = new System.Drawing.Point(161, 172);
            this.sticla5.Name = "sticla5";
            this.sticla5.Size = new System.Drawing.Size(58, 84);
            this.sticla5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticla5.TabIndex = 3;
            this.sticla5.TabStop = false;
            this.sticla5.Click += new System.EventHandler(this.sticla5_Click);
            // 
            // sticla6
            // 
            this.sticla6.Image = ((System.Drawing.Image)(resources.GetObject("sticla6.Image")));
            this.sticla6.Location = new System.Drawing.Point(249, 172);
            this.sticla6.Name = "sticla6";
            this.sticla6.Size = new System.Drawing.Size(58, 84);
            this.sticla6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticla6.TabIndex = 2;
            this.sticla6.TabStop = false;
            // 
            // sticla1
            // 
            this.sticla1.Image = ((System.Drawing.Image)(resources.GetObject("sticla1.Image")));
            this.sticla1.Location = new System.Drawing.Point(97, 71);
            this.sticla1.Name = "sticla1";
            this.sticla1.Size = new System.Drawing.Size(58, 84);
            this.sticla1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sticla1.TabIndex = 1;
            this.sticla1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(547, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dezbraca-l pe Dorian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sticla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox sticla4;
        private System.Windows.Forms.PictureBox sticla3;
        private System.Windows.Forms.PictureBox sticla2;
        private System.Windows.Forms.PictureBox sticla5;
        private System.Windows.Forms.PictureBox sticla6;
        private System.Windows.Forms.PictureBox sticla1;
        private System.Windows.Forms.PictureBox Lada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox hp1;
        private System.Windows.Forms.PictureBox hp2;
        private System.Windows.Forms.PictureBox hp3;
        private System.Windows.Forms.Label fucku;
        private System.Windows.Forms.Label fuckoff;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

