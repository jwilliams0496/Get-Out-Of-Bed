using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOutOfBed
{
    public partial class Form2 : Form
    {
        private Form1 parent;

        public Form2(Form1 f)
        {
            InitializeComponent();
            this.parent = f;
        }

        private void addAlarm_Click(object sender, EventArgs e)
        {
            bool am = true;

            if (this.PM.Checked)
            {
                am = false;
            }

            parent.createAlarm(new Alarm((int)this.hour.Value, (int)this.minute.Value, am));

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
