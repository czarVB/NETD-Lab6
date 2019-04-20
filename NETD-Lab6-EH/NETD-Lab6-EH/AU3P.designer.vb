<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShippingAverage
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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtPackages = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtEmployee1 = New System.Windows.Forms.TextBox()
        Me.txtEmployee2 = New System.Windows.Forms.TextBox()
        Me.txtEmployee3 = New System.Windows.Forms.TextBox()
        Me.txtAverage1 = New System.Windows.Forms.TextBox()
        Me.txtAverage2 = New System.Windows.Forms.TextBox()
        Me.txtAverage3 = New System.Windows.Forms.TextBox()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tltToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(20, 20)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(100, 25)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units for:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployee
        '
        Me.txtEmployee.Enabled = False
        Me.txtEmployee.Location = New System.Drawing.Point(126, 23)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(85, 22)
        Me.txtEmployee.TabIndex = 1
        Me.txtEmployee.Text = "Employee 1"
        '
        'txtDay
        '
        Me.txtDay.Enabled = False
        Me.txtDay.Location = New System.Drawing.Point(217, 23)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(45, 22)
        Me.txtDay.TabIndex = 2
        Me.txtDay.Text = "Day 1"
        '
        'txtPackages
        '
        Me.txtPackages.Location = New System.Drawing.Point(277, 23)
        Me.txtPackages.Name = "txtPackages"
        Me.txtPackages.Size = New System.Drawing.Size(100, 22)
        Me.txtPackages.TabIndex = 3
        Me.tltToolTip.SetToolTip(Me.txtPackages, "Enter a value here.")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(20, 70)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(120, 30)
        Me.lblEmployee1.TabIndex = 4
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(145, 70)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(120, 30)
        Me.lblEmployee2.TabIndex = 5
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(270, 70)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(120, 30)
        Me.lblEmployee3.TabIndex = 6
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployee1
        '
        Me.txtEmployee1.Enabled = False
        Me.txtEmployee1.Location = New System.Drawing.Point(20, 110)
        Me.txtEmployee1.Multiline = True
        Me.txtEmployee1.Name = "txtEmployee1"
        Me.txtEmployee1.Size = New System.Drawing.Size(120, 118)
        Me.txtEmployee1.TabIndex = 7
        Me.tltToolTip.SetToolTip(Me.txtEmployee1, "Packages shipped by employee 1.")
        '
        'txtEmployee2
        '
        Me.txtEmployee2.Enabled = False
        Me.txtEmployee2.Location = New System.Drawing.Point(145, 110)
        Me.txtEmployee2.Multiline = True
        Me.txtEmployee2.Name = "txtEmployee2"
        Me.txtEmployee2.Size = New System.Drawing.Size(120, 118)
        Me.txtEmployee2.TabIndex = 8
        Me.tltToolTip.SetToolTip(Me.txtEmployee2, "Packages shipped by employee 2.")
        '
        'txtEmployee3
        '
        Me.txtEmployee3.Enabled = False
        Me.txtEmployee3.Location = New System.Drawing.Point(270, 110)
        Me.txtEmployee3.Multiline = True
        Me.txtEmployee3.Name = "txtEmployee3"
        Me.txtEmployee3.Size = New System.Drawing.Size(120, 118)
        Me.txtEmployee3.TabIndex = 9
        Me.tltToolTip.SetToolTip(Me.txtEmployee3, "Packages shipped by employee 3.")
        '
        'txtAverage1
        '
        Me.txtAverage1.Enabled = False
        Me.txtAverage1.Location = New System.Drawing.Point(20, 234)
        Me.txtAverage1.Name = "txtAverage1"
        Me.txtAverage1.Size = New System.Drawing.Size(120, 22)
        Me.txtAverage1.TabIndex = 10
        Me.txtAverage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tltToolTip.SetToolTip(Me.txtAverage1, "The average of the 1st employee")
        '
        'txtAverage2
        '
        Me.txtAverage2.Enabled = False
        Me.txtAverage2.Location = New System.Drawing.Point(145, 234)
        Me.txtAverage2.Name = "txtAverage2"
        Me.txtAverage2.Size = New System.Drawing.Size(120, 22)
        Me.txtAverage2.TabIndex = 11
        Me.txtAverage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tltToolTip.SetToolTip(Me.txtAverage2, "The average of the 2nd employee")
        '
        'txtAverage3
        '
        Me.txtAverage3.Enabled = False
        Me.txtAverage3.Location = New System.Drawing.Point(270, 234)
        Me.txtAverage3.Name = "txtAverage3"
        Me.txtAverage3.Size = New System.Drawing.Size(120, 22)
        Me.txtAverage3.TabIndex = 12
        Me.txtAverage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tltToolTip.SetToolTip(Me.txtAverage3, "The average of the 3rd employee")
        '
        'txtFeedback
        '
        Me.txtFeedback.Enabled = False
        Me.txtFeedback.Location = New System.Drawing.Point(20, 262)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(370, 22)
        Me.txtFeedback.TabIndex = 13
        Me.txtFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tltToolTip.SetToolTip(Me.txtFeedback, "Feedback or overall employee average")
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(20, 291)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(120, 30)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "&Enter"
        Me.tltToolTip.SetToolTip(Me.btnEnter, "Puts the input on the table.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(145, 291)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 30)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "&Reset"
        Me.tltToolTip.SetToolTip(Me.btnReset, "Erases all current data.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(270, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.tltToolTip.SetToolTip(Me.btnExit, "Closes the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShippingAverage
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(412, 343)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.txtAverage3)
        Me.Controls.Add(Me.txtAverage2)
        Me.Controls.Add(Me.txtAverage1)
        Me.Controls.Add(Me.txtEmployee3)
        Me.Controls.Add(Me.txtEmployee2)
        Me.Controls.Add(Me.txtEmployee1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtPackages)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShippingAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Units shipped per Three Employees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUnits As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtPackages As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtEmployee1 As TextBox
    Friend WithEvents txtEmployee2 As TextBox
    Friend WithEvents txtEmployee3 As TextBox
    Friend WithEvents txtAverage1 As TextBox
    Friend WithEvents txtAverage2 As TextBox
    Friend WithEvents txtAverage3 As TextBox
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tltToolTip As ToolTip
End Class
