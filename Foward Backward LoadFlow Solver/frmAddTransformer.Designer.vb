<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTransformer
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
        Me.txtStartNode = New System.Windows.Forms.TextBox()
        Me.txtEndNode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrimaryVoltage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSecondaryVoltage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPercentageImpedance = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhaseAngle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtXRRatio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Node"
        '
        'txtStartNode
        '
        Me.txtStartNode.Location = New System.Drawing.Point(146, 10)
        Me.txtStartNode.Name = "txtStartNode"
        Me.txtStartNode.Size = New System.Drawing.Size(86, 20)
        Me.txtStartNode.TabIndex = 1
        '
        'txtEndNode
        '
        Me.txtEndNode.Location = New System.Drawing.Point(146, 36)
        Me.txtEndNode.Name = "txtEndNode"
        Me.txtEndNode.Size = New System.Drawing.Size(86, 20)
        Me.txtEndNode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Node"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(146, 61)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(86, 20)
        Me.txtPower.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Power"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "KVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "V"
        '
        'txtPrimaryVoltage
        '
        Me.txtPrimaryVoltage.Location = New System.Drawing.Point(146, 86)
        Me.txtPrimaryVoltage.Name = "txtPrimaryVoltage"
        Me.txtPrimaryVoltage.Size = New System.Drawing.Size(86, 20)
        Me.txtPrimaryVoltage.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Primary Voltage (Vp)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "V"
        '
        'txtSecondaryVoltage
        '
        Me.txtSecondaryVoltage.Location = New System.Drawing.Point(146, 111)
        Me.txtSecondaryVoltage.Name = "txtSecondaryVoltage"
        Me.txtSecondaryVoltage.Size = New System.Drawing.Size(86, 20)
        Me.txtSecondaryVoltage.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Secondary Voltage (Vp)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "%"
        '
        'txtPercentageImpedance
        '
        Me.txtPercentageImpedance.Location = New System.Drawing.Point(146, 136)
        Me.txtPercentageImpedance.Name = "txtPercentageImpedance"
        Me.txtPercentageImpedance.Size = New System.Drawing.Size(86, 20)
        Me.txtPercentageImpedance.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Persentage Impedance"
        '
        'txtPhaseAngle
        '
        Me.txtPhaseAngle.Location = New System.Drawing.Point(146, 161)
        Me.txtPhaseAngle.Name = "txtPhaseAngle"
        Me.txtPhaseAngle.Size = New System.Drawing.Size(86, 20)
        Me.txtPhaseAngle.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Phase Angle"
        '
        'txtXRRatio
        '
        Me.txtXRRatio.Location = New System.Drawing.Point(146, 186)
        Me.txtXRRatio.Name = "txtXRRatio"
        Me.txtXRRatio.Size = New System.Drawing.Size(86, 20)
        Me.txtXRRatio.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "X/R Ratio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(246, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "deg"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Type"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"DY", "YD"})
        Me.cmbType.Location = New System.Drawing.Point(146, 211)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(86, 21)
        Me.cmbType.TabIndex = 22
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(196, 245)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLibrary
        '
        Me.btnLibrary.Location = New System.Drawing.Point(10, 245)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(86, 23)
        Me.btnLibrary.TabIndex = 24
        Me.btnLibrary.Text = "Browse Library"
        Me.btnLibrary.UseVisualStyleBackColor = True
        '
        'frmAddTransformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 276)
        Me.Controls.Add(Me.btnLibrary)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtXRRatio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPhaseAngle)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPercentageImpedance)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSecondaryVoltage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrimaryVoltage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEndNode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStartNode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddTransformer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Transformer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtStartNode As TextBox
    Friend WithEvents txtEndNode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPower As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrimaryVoltage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSecondaryVoltage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPercentageImpedance As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhaseAngle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtXRRatio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLibrary As Button
End Class
