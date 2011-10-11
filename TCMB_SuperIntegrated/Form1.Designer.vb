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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 271)
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

End Class
