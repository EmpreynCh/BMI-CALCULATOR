<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        BMICATTXTBX = New Label()
        WEIGHTTXTBX = New TextBox()
        HEIGHTTXTBX = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BMITXTBX = New TextBox()
        BMICAT = New TextBox()
        bmi = New Label()
        Label6 = New Label()
        BTNCLEAR = New Button()
        BTNCOM = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(99, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(459, 62)
        Label1.TabIndex = 0
        Label1.Text = "BMI CALCULATOR"
        ' 
        ' BMICATTXTBX
        ' 
        BMICATTXTBX.AutoSize = True
        BMICATTXTBX.BackColor = SystemColors.Highlight
        BMICATTXTBX.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BMICATTXTBX.ForeColor = SystemColors.ButtonHighlight
        BMICATTXTBX.Location = New Point(99, 177)
        BMICATTXTBX.Name = "BMICATTXTBX"
        BMICATTXTBX.Size = New Size(87, 31)
        BMICATTXTBX.TabIndex = 1
        BMICATTXTBX.Text = "Weight"
        ' 
        ' WEIGHTTXTBX
        ' 
        WEIGHTTXTBX.BackColor = SystemColors.InactiveBorder
        WEIGHTTXTBX.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        WEIGHTTXTBX.ForeColor = SystemColors.ControlLightLight
        WEIGHTTXTBX.Location = New Point(199, 162)
        WEIGHTTXTBX.Multiline = True
        WEIGHTTXTBX.Name = "WEIGHTTXTBX"
        WEIGHTTXTBX.Size = New Size(222, 46)
        WEIGHTTXTBX.TabIndex = 2
        ' 
        ' HEIGHTTXTBX
        ' 
        HEIGHTTXTBX.BackColor = SystemColors.InactiveBorder
        HEIGHTTXTBX.Location = New Point(199, 245)
        HEIGHTTXTBX.Multiline = True
        HEIGHTTXTBX.Name = "HEIGHTTXTBX"
        HEIGHTTXTBX.Size = New Size(222, 46)
        HEIGHTTXTBX.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Highlight
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(103, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 31)
        Label2.TabIndex = 1
        Label2.Text = "Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Highlight
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(427, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 31)
        Label3.TabIndex = 1
        Label3.Text = "Kg"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Highlight
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(427, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 31)
        Label4.TabIndex = 1
        Label4.Text = "Cm"
        ' 
        ' BMITXTBX
        ' 
        BMITXTBX.BackColor = SystemColors.InactiveBorder
        BMITXTBX.Location = New Point(199, 322)
        BMITXTBX.Multiline = True
        BMITXTBX.Name = "BMITXTBX"
        BMITXTBX.Size = New Size(222, 46)
        BMITXTBX.TabIndex = 2
        ' 
        ' BMICAT
        ' 
        BMICAT.BackColor = SystemColors.MenuBar
        BMICAT.Location = New Point(233, 399)
        BMICAT.Multiline = True
        BMICAT.Name = "BMICAT"
        BMICAT.Size = New Size(325, 46)
        BMICAT.TabIndex = 2
        ' 
        ' bmi
        ' 
        bmi.AutoSize = True
        bmi.BackColor = SystemColors.Highlight
        bmi.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        bmi.ForeColor = SystemColors.ButtonHighlight
        bmi.Location = New Point(103, 322)
        bmi.Name = "bmi"
        bmi.Size = New Size(54, 31)
        bmi.TabIndex = 1
        bmi.Text = "BMI"
        bmi.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Highlight
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(75, 399)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 31)
        Label6.TabIndex = 1
        Label6.Text = "BMI Category"
        ' 
        ' BTNCLEAR
        ' 
        BTNCLEAR.Location = New Point(70, 515)
        BTNCLEAR.Name = "BTNCLEAR"
        BTNCLEAR.Size = New Size(178, 86)
        BTNCLEAR.TabIndex = 3
        BTNCLEAR.Text = "CLEAR"
        BTNCLEAR.UseVisualStyleBackColor = True
        ' 
        ' BTNCOM
        ' 
        BTNCOM.Location = New Point(336, 515)
        BTNCOM.Name = "BTNCOM"
        BTNCOM.Size = New Size(178, 86)
        BTNCOM.TabIndex = 3
        BTNCOM.Text = "COMPUTE"
        BTNCOM.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(652, 714)
        Controls.Add(BTNCOM)
        Controls.Add(BTNCLEAR)
        Controls.Add(BMICAT)
        Controls.Add(BMITXTBX)
        Controls.Add(HEIGHTTXTBX)
        Controls.Add(WEIGHTTXTBX)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(bmi)
        Controls.Add(Label2)
        Controls.Add(BMICATTXTBX)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BMICATTXTBX As Label
    Friend WithEvents WEIGHTTXTBX As TextBox
    Friend WithEvents HEIGHTTXTBX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BMITXTBX As TextBox
    Friend WithEvents BMICAT As TextBox
    Friend WithEvents bmi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNCLEAR As Button
    Friend WithEvents BTNCOM As Button
End Class
