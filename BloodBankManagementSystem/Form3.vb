Imports System.Data.OleDb
Imports System.Data
Public Class Form3

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub PersonBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PersonBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PersonBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BloodbankDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodbankDataSet.person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.BloodbankDataSet.person)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PersonBindingSource.EndEdit()
        PersonTableAdapter.Update(BloodbankDataSet.person)
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.PersonTableAdapter.Search(Me.BloodbankDataSet.person, PNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PersonBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PersonBindingSource.RemoveCurrent()
    End Sub
End Class