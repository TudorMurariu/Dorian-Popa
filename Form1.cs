using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WMPLib;

namespace Dorian_Popa
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// haha copyright and stuff haha
        /// </summary>
       

        Random r = new Random();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.dorianprima;
            this.player.URL = "CHELUTU1.mp3";
            this.player.settings.volume = 16;
            this.player.controls.play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = r.Next(0, 300);
            int y = r.Next(-180, -84);
            this.sticla1.Location = new Point(x, y);

             x = r.Next(0, 300);
             y = r.Next(-180, -84);
            this.sticla2.Location = new Point(x, y);

             x = r.Next(0, 300);
             y = r.Next(-180, -84);
            this.sticla3.Location = new Point(x, y);

             x = r.Next(0, 300);
             y = r.Next(-180, -84);
            this.sticla4.Location = new Point(x, y);

             x = r.Next(0, 300);
             y = r.Next(-180, -84);
            this.sticla5.Location = new Point(x, y);

             x = r.Next(0, 300);
             y = r.Next(-180, -84);
            this.sticla6.Location = new Point(x, y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush ln = new LinearGradientBrush(this.ClientRectangle, Color.Green, Color.White, 90F);
            e.Graphics.FillRectangle(ln, this.ClientRectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* PictureBox p = new PictureBox();
            p.Width = 40;
            p.Height = 40;
            p.Location = new Point(50, 50);
            p.BackColor = Color.Blue;
            panel1.Controls.Add(p);*/
        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a %  1200 == 0)
            {
                this.player.URL = "Dorian.mp3";
                this.player.controls.play();
            }

            if (Convert.ToInt32(this.score.Text) == 2000)
                this.pictureBox1.Image = Properties.Resources.dorian1;

            if (Convert.ToInt32(this.score.Text) == 5000)
                this.pictureBox1.Image = Properties.Resources.dorian3;

            if (Convert.ToInt32(this.score.Text) == 10000)
                this.pictureBox1.Image = Properties.Resources.dorian5;

            if (Convert.ToInt32(this.score.Text) == 20000)
                this.pictureBox1.Image = Properties.Resources.dorian7;

            if (Convert.ToInt32(this.score.Text) == 30000)
                this.pictureBox1.Image = Properties.Resources.dorian8;

            if (Convert.ToInt32(this.score.Text) == 50000)
                this.pictureBox1.Image = Properties.Resources.dorian9;

            if (Convert.ToInt32(this.score.Text) == 750000)
                this.pictureBox1.Image = Properties.Resources.dorian10;

            if (Convert.ToInt32(this.score.Text) == 1000000)
            {
                this.pictureBox1.Image = Properties.Resources.Genutu;
                this.Text = "Genutu";
                this.button1.Visible = true;
            }

            int h = 350;
            if ((this.sticla1.Top > h || this.sticla2.Top > h || this.sticla3.Top > h || this.sticla4.Top > h || this.sticla5.Top > h || this.sticla6.Top > h) && this.hp1.Visible == true)
                this.hp1.Visible = false;
            else if ((this.sticla1.Top > h || this.sticla2.Top > h || this.sticla3.Top > h || this.sticla4.Top > h || this.sticla5.Top > h || this.sticla6.Top > h) && this.hp2.Visible == true)
                this.hp2.Visible = false;
            else if ((this.sticla1.Top > h || this.sticla2.Top > h || this.sticla3.Top > h || this.sticla4.Top > h || this.sticla5.Top > h || this.sticla6.Top > h) && this.hp3.Visible == true)
            {
                this.hp3.Visible = false;
                this.fuckoff.Visible = true;
                this.fucku.Visible = true;
                this.sticla1.Visible = false;
                this.sticla2.Visible = false;
                this.sticla3.Visible = false;
                this.sticla4.Visible = false;
                this.sticla5.Visible = false;
                this.sticla6.Visible = false;
                this.score.Visible = false;
                this.pictureBox1.Image = Properties.Resources.Genutul;

                this.Text = "Fuck you lmao";
                MessageBox.Show("Haha fraiere ai crezut ca ai 3 vieti", "Te - am prins",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Application.Exit();
            }


            this.sticla1.Top += 7;
            this.sticla2.Top += 9;
            this.sticla3.Top += 7;
            this.sticla4.Top += 14;
            this.sticla5.Top += 8;
            this.sticla6.Top += 7;

            if(this.sticla1.Bounds.IntersectsWith(this.Lada.Bounds))
            {
                this.score.Text = Convert.ToString((Convert.ToInt32(score.Text) + 200));
                int x = r.Next(0, 300);
                int y = r.Next(-520,-84);
                this.sticla1.Location = new Point(x, y);
            }
            if (this.sticla6.Bounds.IntersectsWith(this.Lada.Bounds))
            {
                this.score.Text = Convert.ToString((Convert.ToInt32(score.Text) + 200));
                int x = r.Next(0, 300);
                int y = r.Next(-520, -84);
                this.sticla6.Location = new Point(x, y);
            }
            if (this.sticla5.Bounds.IntersectsWith(this.Lada.Bounds))
            {
                this.score.Text = Convert.ToString((Convert.ToInt32(score.Text) + 200));
                int x = r.Next(0, 300);
                int y = r.Next(-520, -84);
                this.sticla5.Location = new Point(x, y);
            }
            if (this.sticla4.Bounds.IntersectsWith(this.Lada.Bounds))
            {
                this.score.Text = Convert.ToString((Convert.ToInt32(score.Text) + 200));
                int x = r.Next(0, 300);
                int y = r.Next(-520, -84);
                this.sticla4.Location = new Point(x, y);
            }
            if (this.sticla3.Bounds.IntersectsWith(this.Lada.Bounds))
            {
                this.score.Text = Convert.ToString((Convert.ToInt32(score.Text) + 200));
                int x = r.Next(0, 300);
                int y = r.Next(-520, -84);
                this.sticla3.Location = new Point(x, y);
            }
            if (this.sticla2.Bounds.IntersectsWith(this.Lada.Bounds))
            {
                this.score.Text = Convert.ToString((Convert.ToInt32(score.Text) + 200));
                int x = r.Next(0, 300);
                int y = r.Next(-520, -84);
                this.sticla2.Location = new Point(x, y);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Home || e.KeyCode == Keys.A) && this.Lada.Left > 0)
                this.Lada.Left -= 20;
            else if ((e.KeyCode == Keys.End || e.KeyCode == Keys.D) && this.Lada.Left < 300)
                this.Lada.Left += 20;
        }

        private void sticla5_Click(object sender, EventArgs e)
        {

        }

        private void hp2_Click(object sender, EventArgs e)
        {

        }

        private void fucku_Click(object sender, EventArgs e)
        {

        }  
    }
}
