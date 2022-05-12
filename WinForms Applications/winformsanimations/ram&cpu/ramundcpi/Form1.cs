using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ramundcpi
{
    public partial class Form1 : Form
    {
        PerformanceCounter perfCPU = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAM = new PerformanceCounter("Memory", "Available MBytes");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_cpu.Text = "CPU Auslastung: " + (int) perfCPU.NextValue() + "%";
            lbl_ram.Text = "Freier Speicher: " + (int) perfRAM.NextValue() + " Megabyte";
        }
    }
}
