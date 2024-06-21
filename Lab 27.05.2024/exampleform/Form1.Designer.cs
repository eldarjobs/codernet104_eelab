using CircularProgressBar;
using EventExampleNet.Models;
using System.Windows.Forms;
using System;

public partial class Form1 : Form
{
    //public Form1()
    //{
    //    InitializeComponent();
    //}

    private void circularProgressBar1_Click(object sender, EventArgs e)
    {

    }
    Vehicle vehicle = new Vehicle();
    Timer timer = new Timer();
    bool start = false;
    int speed = 0;
    private void Form1_Load(object sender, EventArgs e)
    {
        vehicle.Marka = "BMW";
        vehicle.Model = "M4";
        vehicle.Hiz = 1;
        vehicle.SpeedEvent += Vehicle_SpeedEvent;

        timer.Interval = 50;
        timer.Tick += Timer_Tick;
    }
    private void Vehicle_SpeedEvent(int vites, System.Drawing.Color color)
    {

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
        //if (speed > 0 && speed <= 300)
        //{
        //    vehicle.Hiz = speed;
        //    circularProgressBar1.Value = speed;
        //    circularProgressBar1.Text = speed.ToString();
        //}
        //if (speed == 0)
        //{
        //    vehicle.Start = false;
        //    speed = 1;
        //    circularProgressBar1.Value = 0;
        //    circularProgressBar1.Text = "0";
        //}
    }

    private CircularProgressBar.CircularProgressBar circularProgressBar1;
    private CircularProgressBar.CircularProgressBar circularProgressBar2;
}