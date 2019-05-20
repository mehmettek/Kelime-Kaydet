Imports System.IO.File
Imports System.IO
Public Structure kelimeler
    Public ing As String
    Public tur As String
End Structure
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        veri_oku()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fs As FileStream = New FileStream("D:\kelimeler.txt", FileMode.Append) 'dosya yolu
            Dim aa As kelimeler = New kelimeler()
            aa.ing = TextBox1.Text.ToUpper()
            aa.tur = TextBox2.Text.ToUpper()

            Dim yaz As StreamWriter = New StreamWriter(fs)
            yaz.WriteLine("   " + aa.ing + "-----" + aa.tur)
            yaz.Close()
            ListBox1.Items.Clear()
            veri_oku()
            TextBox1.Focus()
            TextBox1.Clear()
            TextBox2.Clear()
        Catch ex As Exception

        End Try
    End Sub
    Public Function veri_oku()
        Dim lines() As String = IO.File.ReadAllLines("D:\kelimeler.txt")
        ListBox1.Items.AddRange(lines)
    End Function
End Class
