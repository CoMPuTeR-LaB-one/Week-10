using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Hello World";
            this.BackColor = Color.LightGreen;
            this.ClientSize = new Size(500, 300);
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
        }
    }
}
