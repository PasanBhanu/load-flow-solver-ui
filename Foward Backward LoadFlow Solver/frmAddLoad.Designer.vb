<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddLoad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtPowerA_R = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPowerB_R = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPowerC_R = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbConnection = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPowerC_I = New System.Windows.Forms.TextBox()
        Me.txtPowerB_I = New System.Windows.Forms.TextBox()
        Me.txtPowerA_I = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPowerA_R
        '
        Me.txtPowerA_R.Location = New System.Drawing.Point(150, 36)
        Me.txtPowerA_R.Name = "txtPowerA_R"
        Me.txtPowerA_R.Size = New System.Drawing.Size(86, 20)
        Me.txtPowerA_R.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Power - Phase A"
        '
        'txtNode
        '
        Me.txtNode.Location = New System.Drawing.Point(150, 10)
        Me.txtNode.Name = "txtNode"
        Me.txtNode.Size = New System.Drawing.Size(86, 20)
        Me.txtNode.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Connected Node"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(309, 223)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(74, 23)
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLibrary
        '
        Me.btnLibrary.Location = New System.Drawing.Point(15, 223)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(86, 23)
        Me.btnLibrary.TabIndex = 42
        Me.btnLibrary.Text = "Browse Library"
        Me.btnLibrary.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "j    kW"
        '
        'txtPowerB_R
        '
        Me.txtPowerB_R.Location = New System.Drawing.Point(150, 61)
        Me.txtPowerB_R.Name = "txtPowerB_R"
        Me.txtPowerB_R.Size = New System.Drawing.Size(86, 20)
        Me.txtPowerB_R.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Power - Phase B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "j    kW"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "j    kW"
        '
        'txtPowerC_R
        '
        Me.txtPowerC_R.Location = New System.Drawing.Point(150, 86)
        Me.txtPowerC_R.Name = "txtPowerC_R"
        Me.txtPowerC_R.Size = New System.Drawing.Size(86, 20)
        Me.txtPowerC_R.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Power - Phase C"
        '
        'cmbConnection
        '
        Me.cmbConnection.FormattingEnabled = True
        Me.cmbConnection.Items.AddRange(New Object() {"Star", "Delta"})
        Me.cmbConnection.Location = New System.Drawing.Point(150, 186)
        Me.cmbConnection.Name = "cmbConnection"
        Me.cmbConnection.Size = New System.Drawing.Size(86, 21)
        Me.cmbConnection.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Connection"
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(150, 161)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(86, 20)
        Me.txtCC.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Constant Current"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(150, 136)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(86, 20)
        Me.txtCI.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Constant Impedance"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(150, 111)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(86, 20)
        Me.txtCP.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Constant Power"
        '
        'txtPowerC_I
        '
        Me.txtPowerC_I.Location = New System.Drawing.Point(259, 86)
        Me.txtPowerC_I.Name = "txtPowerC_I"
        Me.txtPowerC_I.Size = New System.Drawing.Size(86, 20)
        Me.txtPowerC_I.TabIndex = 63
        '
        'txtPowerB_I
        '
        Me.txtPowerB_I.Location = New System.Drawing.Point(259, 61)
        Me.txtPowerB_I.Name = "txtPowerB_I"
        Me.txtPowerB_I.Size = New System.Drawing.Size(86, 20)
        Me.txtPowerB_I.TabIndex = 62
        '
        'txtPowerA_I
        '
        Me.txtPowerA_I.Location = New System.Drawing.Point(259, 36)
        Me.txtPowerA_I.Name = "txtPowerA_I"
        Me.txtPowerA_I.Size = New System.Drawing.Size(86, 20)
        Me.txtPowerA_I.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "+"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "+"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(241, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "+"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAddLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 255)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPowerC_I)
        Me.Controls.Add(Me.txtPowerB_I)
        Me.Controls.Add(Me.txtPowerA_I)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbConnection)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPowerC_R)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPowerB_R)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLibrary)
        Me.Controls.Add(Me.txtPowerA_R)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddLoad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Load Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPowerA_R As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLibrary As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPowerB_R As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPowerC_R As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbConnection As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCI As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPowerC_I As TextBox
    Friend WithEvents txtPowerB_I As TextBox
    Friend WithEvents txtPowerA_I As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
