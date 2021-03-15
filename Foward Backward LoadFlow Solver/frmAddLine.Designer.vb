<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLine
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
        Me.txtEndNode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStartNode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.txtResistance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGmr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbPhases = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkNeutral = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSoilResistivity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txt12 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.txt23 = New System.Windows.Forms.TextBox()
        Me.txt13 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.txt3n = New System.Windows.Forms.TextBox()
        Me.txt2n = New System.Windows.Forms.TextBox()
        Me.txt1n = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEndNode
        '
        Me.txtEndNode.Location = New System.Drawing.Point(150, 36)
        Me.txtEndNode.Name = "txtEndNode"
        Me.txtEndNode.Size = New System.Drawing.Size(86, 20)
        Me.txtEndNode.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "End Node"
        '
        'txtStartNode
        '
        Me.txtStartNode.Location = New System.Drawing.Point(150, 10)
        Me.txtStartNode.Name = "txtStartNode"
        Me.txtStartNode.Size = New System.Drawing.Size(86, 20)
        Me.txtStartNode.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Start Node"
        '
        'btnLibrary
        '
        Me.btnLibrary.Location = New System.Drawing.Point(15, 273)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(86, 23)
        Me.btnLibrary.TabIndex = 25
        Me.btnLibrary.Text = "Browse Library"
        Me.btnLibrary.UseVisualStyleBackColor = True
        '
        'txtResistance
        '
        Me.txtResistance.Location = New System.Drawing.Point(150, 61)
        Me.txtResistance.Name = "txtResistance"
        Me.txtResistance.Size = New System.Drawing.Size(86, 20)
        Me.txtResistance.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Resistance"
        '
        'txtGmr
        '
        Me.txtGmr.Location = New System.Drawing.Point(150, 86)
        Me.txtGmr.Name = "txtGmr"
        Me.txtGmr.Size = New System.Drawing.Size(86, 20)
        Me.txtGmr.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "GMR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Ohm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "ft"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Overhead", "Underground"})
        Me.cmbType.Location = New System.Drawing.Point(150, 136)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(86, 21)
        Me.cmbType.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Type"
        '
        'cmbPhases
        '
        Me.cmbPhases.FormattingEnabled = True
        Me.cmbPhases.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbPhases.Location = New System.Drawing.Point(150, 161)
        Me.cmbPhases.Name = "cmbPhases"
        Me.cmbPhases.Size = New System.Drawing.Size(86, 21)
        Me.cmbPhases.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Phases"
        '
        'chkNeutral
        '
        Me.chkNeutral.AutoSize = True
        Me.chkNeutral.Location = New System.Drawing.Point(150, 189)
        Me.chkNeutral.Name = "chkNeutral"
        Me.chkNeutral.Size = New System.Drawing.Size(69, 17)
        Me.chkNeutral.TabIndex = 36
        Me.chkNeutral.Text = "Available"
        Me.chkNeutral.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Neutral Conductor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "mile"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(150, 111)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(86, 20)
        Me.txtLength.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Length"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(427, 273)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 41
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(246, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Ohmm"
        '
        'txtSoilResistivity
        '
        Me.txtSoilResistivity.Location = New System.Drawing.Point(150, 236)
        Me.txtSoilResistivity.Name = "txtSoilResistivity"
        Me.txtSoilResistivity.Size = New System.Drawing.Size(86, 20)
        Me.txtSoilResistivity.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 238)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Soil Resistivity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(246, 213)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Hz"
        '
        'txtFrequency
        '
        Me.txtFrequency.Location = New System.Drawing.Point(150, 211)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.Size = New System.Drawing.Size(86, 20)
        Me.txtFrequency.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Frequency"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(440, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "C"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(356, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(33, 20)
        Me.TextBox1.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(329, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 13)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(321, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 15)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Line Spacing (ft)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(364, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "A"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(356, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(33, 20)
        Me.TextBox2.TabIndex = 53
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(356, 111)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(33, 20)
        Me.TextBox3.TabIndex = 54
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(356, 136)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(33, 20)
        Me.TextBox4.TabIndex = 55
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(393, 136)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(33, 20)
        Me.TextBox5.TabIndex = 59
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(393, 111)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(33, 20)
        Me.TextBox6.TabIndex = 58
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(393, 86)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(33, 20)
        Me.TextBox7.TabIndex = 57
        '
        'txt12
        '
        Me.txt12.Location = New System.Drawing.Point(393, 61)
        Me.txt12.Name = "txt12"
        Me.txt12.Size = New System.Drawing.Size(33, 20)
        Me.txt12.TabIndex = 56
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(431, 136)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(33, 20)
        Me.TextBox9.TabIndex = 63
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(431, 111)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(33, 20)
        Me.TextBox10.TabIndex = 62
        '
        'txt23
        '
        Me.txt23.Location = New System.Drawing.Point(431, 86)
        Me.txt23.Name = "txt23"
        Me.txt23.Size = New System.Drawing.Size(33, 20)
        Me.txt23.TabIndex = 61
        '
        'txt13
        '
        Me.txt13.Location = New System.Drawing.Point(431, 61)
        Me.txt13.Name = "txt13"
        Me.txt13.Size = New System.Drawing.Size(33, 20)
        Me.txt13.TabIndex = 60
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(469, 136)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(33, 20)
        Me.TextBox13.TabIndex = 67
        '
        'txt3n
        '
        Me.txt3n.Location = New System.Drawing.Point(469, 111)
        Me.txt3n.Name = "txt3n"
        Me.txt3n.Size = New System.Drawing.Size(33, 20)
        Me.txt3n.TabIndex = 66
        '
        'txt2n
        '
        Me.txt2n.Location = New System.Drawing.Point(469, 86)
        Me.txt2n.Name = "txt2n"
        Me.txt2n.Size = New System.Drawing.Size(33, 20)
        Me.txt2n.TabIndex = 65
        '
        'txt1n
        '
        Me.txt1n.Location = New System.Drawing.Point(469, 61)
        Me.txt1n.Name = "txt1n"
        Me.txt1n.Size = New System.Drawing.Size(33, 20)
        Me.txt1n.TabIndex = 64
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(329, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 13)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "B"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(329, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 13)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "C"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(329, 139)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 13)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "N"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(404, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 13)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "B"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(477, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 13)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "N"
        '
        'frmAddLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 307)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.txt3n)
        Me.Controls.Add(Me.txt2n)
        Me.Controls.Add(Me.txt1n)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.txt23)
        Me.Controls.Add(Me.txt13)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txt12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSoilResistivity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtFrequency)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkNeutral)
        Me.Controls.Add(Me.cmbPhases)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGmr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtResistance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLibrary)
        Me.Controls.Add(Me.txtEndNode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStartNode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Transmission Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEndNode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStartNode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLibrary As Button
    Friend WithEvents txtResistance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGmr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbPhases As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkNeutral As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSoilResistivity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFrequency As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txt12 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents txt23 As TextBox
    Friend WithEvents txt13 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents txt3n As TextBox
    Friend WithEvents txt2n As TextBox
    Friend WithEvents txt1n As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
End Class
