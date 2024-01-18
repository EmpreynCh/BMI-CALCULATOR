Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BMITXTBX.ReadOnly = True
        BMICAT.ReadOnly = True
        BMITXTBX.Enabled = False
        BMICAT.Enabled = False
        WEIGHTTXTBX.TabStop = False
        HEIGHTTXTBX.TabStop = False
        WEIGHTTXTBX.ForeColor = Color.Green
        HEIGHTTXTBX.ForeColor = Color.Green
    End Sub
    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        WEIGHTTXTBX.Text = String.Empty
        HEIGHTTXTBX.Text = String.Empty
        BMITXTBX.Text = String.Empty
        BMICAT.Text = String.Empty
    End Sub
    Private Sub BTNCOM_Click(sender As Object, e As EventArgs) Handles BTNCOM.Click
        Dim WT As Double
        Dim HT As Double
        Dim BMI As Double
        Dim MT As Double
        Dim WeightUser As String = WEIGHTTXTBX.Text ' Assuming the user input is in a TextBox named TextBox1
        ' Try to parse the user input as a double
        Dim WeightInput As Double
        If Double.TryParse(WeightUser, WeightInput) Then
            ' Check if the parsed value is a whole number (integer)
            If WeightInput = Math.Floor(WeightInput) Then
                ' The user input is a valid integer
                MessageBox.Show("Valid integer input: " & WeightInput.ToString())
            Else
                ' The user input is not a valid integer
                MessageBox.Show("Invalid input. Please enter an integer.")
            End If
        Else
            ' The user input is not a valid double
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If
        Dim HeightUser As String = WEIGHTTXTBX.Text ' Assuming the user input is in a TextBox named TextBox1
        ' Try to parse the user input as a double
        Dim HeightInput As Double
        If Double.TryParse(HeightUser, HeightInput) Then
            ' Check if the parsed value is a whole number (integer)
            If HeightInput = Math.Floor(HeightInput) Then
                ' The user input is a valid integer
                MessageBox.Show("Valid integer input: " & HeightInput.ToString())
            Else
                ' The user input is not a valid integer
                MessageBox.Show("Invalid input. Please enter an integer.")
            End If
        Else
            ' The user input is not a valid double
            MessageBox.Show("Invalid input. Please enter a valid number.")
        End If
        WT = WEIGHTTXTBX.Text
        HT = HEIGHTTXTBX.Text
        MT = WT / 100
        BMI = HT / (MT * MT)
        BMITXTBX.Text = Math.Round(BMI, 2)
        If BMI < 15 Then
            BMICAT.Text = "Very severely underweight"
        ElseIf BMI >= 15 And BMI <= 16 Then
            BMICAT.Text = "Severely underweight"
        ElseIf BMI >= 15 And BMI <= 25 Then
            BMICAT.Text = "Underweight"
        ElseIf BMI >= 25 And BMI <= 30 Then
            BMICAT.Text = "Normal (Healthy Weight)"
        ElseIf BMI >= 30 And BMI <= 35 Then
            BMICAT.Text = "Overweight"
        ElseIf BMI >= 30 And BMI <= 35 Then
            BMICAT.Text = "Moderately Obese"
        ElseIf BMI >= 35 And BMI <= 40 Then
            BMICAT.Text = "Severely Obese"
        ElseIf BMI > 40 Then
            BMICAT.Text = "Very Severely Obese"
        End If
    End Sub
    Private Sub WEIGHTTXTBX_GotFocus(sender As Object, e As EventArgs) Handles WEIGHTTXTBX.GotFocus
        If WEIGHTTXTBX.Text = "" Then
            WEIGHTTXTBX.Clear()
            WEIGHTTXTBX.ForeColor = Color.Black
        End If
    End Sub
    Private Sub HEIGHTTXTBX_GotFocus(sender As Object, e As EventArgs) Handles HEIGHTTXTBX.GotFocus
        If HEIGHTTXTBX.Text = "" Then
            HEIGHTTXTBX.Clear()
            HEIGHTTXTBX.ForeColor = Color.Black
        End If
    End Sub

    Private Sub WEIGHTTXTBX_LostFocus(sender As Object, e As EventArgs) Handles WEIGHTTXTBX.LostFocus
        If WEIGHTTXTBX.Text = "" Then
            WEIGHTTXTBX.Text = ""
            WEIGHTTXTBX.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub HEIGHTTXTBX_LostFocus(sender As Object, e As EventArgs) Handles HEIGHTTXTBX.LostFocus
        If HEIGHTTXTBX.Text = "" Then
            HEIGHTTXTBX.Text = ""
            HEIGHTTXTBX.ForeColor = Color.Gray
        End If
    End Sub


End Class
