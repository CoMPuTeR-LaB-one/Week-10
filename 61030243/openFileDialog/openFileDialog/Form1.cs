using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace openFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtboxFileName.Text = openFileDialog1.FileName;
                DirectoryInfo di = new DirectoryInfo(openFileDialog1.FileName);
                propertyGrid2.SelectedObject = di;
                propertyGrid1.Refresh();
            }
        }
    }
}
