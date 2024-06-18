Imports System.IO

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.WriteAllText(Form1.fisier, TextBox1.Text & TextBox2.Text)
        '  File.WriteAllText(Form1.fisier, TextBox2.Text)
        MessageBox.Show("Multumim pentru autentificare!")
        Me.Hide()


    End Sub
End Class