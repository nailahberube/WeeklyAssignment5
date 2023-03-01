<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComic
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radSuperheroExperience = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblLabelCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.grpBadgeType.SuspendLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Red
        Me.lblHeader.Location = New System.Drawing.Point(86, 178)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(622, 42)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Comic Convention Registration "
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Red
        Me.lblGroupSize.Location = New System.Drawing.Point(283, 237)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(128, 24)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 3
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Location = New System.Drawing.Point(417, 237)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(100, 26)
        Me.txtGroupSize.TabIndex = 5
        '
        'grpBadgeType
        '
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radAutographs)
        Me.grpBadgeType.Controls.Add(Me.radSuperheroExperience)
        Me.grpBadgeType.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Red
        Me.grpBadgeType.Location = New System.Drawing.Point(221, 289)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(377, 123)
        Me.grpBadgeType.TabIndex = 6
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radSuperheroExperience
        '
        Me.radSuperheroExperience.AutoSize = True
        Me.radSuperheroExperience.Checked = True
        Me.radSuperheroExperience.Location = New System.Drawing.Point(7, 29)
        Me.radSuperheroExperience.Name = "radSuperheroExperience"
        Me.radSuperheroExperience.Size = New System.Drawing.Size(365, 25)
        Me.radSuperheroExperience.TabIndex = 0
        Me.radSuperheroExperience.TabStop = True
        Me.radSuperheroExperience.Text = "Convention + Superhero Experience"
        Me.radSuperheroExperience.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Location = New System.Drawing.Point(7, 60)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(268, 25)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(7, 91)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(141, 25)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Red
        Me.lblCost.Location = New System.Drawing.Point(248, 415)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(207, 24)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Regristration Cost:"
        '
        'lblLabelCostEstimate
        '
        Me.lblLabelCostEstimate.AutoSize = True
        Me.lblLabelCostEstimate.Font = New System.Drawing.Font("Bookman Old Style", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabelCostEstimate.ForeColor = System.Drawing.Color.Red
        Me.lblLabelCostEstimate.Location = New System.Drawing.Point(461, 419)
        Me.lblLabelCostEstimate.Name = "lblLabelCostEstimate"
        Me.lblLabelCostEstimate.Size = New System.Drawing.Size(91, 19)
        Me.lblLabelCostEstimate.TabIndex = 8
        Me.lblLabelCostEstimate.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(287, 457)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 32)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(417, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 32)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picComic
        '
        Me.picComic.Image = Global.WeeklyAssignment5.My.Resources.Resources.comic
        Me.picComic.Location = New System.Drawing.Point(0, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(798, 175)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 1
        Me.picComic.TabStop = False
        '
        'frmComic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 514)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblLabelCostEstimate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.picComic)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmComic"
        Me.Text = "Comic Convention Registration "
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperheroExperience As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents lblLabelCostEstimate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
