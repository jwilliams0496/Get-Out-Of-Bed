namespace GetOutOfBed
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.answerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.problem = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.generateProblem = new System.Windows.Forms.Button();
            this.alarmsChecklist = new System.Windows.Forms.CheckedListBox();
            this.addAlarm = new System.Windows.Forms.Button();
            this.removeAlarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.answerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(98, 113);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(36, 13);
            this.time.TabIndex = 1;
            this.time.Text = "[Time]";
            // 
            // answerPanel
            // 
            this.answerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.answerPanel.ColumnCount = 3;
            this.answerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.answerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.answerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.answerPanel.Controls.Add(this.button7, 0, 0);
            this.answerPanel.Controls.Add(this.button8, 1, 0);
            this.answerPanel.Controls.Add(this.button9, 2, 0);
            this.answerPanel.Controls.Add(this.button4, 0, 1);
            this.answerPanel.Controls.Add(this.button5, 1, 1);
            this.answerPanel.Controls.Add(this.button6, 2, 1);
            this.answerPanel.Controls.Add(this.button1, 0, 2);
            this.answerPanel.Controls.Add(this.button2, 1, 2);
            this.answerPanel.Controls.Add(this.button3, 2, 2);
            this.answerPanel.Controls.Add(this.button0, 0, 3);
            this.answerPanel.Controls.Add(this.buttonDel, 1, 3);
            this.answerPanel.Controls.Add(this.buttonEnter, 2, 3);
            this.answerPanel.Location = new System.Drawing.Point(518, 192);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.RowCount = 4;
            this.answerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.answerPanel.Size = new System.Drawing.Size(297, 328);
            this.answerPanel.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 76);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(101, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 76);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(200, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 76);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(101, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 76);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(200, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 76);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(101, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 76);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(200, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 76);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(3, 249);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(92, 76);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDel.Location = new System.Drawing.Point(101, 249);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(93, 76);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnter.Location = new System.Drawing.Point(200, 249);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 76);
            this.buttonEnter.TabIndex = 11;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEnter_MouseClick);
            // 
            // problem
            // 
            this.problem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.problem.AutoSize = true;
            this.problem.Location = new System.Drawing.Point(638, 113);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(0, 13);
            this.problem.TabIndex = 3;
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.Location = new System.Drawing.Point(521, 154);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(291, 20);
            this.answer.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // generateProblem
            // 
            this.generateProblem.Location = new System.Drawing.Point(695, 68);
            this.generateProblem.Name = "generateProblem";
            this.generateProblem.Size = new System.Drawing.Size(120, 22);
            this.generateProblem.TabIndex = 5;
            this.generateProblem.Text = "Generate Problem";
            this.generateProblem.UseVisualStyleBackColor = true;
            this.generateProblem.Click += new System.EventHandler(this.generateProblem_Click);
            // 
            // alarmsChecklist
            // 
            this.alarmsChecklist.CheckOnClick = true;
            this.alarmsChecklist.FormattingEnabled = true;
            this.alarmsChecklist.Location = new System.Drawing.Point(13, 225);
            this.alarmsChecklist.Name = "alarmsChecklist";
            this.alarmsChecklist.Size = new System.Drawing.Size(499, 289);
            this.alarmsChecklist.Sorted = true;
            this.alarmsChecklist.TabIndex = 6;
            // 
            // addAlarm
            // 
            this.addAlarm.Location = new System.Drawing.Point(12, 192);
            this.addAlarm.Name = "addAlarm";
            this.addAlarm.Size = new System.Drawing.Size(101, 23);
            this.addAlarm.TabIndex = 7;
            this.addAlarm.Text = "Add Alarm";
            this.addAlarm.UseVisualStyleBackColor = true;
            this.addAlarm.Click += new System.EventHandler(this.addAlarm_Click);
            // 
            // removeAlarm
            // 
            this.removeAlarm.Location = new System.Drawing.Point(119, 192);
            this.removeAlarm.Name = "removeAlarm";
            this.removeAlarm.Size = new System.Drawing.Size(98, 23);
            this.removeAlarm.TabIndex = 8;
            this.removeAlarm.Text = "Remove Alarm(s)";
            this.removeAlarm.UseVisualStyleBackColor = true;
            this.removeAlarm.Click += new System.EventHandler(this.removeAlarm_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonDel;
            this.ClientSize = new System.Drawing.Size(827, 532);
            this.Controls.Add(this.removeAlarm);
            this.Controls.Add(this.addAlarm);
            this.Controls.Add(this.alarmsChecklist);
            this.Controls.Add(this.generateProblem);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Get Out Of Bed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.answerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TableLayoutPanel answerPanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label problem;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button generateProblem;
        private System.Windows.Forms.CheckedListBox alarmsChecklist;
        private System.Windows.Forms.Button addAlarm;
        private System.Windows.Forms.Button removeAlarm;
    }
}

