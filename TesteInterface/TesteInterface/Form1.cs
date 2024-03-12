using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteInterface
{
    public partial class Form1 : Form
    {

        private string red;         //String to hold the red led intensity --> visible to all functions
        private string angle;       //String to hold the angle of servo

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open(); //Will initialize and open the serial port at runtime
        }

        //We will add code to this event to send a command to the arduino
        //Função: Ligar Led do arduino
        private void onButton_Click(object sender, EventArgs e)
        {
            //Send command to the arduino to turn pin 13 on
            serialPort1.Write("A");
        }

        //Função: Desligar Led do arduino
        private void offButton_Click(object sender, EventArgs e)
        {
            //Send command to the arduino to turn pin 13 off
            serialPort1.Write("a");
        }

        //Função: Settar ângulo para o servo: a partir de caixa de texto
        private void ServoAngle_Click(object sender, EventArgs e)
        {
            //Send angle value to Servo
            string m1 = "S" + textBox2.Text; //S it's the command letter for the servo -> then behind will be a number that we will type in the box that will be between  0 and 180 degrees 
            serialPort1.Write(m1); //Send the data to arduino
        }

        //Função: Settar intensidade de um led
        private void RedVal_Scroll(object sender, EventArgs e)
        {
            //Capture the value of the track bar and store it in a command string for the buttton to send when clicked
            //But first we need criate a string variable to hold the red data
            //Set RGB Red value
            red = "R" + RedVal.Value; //We take the red string that we created and set it equal to a capital R wich is the command character or the character code that we will use to 
            //In this case the red variable will be updated as a track bar is scrolled
        }
        private void SendRedVal_Click(object sender, EventArgs e)
        {
            //
            if (string.IsNullOrEmpty(red))
            {
                red = "R0";
            }
            serialPort1.Write(red);
        }

        //Função: Settar ângulo para o servo: a partir de uma trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        { //Trackbar do Servo
            angle = "Z" + ServoVal.Value;
        }
        private void AnguloServo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(angle))
            {
                angle = "Z0";
            }
            serialPort1.Write(angle);
        }

        //Função: Ligar led
        private void SendLed_Click(object sender, EventArgs e)
        {
            //Send command to the arduino to turn pin 3 on
            serialPort1.Write("B");
        }

        //Função: Desligar led
        private void SendLedOff_Click(object sender, EventArgs e)
        {
            //Send command to the arduino to turn pin 3 off
            serialPort1.Write("b");
        }

        //Função: Ligar sensor LDR
        private void SendLdrOn_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }

        //Função: Desligar sensor LDR
        private void SendLdrOff_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
        //Função: Ligar sensor LM35 
        private void SendLm35On_Click(object sender, EventArgs e)
        {
            serialPort1.Write("E");
        }

        //Função: Desligar sensor LM35
        private void SendLm35Off_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}