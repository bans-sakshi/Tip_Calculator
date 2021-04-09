Public Class Form2
	Public bill, tipPercent, noperson As Double

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'For exit button
		Dim a As Integer
		a = MsgBox(" Thank you , Visit Again !!", MsgBoxStyle.OkCancel)
		If (a = MsgBoxResult.Ok) Then
			Me.Close()
		ElseIf (a = MsgBoxResult.Cancel) Then
		End If
	End Sub
	' Class is created with input from user for bill amount
	Public Class Cal
		Dim total As Double
		Public Function Tip_Cal() As Double ' This function will return value for tip for a person
			Dim tip As Double
			tip = Form2.bill * Form2.tipPercent
			Form2.TextBox2.Text = tip / Form2.noperson
			Return 0
		End Function

		Public Function Total_Amt() As Double ' function to calculating total amount with tip
			total = Form2.bill / Form2.noperson
			Form2.TextBox3.Text = total + Val(Form2.TextBox2.Text)
			Return 0
		End Function
	End Class

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		bill = Val(TextBox1.Text) ' store the input value
		' Exception 1
		Try
			If bill = 0 Then
				Throw New ArithmeticException
			End If
		Catch ey As Exception
			MsgBox("Input Invalid. Kindly Enter Again !", MsgBoxStyle.Exclamation, "EXCEPTION")
		End Try

		tipPercent = Val(NumericUpDown1.Text) / 100
		' Exception 2
		Try
			If tipPercent = 0 Then
				Throw New ArithmeticException
			End If
		Catch ex As Exception
			MsgBox("Tip cannot be zero", MsgBoxStyle.Exclamation, "EXCEPTION")
		End Try
		noperson = Val(NumericUpDown2.Text)

		Dim obj1 As New Cal() ' Object created
		obj1.Tip_Cal()
		obj1.Total_Amt()


	End Sub
End Class

