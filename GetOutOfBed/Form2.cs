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

    }
}
