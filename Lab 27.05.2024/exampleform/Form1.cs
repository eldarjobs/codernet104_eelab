using EventExampleNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exampleform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circularProgressBar1(object sender, EventArgs e)
        {

        }

        Vehicle vehicle = new Vehicle();
        Timer timer = new Timer();
        bool start = false;
        int speed = 0;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            vehicle.Marka = "Mercedes";
            vehicle.Model = "GLS-450";
            vehicle.Hiz = 1;


            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (start)
            {
                speed++;
            }
            else
            {
                speed--;
            }

            if (speed > 0 && speed < 300)
            {
                vehicle.Hiz = speed;
                circularProgressBar1.Value = speed;


            }
            if (speed == 0)
            {
                vehicle.Start = false;
                speed = 1;
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = "0";
            }


        }




        private void InitializeComponent()
        {

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.circularProgressBar1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.ResumeLayout(false);

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
