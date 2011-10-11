<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmdTheButton = New System.Windows.Forms.Button
        Me.TheTextBox = New System.Windows.Forms.TextBox
        Me.lblTheTextBox = New System.Windows.Forms.Label
        Me.BtnBusiness = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdTheButton
        '
        Me.cmdTheButton.Location = New System.Drawing.Point(105, 39)
        Me.cmdTheButton.Name = "cmdTheButton"
        Me.cmdTheButton.Size = New System.Drawing.Size(75, 23)
        Me.cmdTheButton.TabIndex = 0
        Me.cmdTheButton.Text = "The Button"
        Me.cmdTheButton.UseVisualStyleBackColor = True
        '
        'TheTextBox
        '
        Me.TheTextBox.Location = New System.Drawing.Point(105, 96)
        Me.TheTextBox.Name = "TheTextBox"
        Me.TheTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TheTextBox.TabIndex = 1
        '
        'lblTheTextBox
        '
        Me.lblTheTextBox.AutoSize = True
        Me.lblTheTextBox.Location = New System.Drawing.Point(102, 76)
        Me.lblTheTextBox.Name = "lblTheTextBox"
        Me.lblTheTextBox.Size = New System.Drawing.Size(101, 13)
        Me.lblTheTextBox.TabIndex = 2
        Me.lblTheTextBox.Text = "Put your texts here !"
        '
        'BtnBusiness
        '
        Me.BtnBusiness.Location = New System.Drawing.Point(105, 133)
        Me.BtnBusiness.Name = "BtnBusiness"
        Me.BtnBusiness.Size = New System.Drawing.Size(133, 23)
        Me.BtnBusiness.TabIndex = 3
        Me.BtnBusiness.Text = "Busines button"
        Me.BtnBusiness.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(187, 39)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "TheCheckBox"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(105, 176)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(266, 93)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(105, 227)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(266, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 363)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnBusiness)
        Me.Controls.Add(Me.lblTheTextBox)
        Me.Controls.Add(Me.TheTextBox)
        Me.Controls.Add(Me.cmdTheButton)
        Me.Name = "Form1"
        Me.Text = "TCMB_SuperIntegrated"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdTheButton As System.Windows.Forms.Button
    Friend WithEvents TheTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblTheTextBox As System.Windows.Forms.Label
    Friend WithEvents BtnBusiness As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
