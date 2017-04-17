<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArduinoLoader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbCOMM = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbArduino = New System.Windows.Forms.ComboBox()
        Me.btnFile_Sel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbCOMM
        '
        Me.cmbCOMM.FormattingEnabled = True
        Me.cmbCOMM.Location = New System.Drawing.Point(95, 12)
        Me.cmbCOMM.Name = "cmbCOMM"
        Me.cmbCOMM.Size = New System.Drawing.Size(99, 24)
        Me.cmbCOMM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comm Port"
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(12, 140)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(402, 42)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HEX File"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(95, 87)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(277, 22)
        Me.txtFile.TabIndex = 4
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(95, 112)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(277, 22)
        Me.txtDir.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Directory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Arduino"
        '
        'cmbArduino
        '
        Me.cmbArduino.FormattingEnabled = True
        Me.cmbArduino.Location = New System.Drawing.Point(95, 42)
        Me.cmbArduino.Name = "cmbArduino"
        Me.cmbArduino.Size = New System.Drawing.Size(319, 24)
        Me.cmbArduino.TabIndex = 8
        '
        'btnFile_Sel
        '
        Me.btnFile_Sel.BackColor = System.Drawing.Color.White
        Me.btnFile_Sel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnFile_Sel.Location = New System.Drawing.Point(378, 87)
        Me.btnFile_Sel.Name = "btnFile_Sel"
        Me.btnFile_Sel.Size = New System.Drawing.Size(36, 45)
        Me.btnFile_Sel.TabIndex = 9
        Me.btnFile_Sel.Text = "..."
        Me.btnFile_Sel.UseVisualStyleBackColor = False
        '
        'frmArduinoLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 195)
        Me.Controls.Add(Me.btnFile_Sel)
        Me.Controls.Add(Me.cmbArduino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCOMM)
        Me.Name = "frmArduinoLoader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArduinoLoader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCOMM As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbArduino As System.Windows.Forms.ComboBox
    Friend WithEvents btnFile_Sel As System.Windows.Forms.Button

End Class
