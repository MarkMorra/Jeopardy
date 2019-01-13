<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndScreen))
        Me.WinnerBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'WinnerBox
        '
        Me.WinnerBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.WinnerBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WinnerBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.WinnerBox.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.WinnerBox.ForeColor = System.Drawing.SystemColors.Control
        Me.WinnerBox.Location = New System.Drawing.Point(1, 337)
        Me.WinnerBox.Name = "WinnerBox"
        Me.WinnerBox.ReadOnly = True
        Me.WinnerBox.Size = New System.Drawing.Size(463, 267)
        Me.WinnerBox.TabIndex = 0
        Me.WinnerBox.Text = "Error, failed to load new text"
        '
        'EndScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 603)
        Me.Controls.Add(Me.WinnerBox)
        Me.Name = "EndScreen"
        Me.Text = "Jeopardy!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WinnerBox As System.Windows.Forms.RichTextBox
End Class
