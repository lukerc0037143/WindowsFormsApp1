﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));

        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x) * 180 / Math.PI);
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Force = double.Parse(text1.Text);
            double Angle = double.Parse(text2.Text);

            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            label1.Text = "Fx = " + Fx;
            label2.Text = "Fy = " + Fy;



        }
    }
}
