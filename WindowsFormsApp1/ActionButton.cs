using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS_Berlin_Privacy
{
    public partial class ActionButton : UserControl
    {
        public Boolean ActiveDownload;
        
        public ActionButton()
        {
            InitializeComponent();
            ActiveDownload = false;
        }

        private void ActionButton_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void setActiveDownload()
        {
            ActiveDownload = true;
            pictureBox1.BackColor = Color.Green;
                
        }
    }
}
