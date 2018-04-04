<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreate
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
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtEffort = New System.Windows.Forms.TextBox()
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblEffort = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ttipRank = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttipEffort = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(116, 161)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpDueDate.TabIndex = 23
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(116, 201)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(189, 154)
        Me.txtDescription.TabIndex = 22
        '
        'txtEffort
        '
        Me.txtEffort.Location = New System.Drawing.Point(116, 122)
        Me.txtEffort.Name = "txtEffort"
        Me.txtEffort.Size = New System.Drawing.Size(100, 20)
        Me.txtEffort.TabIndex = 21
        '
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(116, 90)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(100, 20)
        Me.txtRank.TabIndex = 20
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(116, 59)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 19
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 18
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 204)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(96, 13)
        Me.lblDescription.TabIndex = 17
        Me.lblDescription.Text = "Description/Notes:"
        '
        'lblEffort
        '
        Me.lblEffort.AutoSize = True
        Me.lblEffort.Location = New System.Drawing.Point(50, 125)
        Me.lblEffort.Name = "lblEffort"
        Me.lblEffort.Size = New System.Drawing.Size(59, 13)
        Me.lblEffort.TabIndex = 16
        Me.lblEffort.Text = "Effort (1-5):"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(53, 167)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(56, 13)
        Me.lblDueDate.TabIndex = 15
        Me.lblDueDate.Text = "Due Date:"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(47, 93)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(63, 13)
        Me.lblRank.TabIndex = 14
        Me.lblRank.Text = "Rank (1-5): "
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(75, 62)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 13
        Me.lblType.Text = "Type:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(69, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name: "
        '
        'frmCreate
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
        Me.Name = "frmCreate"
        Me.Text = "Create Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtEffort As TextBox
    Friend WithEvents txtRank As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblEffort As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents ttipRank As ToolTip
    Friend WithEvents ttipEffort As ToolTip
End Class
