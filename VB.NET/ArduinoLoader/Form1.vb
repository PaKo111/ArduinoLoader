Imports System.IO

Public Class frmArduinoLoader

    Private Sub frmArduinoLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbArduino.Items.Add("Arduino UNO")
        cmbArduino.Items.Add("Arduino MEGA2560")

        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOMM.Items.Add(sp)
        Next

        If My.Settings.COMM <> "" Then cmbCOMM.Text = My.Settings.COMM
        If My.Settings.Arduino <> "" Then cmbArduino.Text = My.Settings.Arduino
        If My.Settings.File <> "" Then txtFile.Text = My.Settings.File
        If My.Settings.Dir <> "" Then txtDir.Text = My.Settings.Dir

    End Sub

    Private Sub cmbCOMM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCOMM.SelectedIndexChanged
        My.Settings.COMM = cmbCOMM.Text
        My.Settings.Save()
    End Sub

    Private Sub cmbArduino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArduino.SelectedIndexChanged
        My.Settings.Arduino = cmbArduino.Text
        My.Settings.Save()
    End Sub

    Private Sub btnFile_Sel_Click(sender As Object, e As EventArgs) Handles btnFile_Sel.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim LDir As String = "", LFile As String = ""

        If My.Settings.Dir <> "" Then
            openFileDialog1.InitialDirectory = My.Settings.Dir
        Else
            openFileDialog1.InitialDirectory = Application.StartupPath
        End If
        openFileDialog1.Filter = "HEX files (*.hex)|*.hex|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            LDir = Path.GetDirectoryName(openFileDialog1.FileName) & "\"
            LFile = Mid(openFileDialog1.FileName, Len(LDir) + 1)
            If My.Settings.File <> LFile Then
                My.Settings.File = LFile
                txtFile.Text = LFile
                My.Settings.Save()
            End If
            If My.Settings.Dir <> LDir Then
                My.Settings.Dir = LDir
                txtDir.Text = LDir
                My.Settings.Save()
            End If
        End If

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim LStr As String = "DIR"
        Select Case cmbArduino.Text
            Case "Arduino UNO"
                LStr = """" & Application.StartupPath & "\AVRDUDE"" -C""" & Application.StartupPath & "\avrdude.conf"" -v "
                LStr = LStr & "-patmega328p -carduino -P" & cmbCOMM.Text & " -b115200 -D -Uflash:w:"""
                LStr = LStr & txtDir.Text & txtFile.Text & """:i"
                'LStr = "C:\Program Files (x86)\Arduino\hardware\tools\avr/bin/avrdude -CC:\Program Files (x86)\Arduino\hardware\tools\avr/etc/avrdude.conf 
                ' -v -patmega328p -carduino -PCOM4 -b115200 -D -Uflash:w:C:\Users\ja\AppData\Local\Temp\arduino_build_512887/HIH6130_Sketch.ino.hex:i"

            Case "Arduino MEGA2560"
                LStr = """" & Application.StartupPath & "\AVRDUDE"" -C""" & Application.StartupPath & "\avrdude.conf"" -v "
                LStr = LStr & "-patmega2560 -cwiring -P" & cmbCOMM.Text & " -b115200 -D -Uflash:w:"""
                LStr = LStr & txtDir.Text & txtFile.Text & """:i"
                'LStr = "C:\Program Files (x86)\Arduino\hardware\tools\avr/bin/avrdude -CC:\Program Files (x86)\Arduino\hardware\tools\avr/etc/avrdude.conf 
                ' -v -patmega2560 -cwiring -PCOM4 -b115200 -D -Uflash:w:C:\Users\ja\AppData\Local\Temp\arduino_build_512887/HIH6130_Sketch.ino.hex:i"

        End Select

        Shell(LStr, AppWinStyle.NormalFocus, True)
    End Sub
End Class
