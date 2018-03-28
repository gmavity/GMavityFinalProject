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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblEffort = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.txtEffort = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(73, 35)
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
        Me.lblRank.Text = "Rank (0-5): "
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
        Me.lblEffort.Location = New System.Drawing.Point(55, 135)
        Me.lblEffort.Name = "lblEffort"
        Me.lblEffort.Size = New System.Drawing.Size(59, 13)
        Me.lblEffort.TabIndex = 4
        Me.lblEffort.Text = "Effort (0-5):"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(18, 209)
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
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(121, 95)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(100, 20)
        Me.txtRank.TabIndex = 8
        '
        'txtEffort
        '
        Me.txtEffort.Location = New System.Drawing.Point(121, 127)
        Me.txtEffort.Name = "txtEffort"
        Me.txtEffort.Size = New System.Drawing.Size(100, 20)
        Me.txtEffort.TabIndex = 9
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
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 392)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtEffort)
        Me.Controls.Add(Me.txtRank)
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
    Friend WithEvents txtRank As TextBox
    Friend WithEvents txtEffort As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpDueDate As DateTimePicker
End Class
