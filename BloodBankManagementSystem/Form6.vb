Imports System.Data.OleDb
Imports System.Data
Public Class Form6

    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub ReceiveBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceiveBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReceiveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloodbankDataSet)
        totala = 0
        ap1 = 0
        an1 = 0
        bp1 = 0
        bn1 = 0
        abp1 = 0
        abn1 = 0
        op1 = 0
        oneg1 = 0
        For i As Integer = 0 To receivers.RowCount - 1
            If receivers.Rows(i).Cells(4).Value = "A+" Then
                ap1 = ap1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "A-" Then
                an1 = an1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "B+" Then
                bp1 = bp1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "B-" Then
                bn1 = bn1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "AB+" Then
                abp1 = abp1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "AB-" Then
                abn1 = abn1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "O-" Then
                oneg1 = oneg1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "O+" Then
                op1 = op1 + receivers.Rows(i).Cells(3).Value
            End If
            totala = totala + receivers.Rows(i).Cells(3).Value
        Next

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodbankDataSet.receive' table. You can move, or remove it, as needed.
        Me.ReceiveTableAdapter.Fill(Me.BloodbankDataSet.receive)
        totala = 0
        ap1 = 0
        an1 = 0
        bp1 = 0
        bn1 = 0
        abp1 = 0
        abn1 = 0
        op1 = 0
        oneg1 = 0
        For i As Integer = 0 To receivers.RowCount - 1
            If receivers.Rows(i).Cells(4).Value = "A+" Then
                ap1 = ap1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "A-" Then
                an1 = an1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "B+" Then
                bp1 = bp1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "B-" Then
                bn1 = bn1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "AB+" Then
                abp1 = abp1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "AB-" Then
                abn1 = abn1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "O-" Then
                oneg1 = oneg1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "O+" Then
                op1 = op1 + receivers.Rows(i).Cells(3).Value
            End If
            totala = totala + receivers.Rows(i).Cells(3).Value
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReceiveBindingSource.EndEdit()
        ReceiveTableAdapter.Update(BloodbankDataSet.receive)

        totala = 0
        ap1 = 0
        an1 = 0
        bp1 = 0
        bn1 = 0
        abp1 = 0
        abn1 = 0
        op1 = 0
        oneg1 = 0
        For i As Integer = 0 To receivers.RowCount - 1
            If receivers.Rows(i).Cells(4).Value = "A+" Then
                ap1 = ap1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "A-" Then
                an1 = an1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "B+" Then
                bp1 = bp1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "B-" Then
                bn1 = bn1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "AB+" Then
                abp1 = abp1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "AB-" Then
                abn1 = abn1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "O-" Then
                oneg1 = oneg1 + receivers.Rows(i).Cells(3).Value
            ElseIf receivers.Rows(i).Cells(4).Value = "O+" Then
                op1 = op1 + receivers.Rows(i).Cells(3).Value
            End If
            totala = totala + receivers.Rows(i).Cells(3).Value
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ReceiveBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ReceiveBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReceiveBindingSource.RemoveCurrent()
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.ReceiveTableAdapter.Search(Me.BloodbankDataSet.receive, PNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class