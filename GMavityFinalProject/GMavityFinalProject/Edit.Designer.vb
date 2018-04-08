<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblEffort = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.ttipRank = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipEffort = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpEffort = New System.Windows.Forms.GroupBox()
        Me.radEffort5 = New System.Windows.Forms.RadioButton()
        Me.radEffort2 = New System.Windows.Forms.RadioButton()
        Me.radEffort4 = New System.Windows.Forms.RadioButton()
        Me.radEffort1 = New System.Windows.Forms.RadioButton()
        Me.radEffort3 = New System.Windows.Forms.RadioButton()
        Me.grpRank = New System.Windows.Forms.GroupBox()
        Me.radRank5 = New System.Windows.Forms.RadioButton()
        Me.radRank4 = New System.Windows.Forms.RadioButton()
        Me.radRank3 = New System.Windows.Forms.RadioButton()
        Me.radRank2 = New System.Windows.Forms.RadioButton()
        Me.radRank1 = New System.Windows.Forms.RadioButton()
        Me.ttipName = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipType = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipDueDate = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipDescription = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpEffort.SuspendLayout()
        Me.grpRank.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(73, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(80, 67)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Type:"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(51, 98)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(63, 13)
        Me.lblRank.TabIndex = 2
        Me.lblRank.Text = "Rank (1-5): "
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(58, 172)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(56, 13)
        Me.lblDueDate.TabIndex = 3
        Me.lblDueDate.Text = "Due Date:"
        '
        'lblEffort
        '
        Me.lblEffort.AutoSize = True
        Me.lblEffort.Location = New System.Drawing.Point(55, 130)
        Me.lblEffort.Name = "lblEffort"
        Me.lblEffort.Size = New System.Drawing.Size(59, 13)
        Me.lblEffort.TabIndex = 4
        Me.lblEffort.Text = "Effort (1-5):"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(19, 209)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(96, 13)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description/Notes:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(121, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 6
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(121, 64)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(121, 206)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(189, 154)
        Me.txtDescription.TabIndex = 10
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(121, 166)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpDueDate.TabIndex = 11
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(131, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'grpEffort
        '
        Me.grpEffort.Controls.Add(Me.radEffort5)
        Me.grpEffort.Controls.Add(Me.radEffort2)
        Me.grpEffort.Controls.Add(Me.radEffort4)
        Me.grpEffort.Controls.Add(Me.radEffort1)
        Me.grpEffort.Controls.Add(Me.radEffort3)
        Me.grpEffort.Location = New System.Drawing.Point(120, 127)
        Me.grpEffort.Name = "grpEffort"
        Me.grpEffort.Size = New System.Drawing.Size(188, 30)
        Me.grpEffort.TabIndex = 28
        Me.grpEffort.TabStop = False
        '
        'radEffort5
        '
        Me.radEffort5.AutoSize = True
        Me.radEffort5.Location = New System.Drawing.Point(155, 7)
        Me.radEffort5.Name = "radEffort5"
        Me.radEffort5.Size = New System.Drawing.Size(31, 17)
        Me.radEffort5.TabIndex = 34
        Me.radEffort5.TabStop = True
        Me.radEffort5.Text = "5"
        Me.radEffort5.UseVisualStyleBackColor = True
        '
        'radEffort2
        '
        Me.radEffort2.AutoSize = True
        Me.radEffort2.Location = New System.Drawing.Point(44, 7)
        Me.radEffort2.Name = "radEffort2"
        Me.radEffort2.Size = New System.Drawing.Size(31, 17)
        Me.radEffort2.TabIndex = 31
        Me.radEffort2.TabStop = True
        Me.radEffort2.Text = "2"
        Me.radEffort2.UseVisualStyleBackColor = True
        '
        'radEffort4
        '
        Me.radEffort4.AutoSize = True
        Me.radEffort4.Location = New System.Drawing.Point(118, 7)
        Me.radEffort4.Name = "radEffort4"
        Me.radEffort4.Size = New System.Drawing.Size(31, 17)
        Me.radEffort4.TabIndex = 33
        Me.radEffort4.TabStop = True
        Me.radEffort4.Text = "4"
        Me.radEffort4.UseVisualStyleBackColor = True
        '
        'radEffort1
        '
        Me.radEffort1.AutoSize = True
        Me.radEffort1.Checked = True
        Me.radEffort1.Location = New System.Drawing.Point(6, 7)
        Me.radEffort1.Name = "radEffort1"
        Me.radEffort1.Size = New System.Drawing.Size(31, 17)
        Me.radEffort1.TabIndex = 30
        Me.radEffort1.TabStop = True
        Me.radEffort1.Text = "1"
        Me.radEffort1.UseVisualStyleBackColor = True
        '
        'radEffort3
        '
        Me.radEffort3.AutoSize = True
        Me.radEffort3.Location = New System.Drawing.Point(81, 7)
        Me.radEffort3.Name = "radEffort3"
        Me.radEffort3.Size = New System.Drawing.Size(31, 17)
        Me.radEffort3.TabIndex = 32
        Me.radEffort3.TabStop = True
        Me.radEffort3.Text = "3"
        Me.radEffort3.UseVisualStyleBackColor = True
        '
        'grpRank
        '
        Me.grpRank.Controls.Add(Me.radRank5)
        Me.grpRank.Controls.Add(Me.radRank4)
        Me.grpRank.Controls.Add(Me.radRank3)
        Me.grpRank.Controls.Add(Me.radRank2)
        Me.grpRank.Controls.Add(Me.radRank1)
        Me.grpRank.Location = New System.Drawing.Point(120, 90)
        Me.grpRank.Name = "grpRank"
        Me.grpRank.Size = New System.Drawing.Size(188, 30)
        Me.grpRank.TabIndex = 27
        Me.grpRank.TabStop = False
        '
        'radRank5
        '
        Me.radRank5.AutoSize = True
        Me.radRank5.Location = New System.Drawing.Point(155, 7)
        Me.radRank5.Name = "radRank5"
        Me.radRank5.Size = New System.Drawing.Size(31, 17)
        Me.radRank5.TabIndex = 29
        Me.radRank5.Text = "5"
        Me.radRank5.UseVisualStyleBackColor = True
        '
        'radRank4
        '
        Me.radRank4.AutoSize = True
        Me.radRank4.Location = New System.Drawing.Point(118, 7)
        Me.radRank4.Name = "radRank4"
        Me.radRank4.Size = New System.Drawing.Size(31, 17)
        Me.radRank4.TabIndex = 28
        Me.radRank4.Text = "4"
        Me.radRank4.UseVisualStyleBackColor = True
        '
        'radRank3
        '
        Me.radRank3.AutoSize = True
        Me.radRank3.Location = New System.Drawing.Point(81, 7)
        Me.radRank3.Name = "radRank3"
        Me.radRank3.Size = New System.Drawing.Size(31, 17)
        Me.radRank3.TabIndex = 27
        Me.radRank3.Text = "3"
        Me.radRank3.UseVisualStyleBackColor = True
        '
        'radRank2
        '
        Me.radRank2.AutoSize = True
        Me.radRank2.Location = New System.Drawing.Point(44, 7)
        Me.radRank2.Name = "radRank2"
        Me.radRank2.Size = New System.Drawing.Size(31, 17)
        Me.radRank2.TabIndex = 1
        Me.radRank2.Text = "2"
        Me.radRank2.UseVisualStyleBackColor = True
        '
        'radRank1
        '
        Me.radRank1.AutoSize = True
        Me.radRank1.Checked = True
        Me.radRank1.Location = New System.Drawing.Point(6, 7)
        Me.radRank1.Name = "radRank1"
        Me.radRank1.Size = New System.Drawing.Size(31, 17)
        Me.radRank1.TabIndex = 0
        Me.radRank1.TabStop = True
        Me.radRank1.Text = "1"
        Me.radRank1.UseVisualStyleBackColor = True
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 442)
        Me.Controls.Add(Me.grpEffort)
        Me.Controls.Add(Me.grpRank)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblEffort)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmEdit"
        Me.Text = "Edit Task"
        Me.grpEffort.ResumeLayout(False)
        Me.grpEffort.PerformLayout()
        Me.grpRank.ResumeLayout(False)
        Me.grpRank.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblEffort As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents ttipRank As ToolTip
    Friend WithEvents ttipEffort As ToolTip
    Friend WithEvents btnSubmit As Button
    Friend WithEvents grpEffort As GroupBox
    Friend WithEvents radEffort5 As RadioButton
    Friend WithEvents radEffort2 As RadioButton
    Friend WithEvents radEffort4 As RadioButton
    Friend WithEvents radEffort1 As RadioButton
    Friend WithEvents radEffort3 As RadioButton
    Friend WithEvents grpRank As GroupBox
    Friend WithEvents radRank5 As RadioButton
    Friend WithEvents radRank4 As RadioButton
    Friend WithEvents radRank3 As RadioButton
    Friend WithEvents radRank2 As RadioButton
    Friend WithEvents radRank1 As RadioButton
    Friend WithEvents ttipName As ToolTip
    Friend WithEvents ttipType As ToolTip
    Friend WithEvents ttipDueDate As ToolTip
    Friend WithEvents ttipDescription As ToolTip
End Class
