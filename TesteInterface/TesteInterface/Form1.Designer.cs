namespace TesteInterface
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panel7;
            this.RedVal = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.ServoAngle = new System.Windows.Forms.Button();
            this.ServoVal = new System.Windows.Forms.TrackBar();
            this.SendRedVal = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AnguloServo = new System.Windows.Forms.Button();
            this.SendLedOn = new System.Windows.Forms.Button();
            this.SendLedOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SendLdrOff = new System.Windows.Forms.Button();
            this.SendLdrOn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SendLm35Off = new System.Windows.Forms.Button();
            this.SendLm35On = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoVal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel7.Controls.Add(this.RedVal);
            panel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            panel7.Location = new System.Drawing.Point(25, 386);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(321, 61);
            panel7.TabIndex = 21;
            // 
            // RedVal
            // 
            this.RedVal.Location = new System.Drawing.Point(13, 11);
            this.RedVal.Maximum = 255;
            this.RedVal.Name = "RedVal";
            this.RedVal.Size = new System.Drawing.Size(192, 45);
            this.RedVal.TabIndex = 4;
            this.RedVal.TickFrequency = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // onButton
            // 
            this.onButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onButton.Location = new System.Drawing.Point(10, 32);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(86, 32);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "Turn ON";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offButton.Location = new System.Drawing.Point(114, 32);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(86, 32);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "Turn OFF";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // ServoAngle
            // 
            this.ServoAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServoAngle.ForeColor = System.Drawing.Color.Black;
            this.ServoAngle.Location = new System.Drawing.Point(11, 55);
            this.ServoAngle.Name = "ServoAngle";
            this.ServoAngle.Size = new System.Drawing.Size(98, 26);
            this.ServoAngle.TabIndex = 3;
            this.ServoAngle.Text = "Send Angle";
            this.ServoAngle.UseVisualStyleBackColor = true;
            this.ServoAngle.Click += new System.EventHandler(this.ServoAngle_Click);
            // 
            // ServoVal
            // 
            this.ServoVal.Location = new System.Drawing.Point(278, 301);
            this.ServoVal.Maximum = 180;
            this.ServoVal.Name = "ServoVal";
            this.ServoVal.Size = new System.Drawing.Size(227, 45);
            this.ServoVal.TabIndex = 5;
            this.ServoVal.TickFrequency = 10;
            this.ServoVal.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SendRedVal
            // 
            this.SendRedVal.Location = new System.Drawing.Point(259, 402);
            this.SendRedVal.Name = "SendRedVal";
            this.SendRedVal.Size = new System.Drawing.Size(75, 23);
            this.SendRedVal.TabIndex = 6;
            this.SendRedVal.Text = "Send Red Value";
            this.SendRedVal.UseVisualStyleBackColor = true;
            this.SendRedVal.Click += new System.EventHandler(this.SendRedVal_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // AnguloServo
            // 
            this.AnguloServo.Location = new System.Drawing.Point(524, 304);
            this.AnguloServo.Name = "AnguloServo";
            this.AnguloServo.Size = new System.Drawing.Size(86, 23);
            this.AnguloServo.TabIndex = 8;
            this.AnguloServo.Text = "MandarAngulo";
            this.AnguloServo.UseVisualStyleBackColor = true;
            this.AnguloServo.Click += new System.EventHandler(this.AnguloServo_Click);
            // 
            // SendLedOn
            // 
            this.SendLedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLedOn.Location = new System.Drawing.Point(3, 35);
            this.SendLedOn.Name = "SendLedOn";
            this.SendLedOn.Size = new System.Drawing.Size(106, 32);
            this.SendLedOn.TabIndex = 9;
            this.SendLedOn.Text = "Turn Led On";
            this.SendLedOn.UseVisualStyleBackColor = true;
            this.SendLedOn.Click += new System.EventHandler(this.SendLed_Click);
            // 
            // SendLedOff
            // 
            this.SendLedOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLedOff.Location = new System.Drawing.Point(115, 35);
            this.SendLedOff.Name = "SendLedOff";
            this.SendLedOff.Size = new System.Drawing.Size(112, 32);
            this.SendLedOff.TabIndex = 10;
            this.SendLedOff.Text = "Turn Led Off";
            this.SendLedOff.UseVisualStyleBackColor = true;
            this.SendLedOff.Click += new System.EventHandler(this.SendLedOff_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.ServoAngle);
            this.panel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(13, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 115);
            this.panel1.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(34, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 64);
            this.panel6.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(232, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Set Servo Angle";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.offButton);
            this.panel2.Controls.Add(this.onButton);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 100);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Toggle Led Arduino";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SendLedOff);
            this.panel3.Controls.Add(this.SendLedOn);
            this.panel3.Location = new System.Drawing.Point(325, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 100);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(375, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toggle Led Pin 3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TesteInterface.Properties.Resources.Arduino_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(766, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TesteInterface.Properties.Resources.vs_logo_2_0;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(362, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Arduino Control Center";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.SendLdrOff);
            this.panel4.Controls.Add(this.SendLdrOn);
            this.panel4.Location = new System.Drawing.Point(626, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 100);
            this.panel4.TabIndex = 18;
            // 
            // SendLdrOff
            // 
            this.SendLdrOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLdrOff.Location = new System.Drawing.Point(125, 35);
            this.SendLdrOff.Name = "SendLdrOff";
            this.SendLdrOff.Size = new System.Drawing.Size(122, 32);
            this.SendLdrOff.TabIndex = 3;
            this.SendLdrOff.Text = "Turn LDR OFF";
            this.SendLdrOff.UseVisualStyleBackColor = true;
            this.SendLdrOff.Click += new System.EventHandler(this.SendLdrOff_Click);
            // 
            // SendLdrOn
            // 
            this.SendLdrOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLdrOn.Location = new System.Drawing.Point(3, 35);
            this.SendLdrOn.Name = "SendLdrOn";
            this.SendLdrOn.Size = new System.Drawing.Size(113, 32);
            this.SendLdrOn.TabIndex = 2;
            this.SendLdrOn.Text = "Turn LDR ON";
            this.SendLdrOn.UseVisualStyleBackColor = true;
            this.SendLdrOn.Click += new System.EventHandler(this.SendLdrOn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "LDR Sensor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(714, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "LM35 Sensor";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.SendLm35Off);
            this.panel5.Controls.Add(this.SendLm35On);
            this.panel5.Location = new System.Drawing.Point(630, 338);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 100);
            this.panel5.TabIndex = 20;
            // 
            // SendLm35Off
            // 
            this.SendLm35Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLm35Off.Location = new System.Drawing.Point(139, 35);
            this.SendLm35Off.Name = "SendLm35Off";
            this.SendLm35Off.Size = new System.Drawing.Size(133, 32);
            this.SendLm35Off.TabIndex = 3;
            this.SendLm35Off.Text = "Turn LM35 OFF";
            this.SendLm35Off.UseVisualStyleBackColor = true;
            this.SendLm35Off.Click += new System.EventHandler(this.SendLm35Off_Click);
            // 
            // SendLm35On
            // 
            this.SendLm35On.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLm35On.Location = new System.Drawing.Point(3, 35);
            this.SendLm35On.Name = "SendLm35On";
            this.SendLm35On.Size = new System.Drawing.Size(130, 32);
            this.SendLm35On.TabIndex = 2;
            this.SendLm35On.Text = "Turn LM35 ON";
            this.SendLm35On.UseVisualStyleBackColor = true;
            this.SendLm35On.Click += new System.EventHandler(this.SendLm35On_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Set Led Intensity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AnguloServo);
            this.Controls.Add(this.ServoVal);
            this.Controls.Add(this.SendRedVal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(panel7);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Arduino Graphical User Interface in C#";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServoVal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button ServoAngle;
        private System.Windows.Forms.TrackBar RedVal;
        private System.Windows.Forms.TrackBar ServoVal;
        private System.Windows.Forms.Button SendRedVal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AnguloServo;
        private System.Windows.Forms.Button SendLedOn;
        private System.Windows.Forms.Button SendLedOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SendLdrOn;
        private System.Windows.Forms.Button SendLdrOff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button SendLm35Off;
        private System.Windows.Forms.Button SendLm35On;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
    }
}

