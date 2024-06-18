Imports System.IO

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim continut As String = File.ReadAllText(Form1.fisier)
        If TextBox1.Text & TextBox2.Text = continut Then
            MessageBox.Show("Autentificare cu succes")
            Form1.Button4.Show()
            Me.Hide()


        Else
            MessageBox.Show("Date de autentificare incorecte")
        End If
    End Sub
End Class