namespace TCP_server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.connectBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.setControlParamsGroup = new System.Windows.Forms.GroupBox();
            this.updateControlButton = new System.Windows.Forms.Button();
            this.setKdLabel = new System.Windows.Forms.Label();
            this.setKdTextBox = new System.Windows.Forms.TextBox();
            this.setKiLabel = new System.Windows.Forms.Label();
            this.setKiTextBox = new System.Windows.Forms.TextBox();
            this.setKpLabel = new System.Windows.Forms.Label();
            this.setKpTextBox = new System.Windows.Forms.TextBox();
            this.setGainLabel = new System.Windows.Forms.Label();
            this.setGainTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cwRadioButton = new System.Windows.Forms.RadioButton();
            this.speedLabel = new System.Windows.Forms.Label();
            this.ccwRadioButton = new System.Windows.Forms.RadioButton();
            this.rotateButton = new System.Windows.Forms.Button();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.getControlParamsGroup = new System.Windows.Forms.GroupBox();
            this.getKdLabel = new System.Windows.Forms.Label();
            this.getKdTextBox = new System.Windows.Forms.TextBox();
            this.getKiLabel = new System.Windows.Forms.Label();
            this.getKiTextBox = new System.Windows.Forms.TextBox();
            this.getKpLabel = new System.Windows.Forms.Label();
            this.getKpTextBox = new System.Windows.Forms.TextBox();
            this.getGainLabel = new System.Windows.Forms.Label();
            this.getGainTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setLimitButton = new System.Windows.Forms.Button();
            this.setContinuousCurrentLimitLabel = new System.Windows.Forms.Label();
            this.setContinuousCurrentLimitTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.connectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.setControlParamsGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.getControlParamsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(26, 65);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(133, 36);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect IoT Device";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectBox
            // 
            this.connectBox.Controls.Add(this.pictureBox1);
            this.connectBox.Controls.Add(this.portLabel);
            this.connectBox.Controls.Add(this.ipLabel);
            this.connectBox.Controls.Add(this.portBox);
            this.connectBox.Controls.Add(this.disconnectButton);
            this.connectBox.Controls.Add(this.ipBox);
            this.connectBox.Controls.Add(this.connectButton);
            this.connectBox.Location = new System.Drawing.Point(9, 28);
            this.connectBox.Margin = new System.Windows.Forms.Padding(2);
            this.connectBox.Name = "connectBox";
            this.connectBox.Padding = new System.Windows.Forms.Padding(2);
            this.connectBox.Size = new System.Drawing.Size(187, 270);
            this.connectBox.TabIndex = 1;
            this.connectBox.TabStop = false;
            this.connectBox.Text = "Connect";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(124, 23);
            this.portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 17;
            this.portLabel.Text = "Port:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(4, 23);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(58, 13);
            this.ipLabel.TabIndex = 16;
            this.ipLabel.Text = "IP Address";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(127, 40);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(56, 20);
            this.portBox.TabIndex = 15;
            this.portBox.Text = "5006";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(26, 219);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(133, 36);
            this.disconnectButton.TabIndex = 14;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(5, 40);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 13;
            this.ipBox.Text = "192.168.56.1";
            // 
            // setControlParamsGroup
            // 
            this.setControlParamsGroup.Controls.Add(this.updateControlButton);
            this.setControlParamsGroup.Controls.Add(this.setKdLabel);
            this.setControlParamsGroup.Controls.Add(this.setKdTextBox);
            this.setControlParamsGroup.Controls.Add(this.setKiLabel);
            this.setControlParamsGroup.Controls.Add(this.setKiTextBox);
            this.setControlParamsGroup.Controls.Add(this.setKpLabel);
            this.setControlParamsGroup.Controls.Add(this.setKpTextBox);
            this.setControlParamsGroup.Controls.Add(this.setGainLabel);
            this.setControlParamsGroup.Controls.Add(this.setGainTextBox);
            this.setControlParamsGroup.Location = new System.Drawing.Point(303, 28);
            this.setControlParamsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.setControlParamsGroup.Name = "setControlParamsGroup";
            this.setControlParamsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.setControlParamsGroup.Size = new System.Drawing.Size(98, 270);
            this.setControlParamsGroup.TabIndex = 2;
            this.setControlParamsGroup.TabStop = false;
            this.setControlParamsGroup.Text = "Set Control Rotation";
            // 
            // updateControlButton
            // 
            this.updateControlButton.Location = new System.Drawing.Point(9, 224);
            this.updateControlButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateControlButton.Name = "updateControlButton";
            this.updateControlButton.Size = new System.Drawing.Size(68, 30);
            this.updateControlButton.TabIndex = 15;
            this.updateControlButton.Text = "Update";
            this.updateControlButton.UseVisualStyleBackColor = true;
            this.updateControlButton.Click += new System.EventHandler(this.updateControlButton_Click);
            // 
            // setKdLabel
            // 
            this.setKdLabel.AutoSize = true;
            this.setKdLabel.Location = new System.Drawing.Point(7, 180);
            this.setKdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setKdLabel.Name = "setKdLabel";
            this.setKdLabel.Size = new System.Drawing.Size(20, 13);
            this.setKdLabel.TabIndex = 7;
            this.setKdLabel.Text = "Kd";
            // 
            // setKdTextBox
            // 
            this.setKdTextBox.Location = new System.Drawing.Point(7, 196);
            this.setKdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.setKdTextBox.Name = "setKdTextBox";
            this.setKdTextBox.Size = new System.Drawing.Size(72, 20);
            this.setKdTextBox.TabIndex = 6;
            this.setKdTextBox.Text = "0";
            // 
            // setKiLabel
            // 
            this.setKiLabel.AutoSize = true;
            this.setKiLabel.Location = new System.Drawing.Point(7, 139);
            this.setKiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setKiLabel.Name = "setKiLabel";
            this.setKiLabel.Size = new System.Drawing.Size(16, 13);
            this.setKiLabel.TabIndex = 5;
            this.setKiLabel.Text = "Ki";
            // 
            // setKiTextBox
            // 
            this.setKiTextBox.Location = new System.Drawing.Point(7, 155);
            this.setKiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.setKiTextBox.Name = "setKiTextBox";
            this.setKiTextBox.Size = new System.Drawing.Size(72, 20);
            this.setKiTextBox.TabIndex = 4;
            this.setKiTextBox.Text = "0";
            // 
            // setKpLabel
            // 
            this.setKpLabel.AutoSize = true;
            this.setKpLabel.Location = new System.Drawing.Point(7, 96);
            this.setKpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setKpLabel.Name = "setKpLabel";
            this.setKpLabel.Size = new System.Drawing.Size(20, 13);
            this.setKpLabel.TabIndex = 3;
            this.setKpLabel.Text = "Kp";
            // 
            // setKpTextBox
            // 
            this.setKpTextBox.Location = new System.Drawing.Point(7, 112);
            this.setKpTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.setKpTextBox.Name = "setKpTextBox";
            this.setKpTextBox.Size = new System.Drawing.Size(72, 20);
            this.setKpTextBox.TabIndex = 2;
            this.setKpTextBox.Text = "0";
            // 
            // setGainLabel
            // 
            this.setGainLabel.AutoSize = true;
            this.setGainLabel.Location = new System.Drawing.Point(4, 54);
            this.setGainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setGainLabel.Name = "setGainLabel";
            this.setGainLabel.Size = new System.Drawing.Size(29, 13);
            this.setGainLabel.TabIndex = 1;
            this.setGainLabel.Text = "Gain";
            // 
            // setGainTextBox
            // 
            this.setGainTextBox.Location = new System.Drawing.Point(7, 71);
            this.setGainTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.setGainTextBox.Name = "setGainTextBox";
            this.setGainTextBox.Size = new System.Drawing.Size(72, 20);
            this.setGainTextBox.TabIndex = 0;
            this.setGainTextBox.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cwRadioButton);
            this.groupBox3.Controls.Add(this.speedLabel);
            this.groupBox3.Controls.Add(this.ccwRadioButton);
            this.groupBox3.Controls.Add(this.rotateButton);
            this.groupBox3.Controls.Add(this.speedTextBox);
            this.groupBox3.Location = new System.Drawing.Point(406, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(172, 145);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gripper Actions";
            // 
            // cwRadioButton
            // 
            this.cwRadioButton.AutoSize = true;
            this.cwRadioButton.Location = new System.Drawing.Point(4, 93);
            this.cwRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.cwRadioButton.Name = "cwRadioButton";
            this.cwRadioButton.Size = new System.Drawing.Size(73, 17);
            this.cwRadioButton.TabIndex = 18;
            this.cwRadioButton.Text = "Clockwise";
            this.cwRadioButton.UseVisualStyleBackColor = false;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(80, 124);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(71, 13);
            this.speedLabel.TabIndex = 17;
            this.speedLabel.Text = "Speed (RPM)";
            // 
            // ccwRadioButton
            // 
            this.ccwRadioButton.AutoSize = true;
            this.ccwRadioButton.Checked = true;
            this.ccwRadioButton.Location = new System.Drawing.Point(4, 73);
            this.ccwRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ccwRadioButton.Name = "ccwRadioButton";
            this.ccwRadioButton.Size = new System.Drawing.Size(113, 17);
            this.ccwRadioButton.TabIndex = 1;
            this.ccwRadioButton.TabStop = true;
            this.ccwRadioButton.Text = "Counter Clockwise";
            this.ccwRadioButton.UseVisualStyleBackColor = true;
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(44, 31);
            this.rotateButton.Margin = new System.Windows.Forms.Padding(2);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(87, 36);
            this.rotateButton.TabIndex = 0;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(4, 122);
            this.speedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(72, 20);
            this.speedTextBox.TabIndex = 16;
            this.speedTextBox.Text = "0";
            // 
            // getControlParamsGroup
            // 
            this.getControlParamsGroup.Controls.Add(this.getKdLabel);
            this.getControlParamsGroup.Controls.Add(this.getKdTextBox);
            this.getControlParamsGroup.Controls.Add(this.getKiLabel);
            this.getControlParamsGroup.Controls.Add(this.getKiTextBox);
            this.getControlParamsGroup.Controls.Add(this.getKpLabel);
            this.getControlParamsGroup.Controls.Add(this.getKpTextBox);
            this.getControlParamsGroup.Controls.Add(this.getGainLabel);
            this.getControlParamsGroup.Controls.Add(this.getGainTextBox);
            this.getControlParamsGroup.Location = new System.Drawing.Point(200, 28);
            this.getControlParamsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.getControlParamsGroup.Name = "getControlParamsGroup";
            this.getControlParamsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.getControlParamsGroup.Size = new System.Drawing.Size(98, 270);
            this.getControlParamsGroup.TabIndex = 16;
            this.getControlParamsGroup.TabStop = false;
            this.getControlParamsGroup.Text = "Get Control Rotation";
            // 
            // getKdLabel
            // 
            this.getKdLabel.AutoSize = true;
            this.getKdLabel.Location = new System.Drawing.Point(7, 180);
            this.getKdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.getKdLabel.Name = "getKdLabel";
            this.getKdLabel.Size = new System.Drawing.Size(20, 13);
            this.getKdLabel.TabIndex = 7;
            this.getKdLabel.Text = "Kd";
            // 
            // getKdTextBox
            // 
            this.getKdTextBox.Location = new System.Drawing.Point(7, 196);
            this.getKdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.getKdTextBox.Name = "getKdTextBox";
            this.getKdTextBox.Size = new System.Drawing.Size(72, 20);
            this.getKdTextBox.TabIndex = 6;
            this.getKdTextBox.Text = "0";
            // 
            // getKiLabel
            // 
            this.getKiLabel.AutoSize = true;
            this.getKiLabel.Location = new System.Drawing.Point(7, 139);
            this.getKiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.getKiLabel.Name = "getKiLabel";
            this.getKiLabel.Size = new System.Drawing.Size(16, 13);
            this.getKiLabel.TabIndex = 5;
            this.getKiLabel.Text = "Ki";
            // 
            // getKiTextBox
            // 
            this.getKiTextBox.Location = new System.Drawing.Point(7, 155);
            this.getKiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.getKiTextBox.Name = "getKiTextBox";
            this.getKiTextBox.Size = new System.Drawing.Size(72, 20);
            this.getKiTextBox.TabIndex = 4;
            this.getKiTextBox.Text = "0";
            // 
            // getKpLabel
            // 
            this.getKpLabel.AutoSize = true;
            this.getKpLabel.Location = new System.Drawing.Point(7, 96);
            this.getKpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.getKpLabel.Name = "getKpLabel";
            this.getKpLabel.Size = new System.Drawing.Size(20, 13);
            this.getKpLabel.TabIndex = 3;
            this.getKpLabel.Text = "Kp";
            // 
            // getKpTextBox
            // 
            this.getKpTextBox.Location = new System.Drawing.Point(7, 112);
            this.getKpTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.getKpTextBox.Name = "getKpTextBox";
            this.getKpTextBox.Size = new System.Drawing.Size(72, 20);
            this.getKpTextBox.TabIndex = 2;
            this.getKpTextBox.Text = "0";
            // 
            // getGainLabel
            // 
            this.getGainLabel.AutoSize = true;
            this.getGainLabel.Location = new System.Drawing.Point(4, 54);
            this.getGainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.getGainLabel.Name = "getGainLabel";
            this.getGainLabel.Size = new System.Drawing.Size(29, 13);
            this.getGainLabel.TabIndex = 1;
            this.getGainLabel.Text = "Gain";
            // 
            // getGainTextBox
            // 
            this.getGainTextBox.Location = new System.Drawing.Point(7, 71);
            this.getGainTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.getGainTextBox.Name = "getGainTextBox";
            this.getGainTextBox.Size = new System.Drawing.Size(72, 20);
            this.getGainTextBox.TabIndex = 0;
            this.getGainTextBox.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setLimitButton);
            this.groupBox1.Controls.Add(this.setContinuousCurrentLimitLabel);
            this.groupBox1.Controls.Add(this.setContinuousCurrentLimitTextBox);
            this.groupBox1.Location = new System.Drawing.Point(406, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter Limits";
            // 
            // setLimitButton
            // 
            this.setLimitButton.Location = new System.Drawing.Point(52, 69);
            this.setLimitButton.Margin = new System.Windows.Forms.Padding(2);
            this.setLimitButton.Name = "setLimitButton";
            this.setLimitButton.Size = new System.Drawing.Size(70, 30);
            this.setLimitButton.TabIndex = 16;
            this.setLimitButton.Text = "Set Limits";
            this.setLimitButton.UseVisualStyleBackColor = true;
            this.setLimitButton.Click += new System.EventHandler(this.setLimitButton_Click);
            // 
            // setContinuousCurrentLimitLabel
            // 
            this.setContinuousCurrentLimitLabel.AutoSize = true;
            this.setContinuousCurrentLimitLabel.Location = new System.Drawing.Point(2, 19);
            this.setContinuousCurrentLimitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setContinuousCurrentLimitLabel.Name = "setContinuousCurrentLimitLabel";
            this.setContinuousCurrentLimitLabel.Size = new System.Drawing.Size(108, 13);
            this.setContinuousCurrentLimitLabel.TabIndex = 17;
            this.setContinuousCurrentLimitLabel.Text = "Set Current Limit (mA)";
            // 
            // setContinuousCurrentLimitTextBox
            // 
            this.setContinuousCurrentLimitTextBox.Location = new System.Drawing.Point(4, 35);
            this.setContinuousCurrentLimitTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.setContinuousCurrentLimitTextBox.Name = "setContinuousCurrentLimitTextBox";
            this.setContinuousCurrentLimitTextBox.Size = new System.Drawing.Size(109, 20);
            this.setContinuousCurrentLimitTextBox.TabIndex = 16;
            this.setContinuousCurrentLimitTextBox.Text = "0";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(431, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 312);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setControlParamsGroup);
            this.Controls.Add(this.getControlParamsGroup);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.connectBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Eagle Gripper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.connectBox.ResumeLayout(false);
            this.connectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.setControlParamsGroup.ResumeLayout(false);
            this.setControlParamsGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.getControlParamsGroup.ResumeLayout(false);
            this.getControlParamsGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox connectBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.GroupBox setControlParamsGroup;
        private System.Windows.Forms.Button updateControlButton;
        private System.Windows.Forms.Label setKdLabel;
        private System.Windows.Forms.TextBox setKdTextBox;
        private System.Windows.Forms.Label setKiLabel;
        private System.Windows.Forms.TextBox setKiTextBox;
        private System.Windows.Forms.Label setKpLabel;
        private System.Windows.Forms.TextBox setKpTextBox;
        private System.Windows.Forms.Label setGainLabel;
        private System.Windows.Forms.TextBox setGainTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox getControlParamsGroup;
        private System.Windows.Forms.Label getKdLabel;
        private System.Windows.Forms.TextBox getKdTextBox;
        private System.Windows.Forms.Label getKiLabel;
        private System.Windows.Forms.TextBox getKiTextBox;
        private System.Windows.Forms.Label getKpLabel;
        private System.Windows.Forms.TextBox getKpTextBox;
        private System.Windows.Forms.Label getGainLabel;
        private System.Windows.Forms.TextBox getGainTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.RadioButton ccwRadioButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setLimitButton;
        private System.Windows.Forms.Label setContinuousCurrentLimitLabel;
        private System.Windows.Forms.TextBox setContinuousCurrentLimitTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.RadioButton cwRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statusLabel;
    }
}

