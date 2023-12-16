Imports System.Data.OleDb
Imports System.Data
Public Class Form4

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub DonationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DonationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DonationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloodbankDataSet)
        totald = 0
        ap = 0
        an = 0
        bp = 0
        bn = 0
        abp = 0
        abn = 0
        op = 0
        oneg = 0
        For i As Integer = 0 To donations.RowCount - 1
            If donations.Rows(i).Cells(4).Value = "A+" Then
                ap = ap + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "A-" Then
                an = an + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "B+" Then
                bp = bp + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "B-" Then
                bn = bn + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "AB+" Then
                abp = abp + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "AB-" Then
                abn = abn + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "O-" Then
                oneg = oneg + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "O+" Then
                op = op + donations.Rows(i).Cells(3).Value
            End If
            totald = totald + donations.Rows(i).Cells(3).Value
        Next

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodbankDataSet.donation' table. You can move, or remove it, as needed.
        Me.DonationTableAdapter.Fill(Me.BloodbankDataSet.donation)
        totald = 0
        ap = 0
        an = 0
        bp = 0
        bn = 0
        abp = 0
        abn = 0
        op = 0
        oneg = 0
        For i As Integer = 0 To donations.RowCount - 1
            If donations.Rows(i).Cells(4).Value = "A+" Then
                ap = ap + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "A-" Then
                an = an + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "B+" Then
                bp = bp + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "B-" Then
                bn = bn + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "AB+" Then
                abp = abp + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "AB-" Then
                abn = abn + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "O-" Then
                oneg = oneg + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "O+" Then
                op = op + donations.Rows(i).Cells(3).Value
            End If
            totald = totald + donations.Rows(i).Cells(3).Value
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DonationBindingSource.EndEdit()
        DonationTableAdapter.Update(BloodbankDataSet.donation)

        totald = 0
        ap = 0
        an = 0
        bp = 0
        bn = 0
        abp = 0
        abn = 0
        op = 0
        oneg = 0
        For i As Integer = 0 To donations.RowCount - 1
            If donations.Rows(i).Cells(4).Value = "A+" Then
                ap = ap + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "A-" Then
                an = an + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "B+" Then
                bp = bp + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "B-" Then
                bn = bn + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "AB+" Then
                abp = abp + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "AB-" Then
                abn = abn + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "O-" Then
                oneg = oneg + donations.Rows(i).Cells(3).Value
            ElseIf donations.Rows(i).Cells(4).Value = "O+" Then
                op = op + donations.Rows(i).Cells(3).Value
            End If
            totald = totald + donations.Rows(i).Cells(3).Value
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        DonationBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DonationBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DonationBindingSource.RemoveCurrent()
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.DonationTableAdapter.Search(Me.BloodbankDataSet.donation, PNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        DonationBindingSource.AddNew()
    End Sub
End Class