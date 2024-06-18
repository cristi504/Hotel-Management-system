Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Public Class Form4
    Public fisier As String = "cazare.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1, d2 As Date, var1, var2, z, nrzile As Integer

        d1 = DateTimePicker1.Value
        d2 = DateTimePicker2.Value
        nrzile = DateDiff(DateInterval.Day, d1, d2)
        TextBox1.Text = (nrzile + 1).ToString()
        '  Label2.Show()
        '  Label3.Show()
        If RadioButton1.Checked Then
            z = 100 * (nrzile + 1)
            TextBox2.Text = z

        End If
        If RadioButton2.Checked Then
            z = 150 * (nrzile + 1)
            TextBox2.Text = z
            CheckedListBox1.SetItemChecked(0, True)
            CheckedListBox1.SetItemChecked(1, True)
            CheckedListBox1.SetItemChecked(2, True)
            'CheckBox1.Checked = False

        End If

        For Each i As Integer In CheckedListBox1.CheckedIndices
            z = z + 50
        Next
        TextBox2.Text = z

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = DateTime.Today
        DateTimePicker2.MinDate = DateTime.Today
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim raspuns As DialogResult
        '  Dim checkeditems As New List(Of String)()
        raspuns = MessageBox.Show("Sunteti sigur? ", "Cazare", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If raspuns = DialogResult.Yes Then

            File.AppendAllText(fisier, Label5.Text & " " & TextBox1.Text & " " & Label2.Text & " " & Label3.Text & " " & TextBox2.Text & " " & Label8.Text & " ")
            File.AppendAllText(fisier, DateTimePicker1.Value & " ")
            File.AppendAllText(fisier, DateTimePicker2.Value & " ")
            If RadioButton1.Checked Then
                File.AppendAllText(fisier, RadioButton1.Text & " ")
            ElseIf RadioButton2.Checked Then
                File.AppendAllText(fisier, RadioButton2.Text & " ")
            End If
            For Each item As Object In CheckedListBox1.CheckedItems
                File.AppendAllText(fisier, item.ToString() & Environment.NewLine)
            Next
            'File.AppendAllText(fisier,)


            MessageBox.Show("Va asteptam cu drag! ")
            ' Button3.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If File.Exists(fisier) Then
        '    Dim lines As String() = File.ReadAllLines(fisier)
        '    If lines.Length > 0 Then
        '        Button3.Show()
        '    End If
        'End If

        Dim raspuns As DialogResult
        raspuns = MessageBox.Show("Stergeti Rezervarea? ", "Stergere rezervare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If raspuns = DialogResult.Yes Then
            File.WriteAllText(fisier, String.Empty)
            MessageBox.Show("Rezervarea a fost stearsa! ")
        End If
    End Sub
End Class