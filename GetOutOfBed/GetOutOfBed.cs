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
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor for alarm clock
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.time.Text = DateTime.Now.ToString("h:mm:ss tt");
            this.time.Font = new Font("Arial", 40, FontStyle.Bold);
        }
        #endregion

        #region Private Variables
        private int num1 = 0;
        private int num2 = 0;
        #endregion

        #region Enter and Del
        private void buttonEnter_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.answer.Text == (this.num1 * this.num2).ToString())
            {
                MessageBox.Show("Yes");
            }

            else
            {
                MessageBox.Show("No");
            }

            this.answer.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (this.answer.Text.Length > 0)
            {
                this.answer.Text = this.answer.Text.Substring(0, this.answer.Text.Length - 1);
            }
        }
        #endregion

        #region numbers
        private void button0_Click(object sender, EventArgs e)
        {
            this.answer.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.answer.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.answer.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.answer.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.answer.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.answer.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.answer.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.answer.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.answer.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.answer.Text += "9";
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void generateProblem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.num1 = r.Next(0, 100);
            this.num2 = r.Next(2, 10);

            this.problem.Text = this.num1.ToString() + " x " + this.num2.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called when add alarm button is clicked, creates new form which asks user for a time
        /// </summary>
        private void addAlarm_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }

        /// <summary>
        /// Called from create alarm form. Allows time that the user supplied to be used in this form
        /// </summary>
        public void createAlarm(Alarm a)
        {
            this.alarmsChecklist.Items.Add(a.getTime());
        }

        private void removeAlarm_Click(object sender, EventArgs e)
        {
            foreach (var item in this.alarmsChecklist.CheckedItems.OfType<string>().ToList()) {
                this.alarmsChecklist.Items.Remove(item);
            }
        }
    }
}
