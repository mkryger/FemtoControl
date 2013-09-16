using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace FemtoControl
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Run_Scripts_Click(object sender, EventArgs e)
        {
            // This is where we'll keep the test scripting.  
            this.textBox1.AppendText("Please Wait while Equipment is Detected...\n");

            // Create length '2' array where we can store references to the Serial Port Objects
            SerialPort XY_CONTROLLER = new SerialPort(); SerialPort AOI_CONTROLLER = new SerialPort(); SerialPort TOOL_PORT = new SerialPort();

              
            // Output to textbox1 as a pseudo command prompt so we can keep track of what's happening... keep trying to get attached console thing to work...
            this.textBox1.AppendText("Available COM Ports:\n");
            foreach (string s in SerialPort.GetPortNames())
            {
                this.textBox1.AppendText("COM port:  " + s + "\n");
            }



            

            

        }

    }
}
