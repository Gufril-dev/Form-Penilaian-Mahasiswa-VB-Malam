Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Txtname.Text = ""
        Txtnpm.Text = ""
        ComboBoxmajor.Text = ""
        Txttaskscore.Text = " "
        Txttaskscore.Text = ""
        Txtutsscore.Text = ""
        Txtuasscore.Text = ""
        Txtpresence.Text = ""
        Txtsks.Text = ""
        Txtips.Text = ""
        Txtipk.Text = ""
        Txttotalscore.Text = ""
        Txttotalsemester.Text = ""
        Txtgrade.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim label1 = Txtname.Text
        Dim label2 = Txtnpm.Text
        Dim label3 = ComboBoxmajor.Text
        Dim label4 = Txtsks.Text
        Dim label5 = Txttaskscore.Text
        Dim label6 = Txtutsscore.Text
        Dim label7 = Txtuasscore.Text
        Dim label8 = Txtpresence.Text
        Dim label9 = Txtips.Text
        Dim label10 = Txtipk.Text
        Dim label12 = Txttotalscore.Text
        Dim label13 = Txttotalsemester.Text
        Dim label14 = Txtgrade.Text

        Txttotalscore.Text = (((Txtpresence.Text / 16) * 0.1) + Txttaskscore.Text * 0.2 + Txtutsscore.Text * 0.3 + Txtuasscore.Text * 0.4)
        Txtips.Text = Txttotalscore.Text / Txtsks.Text
        Txtipk.Text = (Txttotalscore.Text * Txttotalsemester.Text) / (Txtsks.Text * Txttotalsemester.Text)

        If Txtipk.Text >= 4 Then
            Txtgrade.Text = "A"
        ElseIf Txtipk.text >= 3 Then
            Txtgrade.Text = "B"
        ElseIf Txtipk.text >= 2 Then
            Txtgrade.Text = "C"
        ElseIf Txtipk.text >= 1 Then
            Txtgrade.Text = "D"
        End If
    End Sub

End Class
