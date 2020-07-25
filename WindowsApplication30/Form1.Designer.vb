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
        Me.data = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.host = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.waitResponse = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SendLoop = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(22, 108)
        Me.data.Multiline = True
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(533, 260)
        Me.data.TabIndex = 1
        Me.data.Text = "EE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#Eg‰#EŒÝ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(480, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'host
        '
        Me.host.Location = New System.Drawing.Point(22, 42)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(447, 20)
        Me.host.TabIndex = 3
        Me.host.Text = "leonidas.agoge.com.br"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Host"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(475, 42)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(80, 20)
        Me.port.TabIndex = 5
        Me.port.Text = "1020"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data"
        '
        'waitResponse
        '
        Me.waitResponse.AutoSize = True
        Me.waitResponse.Location = New System.Drawing.Point(25, 384)
        Me.waitResponse.Name = "waitResponse"
        Me.waitResponse.Size = New System.Drawing.Size(125, 17)
        Me.waitResponse.TabIndex = 8
        Me.waitResponse.Text = "Wait Response Data"
        Me.waitResponse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SendLoop
        '
        Me.SendLoop.AutoSize = True
        Me.SendLoop.Checked = True
        Me.SendLoop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SendLoop.Location = New System.Drawing.Point(350, 384)
        Me.SendLoop.Name = "SendLoop"
        Me.SendLoop.Size = New System.Drawing.Size(106, 17)
        Me.SendLoop.TabIndex = 10
        Me.SendLoop.Text = "Sending Looping"
        Me.SendLoop.UseVisualStyleBackColor = True
        Me.SendLoop.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(118, 423)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 473)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SendLoop)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.waitResponse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.host)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.data)
        Me.Name = "Form1"
        Me.Text = "TCP Client Program - Limit 1,000"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents host As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents port As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents waitResponse As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SendLoop As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
