Imports System.Data.OleDb
Imports System.Data
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String
        Dim paswrd As String
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("pls fill the form")
        Else
            uname = TextBox1.Text
            paswrd = TextBox2.Text

            Dim querry As String = "Select password From [user] where username='" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bloodbank.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd = New OleDbCommand(querry, conn)
            conn.Open()

            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                'MsgBox("username does not exist")

            End Try
            If (paswrd = pass) Then
                MsgBox("Login Success")
                Form2.Show()
            Else
                MsgBox("user does not exist")
            End If
            If Form2.Visible Then
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Green
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Red
    End Sub
End Class
