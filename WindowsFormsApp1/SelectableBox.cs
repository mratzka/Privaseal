using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STS_Berlin_Privacy;

namespace STS_Berlin_Privacy
{
    public partial class SelectableBox : UserControl
    {
        private Boolean statusClicked;
        private String ModuleName;
        private String ModuleDescription;

        public SelectableBox()
        {
            InitializeComponent();
        }

        private void SelectableBox_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (statusClicked == true)
            {
                pictureBox1.BackColor = Color.Gray;
                statusClicked = false;
            }
            else
            {
               pictureBox1.BackColor = Color.Green;
               statusClicked = true;
            }
        }
    }
}
