Imports System.Threading
Imports System.Math
Imports System.IO.Ports
Imports System.IO

Public Partial Class MainForm
	
	    private Enum eDatenStatus as Integer
                dtCorrectData = 0
                dtNoColon = 1
                dtOtherModule = 2
        End Enum

        public Const ConVersionText  As string = "1.1.9"
    private Const constStopTestmode As String = "0"
    Private Const constStartTestmode As String = "18"
        'Dim lblGyroVal As Int16
    'Dim trcGyro As Int16
    'Dim lblGyroVal As Int16
    'Dim lblGyroVal As Int16
    'Dim lblGyroVal As Int16
    
        Private Enum eBefehl As Integer
                dtGyro = 1
                dtAdxl = 2
                dtAngelrate = 3
                dtTiltangle = 4
                dtBalancemoment = 5
                dtTotaladxlgyro = 6
                dtMotorL = 7
                dtMotorR = 8
                dtSpeedL = 9
                dtSpeedR = 10
                dtIdendity = 11
                param1 = 12
                param2 = 13
                param3 = 14
                param4 = 15
                param5 = 16
                param6 = 17
        End Enum
        dim strHeader as String = "Time;Gyro;ADXL;Anglerate;Tiltangle;Balancemoment;Totaladxlgyro;MotorL;MotorR;SpeeedL;SpeedR;Idendity;"
        dim logValues(11) as single
        Const MeinModul As Integer = 2

        Dim use_p As Boolean
        Dim strComItem As String
        'Dim currLogPath As String
        Dim logOn As Boolean

        Private m_Ymid As Integer
        Private m_Y As Integer
        Private m_Y2 As Integer
        Private m_Y3 As Integer
        Private Const GRID_STEP As Integer = 50
        Private m_GraphThread As Thread
        dim Graphvalue as Integer
        dim Graphvalue2 as Integer
        Dim Graphvalue3 As Integer
        Dim cultureinfo As IFormatProvider
        Dim sw As io.streamwriter
        
        Public Sub New()
                ' The Me.InitializeComponent call is required for Windows Forms designer support.
                Me.InitializeComponent()
                'Dim e As EventArgs
                'Me.MainFormLoad(Me,e)
                'Process.GetCurrentProcess.PriorityClass = ProcessPriorityClass.High            
        End Sub
'---------------------------------------------------------------------------
'Timer1Tick
'Get the Data from the Serial Port
'---------------------------------------------------------------------------    
        private Sub Timer1Tick(ByVal sender As Object, ByVal e As EventArgs)
                Dim a As eDatenStatus
                Dim strDaten As String
                try
                while serialport1.BytesToRead > 0
                        strdaten = "2:11=Connection Lost!" 'preset this value
                        strdaten = serialport1.readline
                        if strdaten.Length > 4 then
                                a = getdaten(strdaten)
                        end if
                End While
                Catch fehler As Exception 'catch all Errors, so there is no crash if you plug out the stick
                        closeport
                End Try
        End Sub
'---------------------------------------------------------------------------
'getDaten
'split the datastring and set the values to the controls
'---------------------------------------------------------------------------
        private function getDaten(byval strdatenstring as string) as eDatenStatus
                Dim Befehl As Integer
                Dim Wert As Integer
                dim speed as single
                Dim Status As Boolean
                
                If strDatenstring.Contains(":") = False Then
                        getDaten = eDatenstatus.dtNoColon
                        Exit Function   'no : , wrong Syntax!
                end if
                If val(strDatenstring.substring(0, Instr(strDatenstring , ":")))<> MeinModul Then
                        getDaten = eDatenstatus.dtOtherModule
                        Exit Function   'other Module
                End If
                strDatenstring = strDatenstring.Substring(Instr(strDatenstring , ":"))
                If strDatenstring.Contains("=") = false Then
                        Befehl = val(strDatenstring)
                        'a Question received, answer here
                Else'a value received, write it to the GUI and file
                        Befehl = Val(strDatenstring.Substring(0, Instr(strDatenstring , "=")))
                        Wert = Val(strDatenstring.Substring(Instr(strDatenstring , "=")))
                        Select Case Befehl
                                Case eBefehl.dtGyro
                                '        status = setfader(me.trcGyro, wert, ,,  me.lblGyroVal, 670, 470)
                                        logValues(Befehl - 1) = Wert
                                Case ebefehl.dtAdxl
                                	'        status = setfader(me.trcTilt, wert, , , me.lblTiltVal, 560, 480)
                                		wert = wert - 1850
                                		Me.artificialHorizon1.roll_angle = wert
                                        logValues(Befehl - 1) = Wert
                                'Case eBefehl.dtAngelrate
                                '        status = setfader(me.trcAnglerate, wert,,,me.lblAnglerateValue)
                                '        Graphvalue = wert * 2
                                '        Graphvalue = Graphvalue + 50
                                '        logValues(Befehl - 1) = Wert
                                Case eBefehl.dtTiltangle
                                        'status = setfader(Me.trcTiltangle, wert,,,Me.lblTiltangleValue)
                                        graphvalue2 = wert * 2
                                        graphvalue2 = graphvalue2 + 50
                                        Me.artificialHorizon1.pitch_angle = Wert
                                        logValues(Befehl - 1) = Wert
                                Case eBefehl.dtBalancemoment
                                        'status = setfader(Me.trcBalancemoment, wert,,,Me.lblBalancemomentValue)
                                        graphvalue3 = wert /5
                                        graphvalue3 = graphvalue3 + 50
                                        logValues(Befehl - 1) = Wert
                                'Case eBefehl.dtTotaladxlgyro
                                '        status = setfader(Me.trcTotaladxlgyro, wert,,,Me.lblTotaladxlgyroValue)
                                '        logValues(Befehl - 1) = Wert
                                Case eBefehl.dtMotorL
                                        status = setfader(Me.trcMotorL, wert,,,Me.lblMotorLVal)
                                        logValues(Befehl - 1) = Wert
                                Case eBefehl.dtMotorR
                                        status = setfader(Me.trcMotorR, wert,,,Me.lblMotorRVal)
                                        logValues(Befehl - 1) = Wert
                                Case eBefehl.dtSpeedL
                                        speed = wert/10
                                        if speed < 0.2 and speed > -0.2 then speed = 0.0
                                        status = setfader(Me.trcSpeedL, speed,,,,20,-20)
                                        lblSpeedL.text = str(speed)
                                        logValues(Befehl - 1) = speed
                                Case eBefehl.dtSpeedR
                                        speed = wert/10
                                        if speed < 0.2 and speed > -0.2 then speed = 0.0
                                        status = setfader(Me.trcSpeedR, speed,,,,20,-20)
                                        lblSpeedR.text = str(speed)
                                        logValues(Befehl - 1) = speed
                                        fillTelemetryFile
                                Case eBefehl.dtIdendity
                                        Me.txtVersion.Text = strDatenstring.Substring(Instr(strDatenstring , "=")).Replace(chr(13)," ")
                                        logValues(Befehl - 1) = wert
                                Case eBefehl.param1
                                	Me.paramBox1.Text = Wert
                                	logValues(Befehl - 1) = wert
                                Case eBefehl.param2
                                	Me.paramBox2.Text = Wert
                                	logValues(Befehl - 1) = wert
                                Case eBefehl.param3
                                	Me.paramBox3.Text = Wert
                                	logValues(Befehl - 1) = wert
                                Case eBefehl.param4
                                	Me.paramBox4.Text = Wert
                                	logValues(Befehl - 1) = wert
                                Case eBefehl.param5
                                	Me.paramBox5.Text = Wert
                                	logValues(Befehl - 1) = wert
                                Case eBefehl.param6
                                	Me.paramBox6.Text = Wert
                                	logValues(Befehl - 1) = wert
                                Case Else
                        End Select
                End If
        End Function
        
        private Sub LinkLabel1LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
                System.Diagnostics.Process.Start("http://www.gerold-online.de/cms/wheelie/mein-wheelie.html")
        End Sub
        
        private Sub PictureBox1MouseClick(sender As Object, e As MouseEventArgs)
                System.Diagnostics.Process.Start("http://www.elektor.com/wheelie")
        End Sub
'---------------------------------------------------------------------------
'BtnConnectClick
'init the serial port and try to open it
'---------------------------------------------------------------------------            
        private Sub BtnConnectClick(sender As Object, e As EventArgs)
                if use_p = false then
                        try
                                serialport1.BaudRate = 115200
                                serialport1.Open
                                timer1.Enabled=True
                                btnConnect.Text="Online"
                                btnConnect.BackColor=color.LightGreen
                                use_p=True
                                serialport1.DiscardOutBuffer
                                serialport1.DiscardInBuffer
                                If TestUSBStickToolStripMenuItem.Checked = True Then
                                        serialport1.WriteLine(constStartTestmode & vbCr) 'switch Testmode on
                                Else
                                        serialport1.WriteLine(constStopTestmode & vbCr) 'switch Testmode off
                                End If
                        catch fehler As UnauthorizedAccessException
                                msgbox("This serial Port is used by another Program!")
                                closeport
                        Catch Fehler as ioException
                                msgbox("Could not open serial port. " & Fehler.message & " " & fehler.GetType.tostring)
                                closeport
                        End Try
                Else
                        closeport
                end if
        End Sub
'---------------------------------------------------------------------------
'MainFormLoad
'init the values
'---------------------------------------------------------------------------    
        private Sub MainForm_Load(sender As Object, e As EventArgs)
                m_Ymid = picGraph.ClientSize.Height \ 2
                m_Y = 50'm_Ymid
                m_Y2 =100
                m_Y3 = 150
                graphvalue = 50
                graphvalue2 = 100
                graphvalue3 = 150

                ' Make the Bitmap and Graphics objects.
                Dim wid As Integer = picGraph.ClientSize.Width
                Dim hgt As Integer = picGraph.ClientSize.Height
                Dim bm As New Bitmap(wid, hgt)
                Dim gr As Graphics = Graphics.FromImage(bm)
                ' Draw guide lines.
                gr.Clear(Color.Honeydew)
                For i As Integer = m_Ymid To picGraph.ClientSize.Height Step GRID_STEP
                        gr.DrawLine(Pens.LightBlue, 0, i, wid - 1, i)
                Next i
                For i As Integer = m_Ymid To 0 Step -GRID_STEP
                        gr.DrawLine(Pens.LightBlue, 0, i, wid - 1, i)
                Next i
                picGraph.Image = bm
                
                Dim loadINI As String
                loadINI = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Wheeliesettings.ini"
                If io.File.Exists(loadINI) = true Then
                        Dim readtext() As String = io.file.readalllines(loadINI)
                        Dim s As String
                For Each s In readText
                        if len(s)>4 then
                        Select Case s.Substring(0,4)
                                Case "COM:"
                                        strComItem = s.Substring(4,len(s)-4)
                                        serialport1.PortName = strComItem
                                        me.cboCom.Text = strComItem
                        End Select
                end if
                Next
                Else
                        Dim createText() As String = {"COM:COM1"}
            io.File.WriteAllLines(loadini, createText)
                End If
                filllist(Me.cboCom)
                'ToolTip1.SetToolTip(btnGraph, "Startet den Datenschreiber")
                'ToolTip1.SetToolTip(btnConnect, "Verbindung zum Stick ein- und ausschalten")
        End Sub
'---------------------------------------------------------------------------
'Graph
'draw the graphs
'this part of code is written by Ron Stephens
'http://www.vb-helper.com
'thanks for this code!
'---------------------------------------------------------------------------    
        private Sub BtnGraphClick(sender As Object, e As EventArgs)
                If m_GraphThread Is Nothing Then
                        ' The thread isn't running. Start it.
                        m_GraphThread = New Thread(AddressOf DrawGraph)
                        m_GraphThread.Priority = ThreadPriority.lowest
                        m_GraphThread.IsBackground = True
                        m_GraphThread.Start()
                        btnGraph.Text = "Stop"
                Else
                        ' The thread is running. Stop it
                        m_GraphThread.Abort()
                        ' m_GraphThread.Join()
                        m_GraphThread = Nothing
                        btnGraph.Text = "Start"
                End If
        End Sub
        Private Sub DrawGraph()
                Try
                        ' Generate pseudo-random values.
                        Dim y As Integer = m_Y
                        Dim y2 As Integer = m_Y2
                        Dim y3 As Integer = m_Y3
                        Do
                                ' Generate the next value.
                                NewValue()              
                                ' Plot the new value.
                                PlotValue(y, m_Y,y2,m_Y2,y3,m_Y3)
                                y3 = m_Y3
                                y2 = m_Y2
                                y = m_Y                 
                        Loop
                Catch ex As Exception
                        throw
                End Try
        End Sub 
        ' Generate the next value.
        Private Sub NewValue()
                ' Delay a bit before calculating the value.
                Dim stop_time As Date = Now.AddMilliseconds(10) 'speed
                Do While Now < stop_time
                loop
                '0 bis 150
                m_Y=graphvalue
                m_Y2=graphvalue2 + 50
                m_Y3=graphvalue3 + 100
        End Sub 
        ' Plot a new value.
        Private Delegate Sub PlotValueDelegate(ByVal old_y As Integer, ByVal new_y As Integer,ByVal old_y2 As Integer, ByVal new_y2 As Integer,ByVal old_y3 As Integer, ByVal new_y3 As Integer)
        Private Sub PlotValue(ByVal old_y As Integer, ByVal new_y As Integer,ByVal old_y2 As Integer, ByVal new_y2 As Integer,ByVal old_y3 As Integer, ByVal new_y3 As Integer)
                ' See if we're on the worker thread and thus
                ' need to invoke the main UI thread.
                If Me.InvokeRequired Then
                        ' Make arguments for the delegate.
                        Dim args As Object() = {old_y, new_y ,old_y2, new_y2,old_y3, new_y3}
                        
                        ' Make the delegate.
                        Dim plot_value_delegate As PlotValueDelegate
                        plot_value_delegate = AddressOf PlotValue
                        
                        ' Invoke the delegate on the main UI thread.
                        Me.Invoke(plot_value_delegate, args)
                        
                        ' We're done.
                        Exit Sub
                End If          
                ' Make the Bitmap and Graphics objects.
                Dim wid As Integer = picGraph.ClientSize.Width
                Dim hgt As Integer = picGraph.ClientSize.Height
                Dim bm As New Bitmap(wid, hgt)
                Dim gr As Graphics = Graphics.FromImage(bm)
                
                ' Move the old data one pixel to the left.
                gr.DrawImage(picGraph.Image, -1, 0)
                
                ' Erase the right edge and draw guide lines.
                gr.DrawLine(Pens.Honeydew, wid - 1, 0, wid - 1, hgt - 1)
                For i As Integer = m_Ymid To picGraph.ClientSize.Height Step GRID_STEP
                        gr.DrawLine(Pens.LightBlue, wid - 2, i, wid - 1, i)
                Next i
                For i As Integer = m_Ymid To 0 Step -GRID_STEP
                        gr.DrawLine(Pens.LightBlue, wid - 2, i, wid - 1, i)
                Next i
                
                ' Plot a new pixel.
                gr.DrawLine(Pens.Green, wid - 2, old_y, wid - 1, new_y)'nick
                gr.DrawLine(pens.Red,wid-2,old_y2,wid-1,new_y2)'roll
                gr.DrawLine(pens.blue,wid-2,old_y3,wid-1,new_y3)'gier
                
                ' Display the result.
                picGraph.Image = bm
                picGraph.Refresh()
                gr.Dispose()
                bm = Nothing
                gr = nothing
        End Sub
'---------------------------------------------------------------------------
'setFader
'set the Fader values manual or automatic
'---------------------------------------------------------------------------    
        Private Function setFader(ByRef objFader As trackbar, byval intWert as integer, optional ByRef objUpLabel As Label = nothing,optional ByRef objDownLabel As Label = nothing,optional ByRef objValueLabel As Label = nothing, optional byval intFaderMax as Integer = 0, optional byval intFaderMin as Integer = 0)as boolean
                'Den aktuellen Wert ins Label schreiben
                if not objValueLabel is nothing then objValueLabel.Text = intWert
                'Falls ein Maximalwert des Faders übergeben wurde, diesen setzen
                If Not intFaderMax = 0 Then
                        objFader.Maximum = intFaderMax
                        If Not objUpLabel Is Nothing Then objUpLabel.text=intFaderMax.ToString(cultureinfo)
                End If
                'Falls ein Minimalwert des Faders übergeben wurde, diesen setzen
                If Not intFaderMin = 0 Then
                        objFader.Minimum = intFaderMin
                        If Not objDownLabel Is Nothing Then objDownLabel.text=intFaderMin.ToString(cultureinfo)
                End If
                'Falls das Minimum noch auf dem Initialwert steht, den aktuellen Wert setzen
                If objFader.Minimum = -1 Then
                        objFader.Minimum = intWert
                        If Not objDownLabel Is Nothing Then objDownLabel.text= intWert.ToString(cultureinfo)
                End If
                'Falls das Maximum noch auf dem Initialwert steht, den aktuellen Wert setzen
                If objFader.Maximum = 1 Then
                        objFader.Maximum = intWert
                        If Not objUpLabel Is Nothing Then objUpLabel.text=intWert.ToString(cultureinfo)
                End If
                'Übersteigt der Wert die Obergrenze, die Grenze neu setzen
                If intWert>=objFader.Maximum Then
                        objFader.Maximum = intWert
                        If Not objUpLabel Is Nothing Then objUpLabel.text=intWert.ToString(cultureinfo)
                End If
                'Unterschreitet der Wert die Untergrenze, die Grenze neu setzen
                If intWert<= objFader.Minimum Then
                        objFader.Minimum = intWert
                        If Not objDownLabel Is Nothing Then objDownLabel.text= intWert.ToString(cultureinfo)
                End If
                'erst jetzt den Fader einstellen
                objFader.Value = intWert
                setfader = True
        End Function
'---------------------------------------------------------------------------
'FillList
'Fill the dropdown field with all available Ports
'---------------------------------------------------------------------------
        private Sub FillList(ByRef List As toolstripComboBox)
        Dim ports As String()
        Dim port As String
        ports = SerialPort.GetPortNames
        List.Items.Clear
        For Each port In ports
                Try
                        closePort
                                List.Items.Add(port)
                Catch Fehler As Exception
                        msgbox(fehler.Message)
                        throw
                end try
        Next port
    End Sub
'---------------------------------------------------------------------------
'closePort
'close the port, set the button and destroy the handle
'---------------------------------------------------------------------------
        Private Sub closePort()
                try
                        If serialport1.IsOpen Then
                                serialport1.WriteLine(constStopTestmode & vbCr)
                                serialport1.close
                        End If
                        timer1.Enabled=False
                        btnConnect.Enabled=True
                        btnConnect.BackColor=SystemColors.control
                        btnConnect.Text="Connect"
                        btnconnect.UseVisualStyleBackColor=True
                        Me.txtVersion.Text = "No Wheelie connected!"
                        use_p=False
                        If sw IsNot Nothing Then
                                sw.Close
                                sw = nothing
                        End If
                Catch Fehler As Exception
                        msgbox("Could not close serial port. " & Fehler.message)
                        throw
                End Try
        End Sub
        
        private Sub CboComSelectedIndexChanged(sender As Object, e As EventArgs)
                closePort
                serialport1.PortName = Me.cboCOM.text
                strComItem = Me.cboCOM.text
                me.settingsToolStripMenuItem.DropDown.close
        End Sub
        
        private Sub BtnSendClick(sender As Object, e As EventArgs)
        	
        	Dim serialString As String
        	serialString = ":0:17="+Me.paramBox1.Text+":18="+Me.paramBox2.Text+":19="+Me.paramBox3.Text+":20="+Me.paramBox4.Text+":21="+Me.paramBox5.Text+":22="+Me.paramBox6.Text
       	
       		serialPort1.Write(serialString)
       		Me.sentLabel.Text = "Params Sent!"
        End Sub
        
        
        private Sub BtnSaveClick(sender As Object, e As EventArgs)
        	
        	Dim serialString As String
        	serialString = ":0:17"
       		serialPort1.Write(serialString)
       		Me.sentLabel.Text = "Params SAVED!"
        End Sub
'---------------------------------------------------------------------------
'MainFormFormClosing
'write the settings into the WheelieSettings.ini file
'---------------------------------------------------------------------------            
        private Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
                Dim loadINI As String
                loadINI = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Wheeliesettings.ini"
                Dim createText() As String = {" "}
                createText(0) = "COM:" & strComItem
        io.File.WriteAllLines(loadini, createText)
        closeport
        End Sub
'---------------------------------------------------------------------------
'FillTelemetryFile
'write a line into the open file
'---------------------------------------------------------------------------    
        private Sub FillTelemetryFile()
        
        Dim strLine As String
        Dim logValue As single
        dim datePatt As String = "dd.MM.yyyy HH:mm:ss:ff"

        If logON = True Then 'create the line
                strLine = chr(34) & now.tostring(datepatt)  & chr(34) & ";" 'write the date
                For Each logValue In logValues 'write all values
                        StrLine = strLine & logValue & ";"
                Next
                sw.WriteLine(strLine)
                sw.flush 'store the line
        End If
        End Sub
'---------------------------------------------------------------------------
'CreateTelemetryFile
'create the file and open it
'---------------------------------------------------------------------------    
        private Sub CreateTelemetryFile()
                        Dim saveas As String
                        savefiledialog1.InitialDirectory=System.Environment.CurrentDirectory
                        savefiledialog1.Filter = "Tabelle (*.csv)|*.csv"
                        savefiledialog1.ShowDialog
                        saveas=savefiledialog1.FileName
                        if saveas <> "" then
                                sw = new io.streamwriter(saveas)
                                sw.WriteLine(strHeader)
                        sw.Flush
                        end if
        End Sub
        
        private Sub TsLogfileClick(sender As Object, e As EventArgs)
                If Me.tsLogfile.Checked = True Then
                        CreateTelemetryFile
                        logOn = True
                Else
                        logOn = false
                End If
        End Sub
        
        private Sub PictureBox1MouseEnter(sender As Object, e As EventArgs)
                me.Cursor = System.Windows.Forms.Cursors.Hand
        End Sub
        
      '  private Sub AboutToolStripMenuItemClick(sender As Object, e As EventArgs)
       '         Dim frm As New about
       '         frm.ShowDialog
       ' End Sub
        
        private Sub PictureBox1MouseLeave(sender As Object, e As EventArgs)
                me.Cursor = System.Windows.Forms.Cursors.Arrow
        End Sub
        
        private Sub Label5Click(sender As Object, e As EventArgs)
                System.Diagnostics.Process.Start("http://www.elektor.com/wheelie")
        End Sub
        
        private Sub Label5MouseLeave(sender As Object, e As EventArgs)
                me.Cursor = System.Windows.Forms.Cursors.Arrow
        End Sub
        
        private Sub Label5MouseEnter(sender As Object, e As EventArgs)
                me.Cursor = System.Windows.Forms.Cursors.Hand
        End Sub
        
        private Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs)
                System.Diagnostics.Process.Start("http://www.elektor.de/forum/foren-ubersicht/foren-zu-elektor-projekten/elektorwheelie.996934.lynkx")
        End Sub
        
        private Sub USBTreiberToolStripMenuItemClick(sender As Object, e As EventArgs)
                try
                        System.Diagnostics.Process.Start(Application.StartupPath & "/DPInst.EXE")
                Catch Fehler As Exception
                        msgbox("Fehler bei der Treiberinstallation! " & Fehler.Message & " " & fehler.gettype.tostring)
                        throw
                end try
        End Sub
        
        private Sub TestUSBStickToolStripMenuItemClick(sender As Object, e As EventArgs)
                closeport
        End Sub
        
        private Sub StickFirmwareToolStripMenuItemClick(sender As Object, e As EventArgs)
                System.Diagnostics.Process.Start("http://www.gerold-online.de/cms/fileadmin/downloads/Wheelie/RFM12empfaenger.zip")
        End Sub
        
        private Sub TestsenderFirmwareSenderToolStripMenuItemClick(sender As Object, e As EventArgs)
                System.Diagnostics.Process.Start("http://www.gerold-online.de/cms/fileadmin/downloads/Wheelie/RFM12TestSender.zip")
        End Sub
        
        private Sub FirmwareSenderToolStripMenuItemClick(sender As Object, e As EventArgs)
                System.Diagnostics.Process.Start("http://www.gerold-online.de/cms/fileadmin/downloads/Wheelie/RFM12Sender.zip")
        End Sub
        
        private Sub UpdateToolStripMenuItemClick(sender As Object, e As EventArgs)
                System.Diagnostics.Process.Start("http://www.gerold-online.de/cms/fileadmin/downloads/Wheelie/setup.exe")
                application.exit
        End Sub
        
        private Sub CboComDropDown(sender As Object, e As EventArgs)
                filllist(Me.cboCom)
        End Sub
	
	Sub GroupBox1Enter(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Label3Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Label7Click(sender As Object, e As EventArgs)
		
	End Sub
End Class