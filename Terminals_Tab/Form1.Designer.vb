﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataInputLabel = New System.Windows.Forms.Label()
        Me.DataInputClearButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.InTermListBox = New System.Windows.Forms.ListBox()
        Me.OutTermListBox = New System.Windows.Forms.ListBox()
        Me.OutClearButton = New System.Windows.Forms.Button()
        Me.InClearButton = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SerialPort1
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 439)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PortDataListBox)
        Me.TabPage1.Controls.Add(Me.PortOpenButton)
        Me.TabPage1.Controls.Add(Me.ComPortListBox)
        Me.TabPage1.Controls.Add(Me.BaudRateListBox)
        Me.TabPage1.Controls.Add(Me.ComPortButton)
        Me.TabPage1.Controls.Add(Me.BaudRateButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 406)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Serial Connection"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(364, 17)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 61
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(399, 253)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(154, 104)
        Me.PortOpenButton.TabIndex = 60
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(248, 37)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 59
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(77, 22)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 204)
        Me.BaudRateListBox.TabIndex = 58
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(239, 248)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(154, 104)
        Me.ComPortButton.TabIndex = 57
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(93, 253)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(127, 95)
        Me.BaudRateButton.TabIndex = 56
        Me.BaudRateButton.Text = "Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataInputLabel)
        Me.TabPage2.Controls.Add(Me.DataInputClearButton)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.SendButton)
        Me.TabPage2.Controls.Add(Me.InTermListBox)
        Me.TabPage2.Controls.Add(Me.OutTermListBox)
        Me.TabPage2.Controls.Add(Me.OutClearButton)
        Me.TabPage2.Controls.Add(Me.InClearButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Loop Back Test"
        '
        'DataInputLabel
        '
        Me.DataInputLabel.AutoSize = True
        Me.DataInputLabel.Location = New System.Drawing.Point(39, 88)
        Me.DataInputLabel.Name = "DataInputLabel"
        Me.DataInputLabel.Size = New System.Drawing.Size(85, 20)
        Me.DataInputLabel.TabIndex = 70
        Me.DataInputLabel.Text = "Data Input"
        '
        'DataInputClearButton
        '
        Me.DataInputClearButton.Location = New System.Drawing.Point(151, 79)
        Me.DataInputClearButton.Name = "DataInputClearButton"
        Me.DataInputClearButton.Size = New System.Drawing.Size(110, 58)
        Me.DataInputClearButton.TabIndex = 69
        Me.DataInputClearButton.Text = "Clear data input "
        Me.DataInputClearButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 68
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(53, 263)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(154, 104)
        Me.SendButton.TabIndex = 67
        Me.SendButton.Text = "Send Packet"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'InTermListBox
        '
        Me.InTermListBox.FormattingEnabled = True
        Me.InTermListBox.ItemHeight = 20
        Me.InTermListBox.Location = New System.Drawing.Point(532, 19)
        Me.InTermListBox.Name = "InTermListBox"
        Me.InTermListBox.Size = New System.Drawing.Size(207, 184)
        Me.InTermListBox.TabIndex = 66
        '
        'OutTermListBox
        '
        Me.OutTermListBox.FormattingEnabled = True
        Me.OutTermListBox.ItemHeight = 20
        Me.OutTermListBox.Location = New System.Drawing.Point(286, 19)
        Me.OutTermListBox.Name = "OutTermListBox"
        Me.OutTermListBox.Size = New System.Drawing.Size(226, 244)
        Me.OutTermListBox.TabIndex = 65
        '
        'OutClearButton
        '
        Me.OutClearButton.Location = New System.Drawing.Point(341, 283)
        Me.OutClearButton.Name = "OutClearButton"
        Me.OutClearButton.Size = New System.Drawing.Size(154, 104)
        Me.OutClearButton.TabIndex = 64
        Me.OutClearButton.Text = "Clear data out display"
        Me.OutClearButton.UseVisualStyleBackColor = True
        '
        'InClearButton
        '
        Me.InClearButton.Location = New System.Drawing.Point(553, 283)
        Me.InClearButton.Name = "InClearButton"
        Me.InClearButton.Size = New System.Drawing.Size(154, 104)
        Me.InClearButton.TabIndex = 63
        Me.InClearButton.Text = "clear data in display"
        Me.InClearButton.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(768, 406)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(768, 406)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(818, 478)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(82, 76)
        Me.QuitButton.TabIndex = 52
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 566)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents QuitButton As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents DataInputLabel As Label
    Friend WithEvents DataInputClearButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents InTermListBox As ListBox
    Friend WithEvents OutTermListBox As ListBox
    Friend WithEvents OutClearButton As Button
    Friend WithEvents InClearButton As Button
End Class
