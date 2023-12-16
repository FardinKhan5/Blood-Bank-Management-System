Imports System.Data.OleDb
Imports System.Data
Public Class Form5

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloodbankDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodbankDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.BloodbankDataSet.stock)

        Dim querry As String = "update stock set quantity='" & totald & "'where total='Donations';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bloodbank.accdb"
        Dim conn = New OleDbConnection(dbsource)
        Dim cmd = New OleDbCommand(querry, conn)
        conn.Open()
        cmd.ExecuteScalar()

        Dim querry1 As String = "update stock set quantity='" & totala & "'where total='Alloted';"
        Dim dbsource1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bloodbank.accdb"
        Dim conn1 = New OleDbConnection(dbsource)
        Dim cmd1 = New OleDbCommand(querry, conn)

        cmd1.ExecuteScalar()

        Dim querry2 As String = "update stock set quantity='" & totalr & "'where total='Remaining';"
        Dim dbsource2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bloodbank.accdb"
        Dim conn2 = New OleDbConnection(dbsource)
        Dim cmd2 = New OleDbCommand(querry, conn)

        cmd2.ExecuteScalar()

        conn.Close()
        totalr = totald - totala
        ap2 = ap - ap1
        an2 = an - an1
        bp2 = bp - bp1
        bn2 = bn - bn1
        abp2 = abp - abp1
        abn2 = abn - abn1
        op2 = op - op1
        oneg2 = oneg - oneg1
        Label4.Text = totald
        Label5.Text = totala
        Label6.Text = totalr
        Label8.Text = ap2
        Label10.Text = an2
        Label12.Text = bp2
        Label14.Text = bn2
        Label16.Text = abp2
        Label18.Text = abn2
        Label20.Text = op2
        Label22.Text = oneg2
        
      
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.White
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.White
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class