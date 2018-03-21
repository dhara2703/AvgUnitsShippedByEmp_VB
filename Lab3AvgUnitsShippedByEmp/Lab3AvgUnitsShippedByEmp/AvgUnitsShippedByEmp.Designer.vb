<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvgUnitsShippedByEmp
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
        Me.lblOverallResult = New System.Windows.Forms.Label()
        Me.lblAvgEmp2 = New System.Windows.Forms.Label()
        Me.lblAvgEmp1 = New System.Windows.Forms.Label()
        Me.ToolTipAvgUnitsShippedByEmp = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAvgEmp3 = New System.Windows.Forms.Label()
        Me.txtEmp3WeeklyUnits = New System.Windows.Forms.TextBox()
        Me.txtEmp2WeeklyUnits = New System.Windows.Forms.TextBox()
        Me.txtEmp1WeeklyUnits = New System.Windows.Forms.TextBox()
        Me.txtUnitsPerDay = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblDaysCounter = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOverallResult
        '
        Me.lblOverallResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallResult.Location = New System.Drawing.Point(43, 635)
        Me.lblOverallResult.Name = "lblOverallResult"
        Me.lblOverallResult.Size = New System.Drawing.Size(1087, 48)
        Me.lblOverallResult.TabIndex = 12
        Me.lblOverallResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.lblOverallResult, "Shows Overall Average Units")
        '
        'lblAvgEmp2
        '
        Me.lblAvgEmp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgEmp2.Location = New System.Drawing.Point(413, 558)
        Me.lblAvgEmp2.Name = "lblAvgEmp2"
        Me.lblAvgEmp2.Size = New System.Drawing.Size(350, 46)
        Me.lblAvgEmp2.TabIndex = 8
        Me.lblAvgEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.lblAvgEmp2, "Shows Employee 2 Average Units")
        '
        'lblAvgEmp1
        '
        Me.lblAvgEmp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgEmp1.Location = New System.Drawing.Point(40, 558)
        Me.lblAvgEmp1.Name = "lblAvgEmp1"
        Me.lblAvgEmp1.Size = New System.Drawing.Size(350, 46)
        Me.lblAvgEmp1.TabIndex = 5
        Me.lblAvgEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.lblAvgEmp1, "Shows Employee 1 Average Units")
        '
        'ToolTipAvgUnitsShippedByEmp
        '
        Me.ToolTipAvgUnitsShippedByEmp.ToolTipTitle = "Tips For Average Units Shipped By Employee"
        '
        'lblAvgEmp3
        '
        Me.lblAvgEmp3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgEmp3.Location = New System.Drawing.Point(786, 558)
        Me.lblAvgEmp3.Name = "lblAvgEmp3"
        Me.lblAvgEmp3.Size = New System.Drawing.Size(350, 46)
        Me.lblAvgEmp3.TabIndex = 11
        Me.lblAvgEmp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.lblAvgEmp3, "Shows Employee 3 Average Units")
        '
        'txtEmp3WeeklyUnits
        '
        Me.txtEmp3WeeklyUnits.Location = New System.Drawing.Point(774, 244)
        Me.txtEmp3WeeklyUnits.Multiline = True
        Me.txtEmp3WeeklyUnits.Name = "txtEmp3WeeklyUnits"
        Me.txtEmp3WeeklyUnits.Size = New System.Drawing.Size(350, 288)
        Me.txtEmp3WeeklyUnits.TabIndex = 10
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.txtEmp3WeeklyUnits, "Displays Entered Units Per Day For Employee 3")
        '
        'txtEmp2WeeklyUnits
        '
        Me.txtEmp2WeeklyUnits.Location = New System.Drawing.Point(407, 244)
        Me.txtEmp2WeeklyUnits.Multiline = True
        Me.txtEmp2WeeklyUnits.Name = "txtEmp2WeeklyUnits"
        Me.txtEmp2WeeklyUnits.Size = New System.Drawing.Size(350, 288)
        Me.txtEmp2WeeklyUnits.TabIndex = 7
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.txtEmp2WeeklyUnits, "Displays Entered Units Per Day For Employee 2")
        '
        'txtEmp1WeeklyUnits
        '
        Me.txtEmp1WeeklyUnits.Location = New System.Drawing.Point(40, 244)
        Me.txtEmp1WeeklyUnits.Multiline = True
        Me.txtEmp1WeeklyUnits.Name = "txtEmp1WeeklyUnits"
        Me.txtEmp1WeeklyUnits.Size = New System.Drawing.Size(350, 288)
        Me.txtEmp1WeeklyUnits.TabIndex = 4
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.txtEmp1WeeklyUnits, "Displays Entered Units Per Day For Employee 1")
        '
        'txtUnitsPerDay
        '
        Me.txtUnitsPerDay.Location = New System.Drawing.Point(208, 115)
        Me.txtUnitsPerDay.Name = "txtUnitsPerDay"
        Me.txtUnitsPerDay.Size = New System.Drawing.Size(164, 38)
        Me.txtUnitsPerDay.TabIndex = 1
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.txtUnitsPerDay, "Please Enter Units Per Day")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(774, 706)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(350, 55)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.btnExit, "Click Here to Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(407, 706)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(350, 55)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.btnReset, "Click Here To Reset The Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(40, 706)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(350, 55)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.btnEnter, "Click to Calculate The Average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblDaysCounter
        '
        Me.lblDaysCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDaysCounter.Location = New System.Drawing.Point(45, 46)
        Me.lblDaysCounter.Name = "lblDaysCounter"
        Me.lblDaysCounter.Size = New System.Drawing.Size(150, 51)
        Me.lblDaysCounter.TabIndex = 2
        Me.lblDaysCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTipAvgUnitsShippedByEmp.SetToolTip(Me.lblDaysCounter, "Displays Day Number For Employee")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(831, 204)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(237, 37)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(463, 204)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(237, 37)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(95, 204)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(237, 37)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(45, 109)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(150, 51)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAvgUnitsShippedByEmp
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(1179, 779)
        Me.Controls.Add(Me.lblOverallResult)
        Me.Controls.Add(Me.lblAvgEmp2)
        Me.Controls.Add(Me.lblAvgEmp1)
        Me.Controls.Add(Me.lblAvgEmp3)
        Me.Controls.Add(Me.txtEmp3WeeklyUnits)
        Me.Controls.Add(Me.txtEmp2WeeklyUnits)
        Me.Controls.Add(Me.txtEmp1WeeklyUnits)
        Me.Controls.Add(Me.txtUnitsPerDay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDaysCounter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvgUnitsShippedByEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOverallResult As Label
    Friend WithEvents ToolTipAvgUnitsShippedByEmp As ToolTip
    Friend WithEvents lblAvgEmp2 As Label
    Friend WithEvents lblAvgEmp1 As Label
    Friend WithEvents lblAvgEmp3 As Label
    Friend WithEvents txtEmp3WeeklyUnits As TextBox
    Friend WithEvents txtEmp2WeeklyUnits As TextBox
    Friend WithEvents txtEmp1WeeklyUnits As TextBox
    Friend WithEvents txtUnitsPerDay As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblDaysCounter As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblUnits As Label
End Class
