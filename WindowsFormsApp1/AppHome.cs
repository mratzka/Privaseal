using STSUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;



namespace STS_Berlin_Privacy
{
    public partial class AppHome : Form
    {
        private STSUpdater updater;


        private String Selected;
        public AppHome()
        {
            InitializeComponent();
            label10.Text = ProductName + "\n" + ProductVersion;

            updater = new STSUpdater(Assembly.GetExecutingAssembly(), this, new Uri("http://178.254.30.89/STS/project.xml"));
            //updater = new STSUpdater(Assembly.GetExecutingAssembly(), this, new Uri(new System.IO.FileInfo(@"..\..\..\project.xml").FullName));       // for local testing
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //label4.Hide();
            site_Modules1.BringToFront();
            Selected = "pictureBox1";
            timer1.Start();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)

        {

            site_Privacy2.BringToFront();
            Selected = "pictureBox6";
            timer1.Start();


        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            site_Modules1.BringToFront();
            Selected = "pictureBox2";
            timer1.Start();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Selected == "pictureBox6")
            {
                if (pictureBox3.Top < 176)
                {
                    pictureBox3.Top += 8;
                    if (pictureBox3.Top >= 176)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    pictureBox3.Top -= 8;
                    if (pictureBox3.Top <= 176)
                    {
                        timer1.Stop();
                    }
                }

            }
            if (Selected == "pictureBox1")
            {
                if (pictureBox3.Top < 32)
                {
                    pictureBox3.Top += 8;
                    if (pictureBox3.Top >= 32)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    pictureBox3.Top -= 8;
                    if (pictureBox3.Top <= 32)
                    {
                        timer1.Stop();
                    }
                }

            }
            if (Selected == "pictureBox14")
            {
                if (pictureBox3.Top < 320)
                {
                    pictureBox3.Top += 8;
                    if (pictureBox3.Top >= 320)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    pictureBox3.Top -= 8;
                    if (pictureBox3.Top <= 320)
                    {
                        timer1.Stop();
                    }
                }

            }
            if (Selected == "pictureBox11")
            {
                if (pictureBox3.Top < 460)
                {
                    pictureBox3.Top += 8;
                    if (pictureBox3.Top >= 460)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    pictureBox3.Top -= 8;
                    if (pictureBox3.Top <= 460)
                    {
                        timer1.Stop();
                    }
                }

            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            site_Modules1.BringToFront();
            Selected = "pictureBox5";
            timer1.Start();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void selectableBox1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void actionButton1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();

        }

        private void site_Modules1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            site_Modules1.BringToFront();
            Selected = "pictureBox14";
            timer1.Start();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            site_Modules1.BringToFront();
            Selected = "pictureBox11";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {

        }

        private void site_Privacy2_Load(object sender, EventArgs e)
        {

        }
    }
}

