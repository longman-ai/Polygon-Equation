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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxSides = New System.Windows.Forms.TextBox()
        Me.TextBoxLength = New System.Windows.Forms.TextBox()
        Me.TextBoxAns = New System.Windows.Forms.TextBox()
        Me.btnPer = New System.Windows.Forms.Button()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area and Perimeter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Length"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. of Sides"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Answer"
        '
        'txtBoxSides
        '
        Me.txtBoxSides.Location = New System.Drawing.Point(108, 92)
        Me.txtBoxSides.Name = "txtBoxSides"
        Me.txtBoxSides.Size = New System.Drawing.Size(45, 20)
        Me.txtBoxSides.TabIndex = 4
        '
        'TextBoxLength
        '
        Me.TextBoxLength.Location = New System.Drawing.Point(108, 58)
        Me.TextBoxLength.Name = "TextBoxLength"
        Me.TextBoxLength.Size = New System.Drawing.Size(45, 20)
        Me.TextBoxLength.TabIndex = 5
        '
        'TextBoxAns
        '
        Me.TextBoxAns.Location = New System.Drawing.Point(108, 126)
        Me.TextBoxAns.Name = "TextBoxAns"
        Me.TextBoxAns.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAns.TabIndex = 6
        '
        'btnPer
        '
        Me.btnPer.Location = New System.Drawing.Point(47, 267)
        Me.btnPer.Name = "btnPer"
        Me.btnPer.Size = New System.Drawing.Size(75, 23)
        Me.btnPer.TabIndex = 7
        Me.btnPer.Text = "Perimeter"
        Me.btnPer.UseVisualStyleBackColor = True
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(186, 267)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(75, 23)
        Me.btnArea.TabIndex = 8
        Me.btnArea.Text = "Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 359)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.btnPer)
        Me.Controls.Add(Me.TextBoxAns)
        Me.Controls.Add(Me.TextBoxLength)
        Me.Controls.Add(Me.txtBoxSides)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxSides As TextBox
    Friend WithEvents TextBoxLength As TextBox
    Friend WithEvents TextBoxAns As TextBox
    Friend WithEvents btnPer As Button
    Friend WithEvents btnArea As Button
End Class
