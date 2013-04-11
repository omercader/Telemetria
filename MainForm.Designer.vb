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
		Me.menuStrip1.SuspendLayout
		Me.groupBox1.SuspendLayout
		CType(Me.trcSpeedR,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.trcSpeedL,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.trcMotorR,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.trcMotorL,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.picGraph,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.settingsToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(818, 24)
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
		Me.tsLogfile.Name = "tsLogfile"
		Me.tsLogfile.Size = New System.Drawing.Size(181, 22)
		Me.tsLogfile.Text = "write LogFile"
		AddHandler Me.tsLogfile.Click, AddressOf Me.CboComSelectedIndexChanged
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
		Me.groupBox2.Size = New System.Drawing.Size(200, 344)
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
		Me.artificialHorizon1.Location = New System.Drawing.Point(41, 123)
		Me.artificialHorizon1.Name = "artificialHorizon1"
		Me.artificialHorizon1.pitch_angle = 0R
		Me.artificialHorizon1.roll_angle = 0R
		Me.artificialHorizon1.Size = New System.Drawing.Size(266, 257)
		Me.artificialHorizon1.TabIndex = 8
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(818, 692)
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
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
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
End Class
