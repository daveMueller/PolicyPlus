﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPolNumericData
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.CheckHexadecimal = New System.Windows.Forms.CheckBox()
        Me.NumData = New PolicyPlus.Gui.WideRangeNumericUpDown()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.NumData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 13)
        Label1.TabIndex = 1
        Label1.Text = "Value name"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 41)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(44, 13)
        Label2.TabIndex = 3
        Label2.Text = "Number"
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(81, 12)
        Me.TextName.Name = "TextName"
        Me.TextName.ReadOnly = True
        Me.TextName.Size = New System.Drawing.Size(230, 20)
        Me.TextName.TabIndex = 0
        '
        'CheckHexadecimal
        '
        Me.CheckHexadecimal.AutoSize = True
        Me.CheckHexadecimal.Location = New System.Drawing.Point(224, 40)
        Me.CheckHexadecimal.Name = "CheckHexadecimal"
        Me.CheckHexadecimal.Size = New System.Drawing.Size(87, 17)
        Me.CheckHexadecimal.TabIndex = 2
        Me.CheckHexadecimal.Text = "Hexadecimal"
        Me.CheckHexadecimal.UseVisualStyleBackColor = True
        '
        'NumData
        '
        Me.NumData.Location = New System.Drawing.Point(81, 37)
        Me.NumData.Name = "NumData"
        Me.NumData.Size = New System.Drawing.Size(137, 20)
        Me.NumData.TabIndex = 1
        '
        'ButtonOK
        '
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.Location = New System.Drawing.Point(236, 63)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 3
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'EditPolNumericData
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 98)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.NumData)
        Me.Controls.Add(Me.CheckHexadecimal)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditPolNumericData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Number"
        CType(Me.NumData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextName As TextBox
    Friend WithEvents CheckHexadecimal As CheckBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents NumData As WideRangeNumericUpDown
End Class
