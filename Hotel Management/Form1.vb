Imports System.IO
Public Class Form1
    Public fisier As String = "sign_up.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If File.Exists(fisier) Then
            Dim lines As String() = File.ReadAllLines(fisier)
            If lines.Length > 0 Then
                MessageBox.Show("sunteti deja autentificat")
            Else
                Form2.ShowDialog()
            End If
        Else
            MessageBox.Show("fisierul nu exista")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If File.Exists(fisier) Then
            Dim lines As String() = File.ReadAllLines(fisier)
            If lines.Length > 0 Then
                Form3.ShowDialog()

            Else
                MessageBox.Show("Nu aveti cont! Accesati optiunea Sign Up! ")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim raspuns As DialogResult
        raspuns = MessageBox.Show("Stergeti Contul? ", "Stergere Cont", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If raspuns = DialogResult.Yes Then
            File.WriteAllText(fisier, String.Empty)
            MessageBox.Show("Contul a fost sters cu succes :( ")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If File.Exists(fisier) Then
        '    Dim lines As String() = File.ReadAllLines(fisier)
        '    If lines.Length > 0 Then
        '        Button4.Show()
        '    Else
        '        MessageBox.Show("Nu aveti cont! Accesati optiunea Sign Up! ")
        '    End If
        'End If
    End Sub
End Class
