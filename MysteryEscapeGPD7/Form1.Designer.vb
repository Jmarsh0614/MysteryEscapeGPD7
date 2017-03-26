<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscape
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblGameType = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindCost = New System.Windows.Forms.Button()
        Me.lstGame = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblLength)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblGameType)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnFindCost)
        Me.Panel1.Controls.Add(Me.lstGame)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtTeam)
        Me.Panel1.Controls.Add(Me.lblTeam)
        Me.Panel1.Controls.Add(Me.cboCity)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(401, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 448)
        Me.Panel1.TabIndex = 0
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(130, 405)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(180, 25)
        Me.lblLength.TabIndex = 7
        Me.lblLength.Text = "XXXXXXXXXXXX"
        Me.lblLength.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(130, 381)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(180, 25)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "XXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'lblGameType
        '
        Me.lblGameType.AutoSize = True
        Me.lblGameType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameType.Location = New System.Drawing.Point(130, 357)
        Me.lblGameType.Name = "lblGameType"
        Me.lblGameType.Size = New System.Drawing.Size(180, 25)
        Me.lblGameType.TabIndex = 7
        Me.lblGameType.Text = "XXXXXXXXXXXX"
        Me.lblGameType.Visible = False
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.Color.Sienna
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.ForeColor = System.Drawing.Color.Khaki
        Me.btnClear.Location = New System.Drawing.Point(235, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 37)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnFindCost
        '
        Me.btnFindCost.AutoSize = True
        Me.btnFindCost.BackColor = System.Drawing.Color.Sienna
        Me.btnFindCost.ForeColor = System.Drawing.Color.Khaki
        Me.btnFindCost.Location = New System.Drawing.Point(65, 305)
        Me.btnFindCost.Name = "btnFindCost"
        Me.btnFindCost.Size = New System.Drawing.Size(154, 37)
        Me.btnFindCost.TabIndex = 6
        Me.btnFindCost.Text = "Find Team Cost"
        Me.btnFindCost.UseVisualStyleBackColor = False
        Me.btnFindCost.Visible = False
        '
        'lstGame
        '
        Me.lstGame.FormattingEnabled = True
        Me.lstGame.ItemHeight = 24
        Me.lstGame.Location = New System.Drawing.Point(162, 207)
        Me.lstGame.Name = "lstGame"
        Me.lstGame.Size = New System.Drawing.Size(120, 76)
        Me.lstGame.TabIndex = 5
        Me.lstGame.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(130, 180)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(171, 24)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Game Type:"
        Me.lblSelect.Visible = False
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(307, 129)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(25, 29)
        Me.txtTeam.TabIndex = 3
        Me.txtTeam.Visible = False
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(125, 133)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(176, 25)
        Me.lblTeam.TabIndex = 2
        Me.lblTeam.Text = "Number in Team:"
        Me.lblTeam.Visible = False
        '
        'cboCity
        '
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Items.AddRange(New Object() {"Dallas", "Paris", "Singapore"})
        Me.cboCity.Location = New System.Drawing.Point(130, 82)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(202, 32)
        Me.cboCity.TabIndex = 1
        Me.cboCity.Text = "Select City Location:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Sienna
        Me.lblTitle.Location = New System.Drawing.Point(8, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(442, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mystery Escape Information"
        '
        'frmEscape
        '
        Me.AcceptButton = Me.btnFindCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MysteryEscapeGPD7.My.Resources.Resources.Escape
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(854, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEscape"
        Me.Text = "                                                                                 " &
    "           Information on Mystery Escape Experiences."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboCity As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblGameType As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFindCost As Button
    Friend WithEvents lstGame As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblTeam As Label
End Class
