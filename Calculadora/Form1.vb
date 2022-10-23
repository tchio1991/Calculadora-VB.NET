Public Class Form1

    Dim Total As Double
    Dim dados1 As Double
    Dim dados2 As Double
    Dim operador As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Numero.Select()
    End Sub

    Private Sub Numero_TextChanged(sender As Object, e As EventArgs) Handles Numero.TextChanged
        If Not IsNumeric(Numero.Text) Then
            Numero.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Numero.Text = Numero.Text + "1"
    End Sub

    Private Sub Zerar_Click(sender As Object, e As EventArgs) Handles Zerar.Click
        Numero.Select()
        Numero.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Numero.Text = Numero.Text + "2"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Numero.Text = Numero.Text + "3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Numero.Text = Numero.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Numero.Text = Numero.Text + "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Numero.Text = Numero.Text + "6"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Numero.Text = Numero.Text + "7"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Numero.Text = Numero.Text + "8"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Numero.Text = Numero.Text + "9"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Numero.Text = Numero.Text + ","
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Numero.Text = Numero.Text + "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Numero.Text = Numero.Text + "."
    End Sub

    Private Sub Mais_Click(sender As Object, e As EventArgs) Handles Mais.Click
        If Numero.Text = "" Then
            MsgBox("Insira um valor", vbExclamation)
        Else
            operador = 1
            dados1 = Val(Numero.Text)
            Numero.Clear()
        End If

    End Sub

    Private Sub Menos_Click(sender As Object, e As EventArgs) Handles Menos.Click
        If Numero.Text = "" Then
            MsgBox("Insira um valor", vbExclamation)
        Else
            operador = 2
            dados1 = Val(Numero.Text)
            Numero.Clear()
        End If
    End Sub

    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        If Numero.Text = "" Then
            MsgBox("Insira um valor", vbExclamation)
        Else
            operador = 3
            dados1 = Val(Numero.Text)
            Numero.Clear()
        End If
    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        If Numero.Text = "" Then
            MsgBox("Insira um valor", vbExclamation)
        Else
            operador = 4
            dados1 = Val(Numero.Text)
            Numero.Clear()
        End If
    End Sub

    Private Sub Igual_Click(sender As Object, e As EventArgs) Handles Igual.Click
        dados2 = Val(Numero.Text)
        If operador = 1 Then
            Total = dados1 + dados2
            Numero.Text = Total
        End If

        dados2 = Val(Numero.Text)
        If operador = 2 Then
            Total = dados1 - dados2
            Numero.Text = Total
        End If

        dados2 = Val(Numero.Text)
        If operador = 3 Then
            Total = dados1 / dados2
            Numero.Text = Total
        End If

        dados2 = Val(Numero.Text)
        If operador = 4 Then
            Total = dados1 * dados2
            Numero.Text = Total
        End If
    End Sub
End Class
