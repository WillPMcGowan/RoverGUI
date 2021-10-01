
namespace ARUDINOGUI
{
    partial class ArduinoGUI
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.forward = new System.Windows.Forms.Button();
            this.right1 = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.waterDetected = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.Control = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WaterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.WaterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.SystemColors.Info;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forward.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward.ForeColor = System.Drawing.SystemColors.Desktop;
            this.forward.Location = new System.Drawing.Point(96, 22);
            this.forward.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(104, 43);
            this.forward.TabIndex = 0;
            this.forward.Text = "forward";
            this.forward.UseVisualStyleBackColor = false;
            this.forward.Click += new System.EventHandler(this.forward_click);
            // 
            // right1
            // 
            this.right1.BackColor = System.Drawing.SystemColors.Info;
            this.right1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.right1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.right1.Location = new System.Drawing.Point(205, 107);
            this.right1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(78, 43);
            this.right1.TabIndex = 1;
            this.right1.Text = "right";
            this.right1.UseVisualStyleBackColor = false;
            this.right1.Click += new System.EventHandler(this.right_click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.SystemColors.Info;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.left.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.ForeColor = System.Drawing.SystemColors.Desktop;
            this.left.Location = new System.Drawing.Point(15, 107);
            this.left.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(78, 43);
            this.left.TabIndex = 2;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(117, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.stop_click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(78, 70);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 30);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // waterDetected
            // 
            this.waterDetected.BackColor = System.Drawing.Color.Green;
            this.waterDetected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterDetected.Font = new System.Drawing.Font("Candara Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterDetected.ForeColor = System.Drawing.SystemColors.InfoText;
            this.waterDetected.Location = new System.Drawing.Point(56, 162);
            this.waterDetected.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.waterDetected.Name = "waterDetected";
            this.waterDetected.Size = new System.Drawing.Size(170, 32);
            this.waterDetected.TabIndex = 7;
            this.waterDetected.Text = "No water";
            this.waterDetected.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Info;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Desktop;
            this.back.Location = new System.Drawing.Point(96, 195);
            this.back.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 43);
            this.back.TabIndex = 8;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_click);
            // 
            // Control
            // 
            this.Control.AutoSize = true;
            this.Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Control.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.ForeColor = System.Drawing.Color.BlueViolet;
            this.Control.Location = new System.Drawing.Point(159, 48);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(79, 24);
            this.Control.TabIndex = 10;
            this.Control.Text = "Controller";
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.forward);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.left);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.right1);
            this.panel1.Location = new System.Drawing.Point(46, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 258);
            this.panel1.TabIndex = 11;
            // 
            // WaterPanel
            // 
            this.WaterPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WaterPanel.Controls.Add(this.label3);
            this.WaterPanel.Controls.Add(this.label2);
            this.WaterPanel.Controls.Add(this.waterDetected);
            this.WaterPanel.Controls.Add(this.textBox3);
            this.WaterPanel.Location = new System.Drawing.Point(417, 112);
            this.WaterPanel.Name = "WaterPanel";
            this.WaterPanel.Size = new System.Drawing.Size(292, 258);
            this.WaterPanel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Warning";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(491, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Water Detection";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(854, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Distance Sensor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(780, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 258);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Distance ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(78, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 32);
            this.textBox2.TabIndex = 6;
            // 
            // ArduinoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaterPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Control);
            this.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ArduinoGUI";
            this.Text = "ArduinoGUI";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.WaterPanel.ResumeLayout(false);
            this.WaterPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button right1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox waterDetected;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label Control;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel WaterPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}

