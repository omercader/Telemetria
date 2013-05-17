'
' Created by SharpDevelop.
' User: oriol
' Date: 2/28/2013
' Time: 9:28 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.settingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.cboCom = New System.Windows.Forms.ToolStripComboBox()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsLogfile = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.TestUSBStickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.btnConnect = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblSpeedR = New System.Windows.Forms.Label()
		Me.lblSpeedL = New System.Windows.Forms.Label()
		Me.lblMotorRVal = New System.Windows.Forms.Label()
		Me.lblMotorLVal = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.trcSpeedR = New System.Windows.Forms.TrackBar()
		Me.trcSpeedL = New System.Windows.Forms.TrackBar()
		Me.trcMotorR = New System.Windows.Forms.TrackBar()
		Me.trcMotorL = New System.Windows.Forms.TrackBar()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.picGraph = New System.Windows.Forms.PictureBox()
		Me.btnGraph = New System.Windows.Forms.Button()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.txtVersion = New System.Windows.Forms.Label()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.serialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.artificialHorizon1 = New ArtificialHorizon.ArtificialHorizon()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.sendButton6 = New System.Windows.Forms.Button()
		Me.sendButton5 = New System.Windows.Forms.Button()
		Me.sendButton4 = New System.Windows.Forms.Button()
		Me.sendButton3 = New System.Windows.Forms.Button()
		Me.sendButton2 = New System.Windows.Forms.Button()
		Me.sentLabel = New System.Windows.Forms.Label()
		Me.saveButton = New System.Windows.Forms.Button()
		Me.sendButton1 = New System.Windows.Forms.Button()
		Me.label12 = New System.Windows.Forms.Label()
		Me.paramBox6 = New System.Windows.Forms.TextBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.paramBox5 = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.paramBox4 = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.paramBox3 = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.paramBox2 = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.paramBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.menuStrip1.SuspendLayout
		Me.groupBox1.SuspendLayout
		CType(Me.trcSpeedR,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.trcSpeedL,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.trcMotorR,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.trcMotorL,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.picGraph,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.settingsToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(839, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'settingsToolStripMenuItem
		'
		Me.settingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.cboCom, Me.toolStripSeparator1, Me.tsLogfile, Me.toolStripSeparator2, Me.TestUSBStickToolStripMenuItem})
		Me.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem"
		Me.settingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.settingsToolStripMenuItem.Text = "Settings"
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
		Me.toolStripMenuItem1.Text = "SerialPort"
		'
		'cboCom
		'
		Me.cboCom.Name = "cboCom"
		Me.cboCom.Size = New System.Drawing.Size(121, 23)
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(178, 6)
		'
		'tsLogfile
		'
		Me.tsLogfile.CheckOnClick = true
		Me.tsLogfile.Name = "tsLogfile"
		Me.tsLogfile.Size = New System.Drawing.Size(181, 22)
		Me.tsLogfile.Text = "write LogFile"
		AddHandler Me.tsLogfile.Click, AddressOf Me.TsLogfileClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(178, 6)
		'
		'TestUSBStickToolStripMenuItem
		'
		Me.TestUSBStickToolStripMenuItem.Name = "TestUSBStickToolStripMenuItem"
		Me.TestUSBStickToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
		Me.TestUSBStickToolStripMenuItem.Text = "test USB Stick"
		'
		'btnConnect
		'
		Me.btnConnect.Location = New System.Drawing.Point(41, 65)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(75, 23)
		Me.btnConnect.TabIndex = 1
		Me.btnConnect.Text = "Connect"
		Me.btnConnect.UseVisualStyleBackColor = true
		AddHandler Me.btnConnect.Click, AddressOf Me.BtnConnectClick
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(41, 94)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(105, 23)
		Me.button2.TabIndex = 2
		Me.button2.Text = "Reset MinMax"
		Me.button2.UseVisualStyleBackColor = true
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.lblSpeedR)
		Me.groupBox1.Controls.Add(Me.lblSpeedL)
		Me.groupBox1.Controls.Add(Me.lblMotorRVal)
		Me.groupBox1.Controls.Add(Me.lblMotorLVal)
		Me.groupBox1.Controls.Add(Me.label6)
		Me.groupBox1.Controls.Add(Me.label5)
		Me.groupBox1.Controls.Add(Me.label4)
		Me.groupBox1.Controls.Add(Me.label3)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Controls.Add(Me.trcSpeedR)
		Me.groupBox1.Controls.Add(Me.trcSpeedL)
		Me.groupBox1.Controls.Add(Me.trcMotorR)
		Me.groupBox1.Controls.Add(Me.trcMotorL)
		Me.groupBox1.Location = New System.Drawing.Point(363, 27)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(224, 344)
		Me.groupBox1.TabIndex = 3
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Motors"
		AddHandler Me.groupBox1.Enter, AddressOf Me.GroupBox1Enter
		'
		'lblSpeedR
		'
		Me.lblSpeedR.Location = New System.Drawing.Point(171, 298)
		Me.lblSpeedR.Name = "lblSpeedR"
		Me.lblSpeedR.Size = New System.Drawing.Size(26, 23)
		Me.lblSpeedR.TabIndex = 13
		Me.lblSpeedR.Text = "ND"
		'
		'lblSpeedL
		'
		Me.lblSpeedL.Location = New System.Drawing.Point(125, 298)
		Me.lblSpeedL.Name = "lblSpeedL"
		Me.lblSpeedL.Size = New System.Drawing.Size(26, 23)
		Me.lblSpeedL.TabIndex = 12
		Me.lblSpeedL.Text = "ND"
		'
		'lblMotorRVal
		'
		Me.lblMotorRVal.Location = New System.Drawing.Point(74, 298)
		Me.lblMotorRVal.Name = "lblMotorRVal"
		Me.lblMotorRVal.Size = New System.Drawing.Size(26, 23)
		Me.lblMotorRVal.TabIndex = 11
		Me.lblMotorRVal.Text = "ND"
		'
		'lblMotorLVal
		'
		Me.lblMotorLVal.Location = New System.Drawing.Point(22, 298)
		Me.lblMotorLVal.Name = "lblMotorLVal"
		Me.lblMotorLVal.Size = New System.Drawing.Size(26, 23)
		Me.lblMotorLVal.TabIndex = 10
		Me.lblMotorLVal.Text = "ND"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(171, 65)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(17, 23)
		Me.label6.TabIndex = 9
		Me.label6.Text = "R"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(74, 65)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(17, 23)
		Me.label5.TabIndex = 8
		Me.label5.Text = "R"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(125, 65)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(17, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "L"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(31, 47)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(37, 23)
		Me.label3.TabIndex = 6
		Me.label3.Text = "L"
		AddHandler Me.label3.Click, AddressOf Me.Label3Click
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(143, 24)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(42, 23)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Speed"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(39, 24)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(42, 23)
		Me.label1.TabIndex = 4
		Me.label1.Text = "Power"
		AddHandler Me.label1.Click, AddressOf Me.Label1Click
		'
		'trcSpeedR
		'
		Me.trcSpeedR.Enabled = false
		Me.trcSpeedR.Location = New System.Drawing.Point(171, 91)
		Me.trcSpeedR.Maximum = 20
		Me.trcSpeedR.Minimum = -20
		Me.trcSpeedR.Name = "trcSpeedR"
		Me.trcSpeedR.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.trcSpeedR.Size = New System.Drawing.Size(45, 198)
		Me.trcSpeedR.TabIndex = 3
		'
		'trcSpeedL
		'
		Me.trcSpeedL.Enabled = false
		Me.trcSpeedL.Location = New System.Drawing.Point(125, 91)
		Me.trcSpeedL.Maximum = 20
		Me.trcSpeedL.Minimum = -20
		Me.trcSpeedL.Name = "trcSpeedL"
		Me.trcSpeedL.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.trcSpeedL.Size = New System.Drawing.Size(45, 198)
		Me.trcSpeedL.TabIndex = 2
		'
		'trcMotorR
		'
		Me.trcMotorR.Enabled = false
		Me.trcMotorR.Location = New System.Drawing.Point(74, 91)
		Me.trcMotorR.Maximum = 250
		Me.trcMotorR.Minimum = -250
		Me.trcMotorR.Name = "trcMotorR"
		Me.trcMotorR.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.trcMotorR.Size = New System.Drawing.Size(45, 198)
		Me.trcMotorR.TabIndex = 1
		'
		'trcMotorL
		'
		Me.trcMotorL.Enabled = false
		Me.trcMotorL.Location = New System.Drawing.Point(23, 91)
		Me.trcMotorL.Maximum = 250
		Me.trcMotorL.Minimum = -250
		Me.trcMotorL.Name = "trcMotorL"
		Me.trcMotorL.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.trcMotorL.Size = New System.Drawing.Size(45, 198)
		Me.trcMotorL.TabIndex = 0
		'
		'groupBox2
		'
		Me.groupBox2.Location = New System.Drawing.Point(596, 27)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(231, 344)
		Me.groupBox2.TabIndex = 4
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Battery"
		'
		'picGraph
		'
		Me.picGraph.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.picGraph.Location = New System.Drawing.Point(12, 425)
		Me.picGraph.Name = "picGraph"
		Me.picGraph.Size = New System.Drawing.Size(585, 255)
		Me.picGraph.TabIndex = 5
		Me.picGraph.TabStop = false
		'
		'btnGraph
		'
		Me.btnGraph.Location = New System.Drawing.Point(12, 396)
		Me.btnGraph.Name = "btnGraph"
		Me.btnGraph.Size = New System.Drawing.Size(75, 23)
		Me.btnGraph.TabIndex = 6
		Me.btnGraph.Text = "Graph"
		Me.btnGraph.UseVisualStyleBackColor = true
		AddHandler Me.btnGraph.Click, AddressOf Me.BtnGraphClick
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'txtVersion
		'
		Me.txtVersion.Location = New System.Drawing.Point(41, 39)
		Me.txtVersion.Name = "txtVersion"
		Me.txtVersion.Size = New System.Drawing.Size(175, 23)
		Me.txtVersion.TabIndex = 7
		Me.txtVersion.Text = "No Connection"
		'
		'artificialHorizon1
		'
		Me.artificialHorizon1.AutoScroll = true
		Me.artificialHorizon1.Location = New System.Drawing.Point(30, 133)
		Me.artificialHorizon1.Name = "artificialHorizon1"
		Me.artificialHorizon1.pitch_angle = 0R
		Me.artificialHorizon1.roll_angle = 0R
		Me.artificialHorizon1.Size = New System.Drawing.Size(266, 257)
		Me.artificialHorizon1.TabIndex = 8
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.sendButton6)
		Me.groupBox3.Controls.Add(Me.sendButton5)
		Me.groupBox3.Controls.Add(Me.sendButton4)
		Me.groupBox3.Controls.Add(Me.sendButton3)
		Me.groupBox3.Controls.Add(Me.sendButton2)
		Me.groupBox3.Controls.Add(Me.sentLabel)
		Me.groupBox3.Controls.Add(Me.saveButton)
		Me.groupBox3.Controls.Add(Me.sendButton1)
		Me.groupBox3.Controls.Add(Me.label12)
		Me.groupBox3.Controls.Add(Me.paramBox6)
		Me.groupBox3.Controls.Add(Me.label11)
		Me.groupBox3.Controls.Add(Me.paramBox5)
		Me.groupBox3.Controls.Add(Me.label10)
		Me.groupBox3.Controls.Add(Me.paramBox4)
		Me.groupBox3.Controls.Add(Me.label9)
		Me.groupBox3.Controls.Add(Me.paramBox3)
		Me.groupBox3.Controls.Add(Me.label8)
		Me.groupBox3.Controls.Add(Me.paramBox2)
		Me.groupBox3.Controls.Add(Me.label7)
		Me.groupBox3.Controls.Add(Me.paramBox1)
		Me.groupBox3.Location = New System.Drawing.Point(603, 425)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(224, 255)
		Me.groupBox3.TabIndex = 23
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Parameters"
		'
		'sendButton6
		'
		Me.sendButton6.Location = New System.Drawing.Point(172, 152)
		Me.sendButton6.Name = "sendButton6"
		Me.sendButton6.Size = New System.Drawing.Size(46, 23)
		Me.sendButton6.TabIndex = 42
		Me.sendButton6.Text = "Send"
		Me.sendButton6.UseVisualStyleBackColor = true
		AddHandler Me.sendButton6.Click, AddressOf Me.BtnSendClick
		'
		'sendButton5
		'
		Me.sendButton5.Location = New System.Drawing.Point(172, 126)
		Me.sendButton5.Name = "sendButton5"
		Me.sendButton5.Size = New System.Drawing.Size(46, 23)
		Me.sendButton5.TabIndex = 41
		Me.sendButton5.Text = "Send"
		Me.sendButton5.UseVisualStyleBackColor = true
		AddHandler Me.sendButton5.Click, AddressOf Me.BtnSendClick
		'
		'sendButton4
		'
		Me.sendButton4.Location = New System.Drawing.Point(172, 101)
		Me.sendButton4.Name = "sendButton4"
		Me.sendButton4.Size = New System.Drawing.Size(46, 23)
		Me.sendButton4.TabIndex = 40
		Me.sendButton4.Text = "Send"
		Me.sendButton4.UseVisualStyleBackColor = true
		AddHandler Me.sendButton4.Click, AddressOf Me.BtnSendClick
		'
		'sendButton3
		'
		Me.sendButton3.Location = New System.Drawing.Point(172, 75)
		Me.sendButton3.Name = "sendButton3"
		Me.sendButton3.Size = New System.Drawing.Size(46, 23)
		Me.sendButton3.TabIndex = 39
		Me.sendButton3.Text = "Send"
		Me.sendButton3.UseVisualStyleBackColor = true
		AddHandler Me.sendButton3.Click, AddressOf Me.BtnSendClick
		'
		'sendButton2
		'
		Me.sendButton2.Location = New System.Drawing.Point(172, 49)
		Me.sendButton2.Name = "sendButton2"
		Me.sendButton2.Size = New System.Drawing.Size(46, 23)
		Me.sendButton2.TabIndex = 38
		Me.sendButton2.Text = "Send"
		Me.sendButton2.UseVisualStyleBackColor = true
		AddHandler Me.sendButton2.Click, AddressOf Me.BtnSendClick
		'
		'sentLabel
		'
		Me.sentLabel.ForeColor = System.Drawing.Color.Red
		Me.sentLabel.Location = New System.Drawing.Point(107, 210)
		Me.sentLabel.Name = "sentLabel"
		Me.sentLabel.Size = New System.Drawing.Size(60, 23)
		Me.sentLabel.TabIndex = 37
		Me.sentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'saveButton
		'
		Me.saveButton.Location = New System.Drawing.Point(26, 210)
		Me.saveButton.Name = "saveButton"
		Me.saveButton.Size = New System.Drawing.Size(75, 23)
		Me.saveButton.TabIndex = 36
		Me.saveButton.Text = "Save"
		Me.saveButton.UseVisualStyleBackColor = true
		AddHandler Me.saveButton.Click, AddressOf Me.BtnSaveClick
		'
		'sendButton1
		'
		Me.sendButton1.Location = New System.Drawing.Point(172, 23)
		Me.sendButton1.Name = "sendButton1"
		Me.sendButton1.Size = New System.Drawing.Size(46, 23)
		Me.sendButton1.TabIndex = 35
		Me.sendButton1.Text = "Send"
		Me.sendButton1.UseVisualStyleBackColor = true
		AddHandler Me.sendButton1.Click, AddressOf Me.BtnSendClick
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(132, 152)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(43, 23)
		Me.label12.TabIndex = 34
		Me.label12.Text = "P6"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'paramBox6
		'
		Me.paramBox6.Location = New System.Drawing.Point(26, 154)
		Me.paramBox6.Name = "paramBox6"
		Me.paramBox6.Size = New System.Drawing.Size(100, 20)
		Me.paramBox6.TabIndex = 33
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(132, 126)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(43, 23)
		Me.label11.TabIndex = 32
		Me.label11.Text = "P5"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'paramBox5
		'
		Me.paramBox5.Location = New System.Drawing.Point(26, 128)
		Me.paramBox5.Name = "paramBox5"
		Me.paramBox5.Size = New System.Drawing.Size(100, 20)
		Me.paramBox5.TabIndex = 31
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(132, 100)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(43, 23)
		Me.label10.TabIndex = 30
		Me.label10.Text = "P4"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'paramBox4
		'
		Me.paramBox4.Location = New System.Drawing.Point(26, 102)
		Me.paramBox4.Name = "paramBox4"
		Me.paramBox4.Size = New System.Drawing.Size(100, 20)
		Me.paramBox4.TabIndex = 29
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(132, 74)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(43, 23)
		Me.label9.TabIndex = 28
		Me.label9.Text = "P3"
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'paramBox3
		'
		Me.paramBox3.Location = New System.Drawing.Point(26, 76)
		Me.paramBox3.Name = "paramBox3"
		Me.paramBox3.Size = New System.Drawing.Size(100, 20)
		Me.paramBox3.TabIndex = 27
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(132, 48)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(43, 23)
		Me.label8.TabIndex = 26
		Me.label8.Text = "P2"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'paramBox2
		'
		Me.paramBox2.Location = New System.Drawing.Point(26, 50)
		Me.paramBox2.Name = "paramBox2"
		Me.paramBox2.Size = New System.Drawing.Size(100, 20)
		Me.paramBox2.TabIndex = 25
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(132, 22)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(43, 23)
		Me.label7.TabIndex = 24
		Me.label7.Text = "P1"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'paramBox1
		'
		Me.paramBox1.Location = New System.Drawing.Point(26, 24)
		Me.paramBox1.Name = "paramBox1"
		Me.paramBox1.Size = New System.Drawing.Size(100, 20)
		Me.paramBox1.TabIndex = 23
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(160, 65)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 24
		Me.button1.Text = "Get Params"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.BtnGetClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(839, 692)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.artificialHorizon1)
		Me.Controls.Add(Me.txtVersion)
		Me.Controls.Add(Me.btnGraph)
		Me.Controls.Add(Me.picGraph)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.btnConnect)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "Telemetria"
		AddHandler Load, AddressOf Me.MainForm_Load
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		CType(Me.trcSpeedR,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.trcSpeedL,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.trcMotorR,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.trcMotorL,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.picGraph,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private sendButton2 As System.Windows.Forms.Button
	Private sendButton3 As System.Windows.Forms.Button
	Private sendButton4 As System.Windows.Forms.Button
	Private sendButton5 As System.Windows.Forms.Button
	Private sendButton6 As System.Windows.Forms.Button
	Private sentLabel As System.Windows.Forms.Label
	Private paramBox2 As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Private paramBox3 As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Private paramBox4 As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private paramBox5 As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private paramBox6 As System.Windows.Forms.TextBox
	Private label12 As System.Windows.Forms.Label
	Private sendButton1 As System.Windows.Forms.Button
	Private saveButton As System.Windows.Forms.Button
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private label7 As System.Windows.Forms.Label
	Private paramBox1 As System.Windows.Forms.TextBox
	Private artificialHorizon1 As ArtificialHorizon.ArtificialHorizon
	Private serialPort1 As System.IO.Ports.SerialPort
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private TestUSBStickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private txtVersion As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
	Private btnGraph As System.Windows.Forms.Button
	Private picGraph As System.Windows.Forms.PictureBox
	Private lblMotorLVal As System.Windows.Forms.Label
	Private lblMotorRVal As System.Windows.Forms.Label
	Private lblSpeedL As System.Windows.Forms.Label
	Private lblSpeedR As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private trcMotorL As System.Windows.Forms.TrackBar
	Private trcMotorR As System.Windows.Forms.TrackBar
	Private trcSpeedL As System.Windows.Forms.TrackBar
	Private trcSpeedR As System.Windows.Forms.TrackBar
	Private label1 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private button2 As System.Windows.Forms.Button
	Private btnConnect As System.Windows.Forms.Button
	Private tsLogfile As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private cboCom As System.Windows.Forms.ToolStripComboBox
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private settingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	
	Sub ArtificialHorizon1Load(sender As Object, e As EventArgs)
		
	End Sub
End Class
